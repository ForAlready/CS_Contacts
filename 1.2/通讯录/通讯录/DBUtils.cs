using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
using System.Diagnostics;

namespace 通讯录
{
    public class DBUtils
    {
        static SqlConnection _connectionPool;
        public static SqlConnection GetConnection()
        {
            if (_connectionPool == null)
            {
                try
                {
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    builder.DataSource = ".";
                    builder.InitialCatalog = "TXL";
                    builder.IntegratedSecurity = true;
                    _connectionPool = new SqlConnection(builder.ConnectionString);

                    _connectionPool.Open();
                }
                catch (SqlException s)
                {
                    _connectionPool.Close();
                    if (MessageBox.Show("通讯录数据库不存在\r\n是否要创建？", "新建数据库", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        //程序路径
                        string appPath = System.Windows.Forms.Application.StartupPath;
                        CreateDb(appPath);
                        CreateTables();
                        CreateTriggers();
                        MessageBox.Show("创建成功！\r\n请重新启动程序", "重新启动", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //重新启动
                        System.Windows.Forms.Application.Restart();
                        Process.GetCurrentProcess().Kill();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }
            return _connectionPool;
        }
        public static void Close()
        {
            if (_connectionPool != null)
            {
                _connectionPool.Close();
            }
        }
        //创建数据库
        private static void CreateDb(string appPath)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.InitialCatalog = "master";
            builder.IntegratedSecurity = true;
            _connectionPool = new SqlConnection(builder.ConnectionString);
            _connectionPool.Open();

            string dbPath = System.IO.Path.Combine(appPath, "database");
            if (!Directory.Exists(dbPath))
            {
                Directory.CreateDirectory(dbPath);
            }
            string createSql = "CREATE DATABASE TXL ON (NAME=TXL,FILENAME=" +
                "\"" + dbPath + "\\TXL.mdf" + "\"" +
                ",SIZE=5,FILEGROWTH=1) LOG ON(NAME=TXL_LOG, FILENAME=" +
                "\"" + dbPath + "\\TXL_log.ldf" + "\"" +
                ",SIZE=2,MAXSIZE=20,FILEGROWTH=10%)";
            SqlCommand cmd = new SqlCommand(createSql, _connectionPool);
            cmd.ExecuteNonQuery();
            _connectionPool.Close();
        }
        //创建表
        private static void CreateTables()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            //builder.InitialCatalog = "TXL";
            builder.IntegratedSecurity = true;
            _connectionPool = new SqlConnection(builder.ConnectionString);
            _connectionPool.Open();

            string changeDb = "USE TXL";
            string newCInfo = "CREATE TABLE [dbo].[CInfo]" +
                "([PersonName] [varchar](20) NOT NULL," +
                "[Sex] [nchar](3) NULL," +
                "[QQ] [varchar](20) NULL," +
                "[WeChat] [varchar](20) NULL," +
                "[PersonAddress] [text] NULL," +
                "[PersonGroup] [varchar](10) NULL," +
                "PRIMARY KEY(PersonName))";
            string newCPhone = "CREATE TABLE CPhone" +
                "(CId INT IDENTITY(1,1)PRIMARY KEY," +
                "PersonName VARCHAR(20) CONSTRAINT FK_CPhone_CInfo_PersonName REFERENCES dbo.CInfo(PersonName)," +
                "PhoneNum VARCHAR(12) CONSTRAINT U_PhoneNum UNIQUE)";
            SqlCommand cmdDb = new SqlCommand(changeDb, _connectionPool);
            SqlCommand cmdCInfo = new SqlCommand(newCInfo, _connectionPool);
            SqlCommand cmdCPhone = new SqlCommand(newCPhone, _connectionPool);
            cmdDb.ExecuteNonQuery();
            cmdCInfo.ExecuteNonQuery();
            cmdCPhone.ExecuteNonQuery();
            _connectionPool.Close();
        }
        //创建触发器
        private static void CreateTriggers()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            //builder.InitialCatalog = "TXL";
            builder.IntegratedSecurity = true;
            _connectionPool = new SqlConnection(builder.ConnectionString);
            _connectionPool.Open();

            string changeDb = "USE TXL";
            string tg_UPD_DEL_CInfo = "create TRIGGER [dbo].[UPD_DEL_CInfo_Trigger] ON [dbo].[CInfo] " +
                "INSTEAD OF UPDATE,DELETE " +
                "AS " +
                "BEGIN " +
                "IF UPDATE(PersonName) " +
                "BEGIN " +
                "INSERT INTO CInfo " +
                "SELECT * FROM inserted " +
                "UPDATE CPhone " +
                "SET PersonName=(SELECT PersonName FROM inserted) " +
                "WHERE PersonName IN(SELECT PersonName FROM deleted) " +
                "DELETE FROM CInfo " +
                "WHERE PersonName IN(SELECT PersonName FROM deleted) " +
                "END " +
                "ELSE IF COLUMNS_UPDATED()=0 " +
                "BEGIN " +
                "DELETE FROM CPhone WHERE PersonName IN(SELECT PersonName FROM deleted) " +
                "DELETE FROM CInfo WHERE PersonName IN(SELECT PersonName FROM deleted) " +
                "END " +
                "ELSE " +
                "BEGIN " +
                "DELETE FROM CInfo " +
                "WHERE PersonName IN(SELECT PersonName FROM deleted) " +
                "INSERT INTO CInfo SELECT * FROM inserted " +
                "END " +
                "END ";
            SqlCommand cmdChangeDb = new SqlCommand(changeDb, _connectionPool);
            SqlCommand cmd_tg_UPD_DEL_CInfo = new SqlCommand(tg_UPD_DEL_CInfo, _connectionPool);
            cmdChangeDb.ExecuteNonQuery();
            cmd_tg_UPD_DEL_CInfo.ExecuteNonQuery();
            _connectionPool.Close();
        }

        //查询数据
        public static SqlDataReader GetDataReader()
        {
            //SqlDataReader 需要在SqlConnection打开时执行showCmd.ExecuteReader()返回示例化对象
            if (_connectionPool != null && _connectionPool.State == ConnectionState.Closed)
            {
                _connectionPool.Open();
            }
            string showSql = "SELECT CId,CPhone.PersonName,PhoneNum,Sex,QQ,WeChat,PersonAddress,PersonGroup " +
                "FROM CPhone JOIN CInfo " +
                "ON CPhone.PersonName=CInfo.PersonName";
            SqlCommand showCmd = new SqlCommand(showSql, _connectionPool);
            SqlDataReader sqlDataReader = showCmd.ExecuteReader();
            return sqlDataReader;
        }
        //插入数据
        public static int InsertContact(Contact contact)
        {
            //SqlDataReader 需要在SqlConnection打开时执行showCmd.ExecuteReader()返回示例化对象
            if (_connectionPool != null && _connectionPool.State == ConnectionState.Closed)
            {
                _connectionPool.Open();
            }
            //string insertCInfo = "INSERT INTO CInfo(PersonName,Sex,QQ,WeChat,PersonAddress,PersonGroup)" +
            //    "VALUES(@PersonName,@Sex,@QQ,@WeChat,@PersonAddress,@PersonGroup)";
            //string insertCPhone = "INSERT INTO CPhone(PersonName,PhoneNum)" +
            //    "VALUES(@PersonName,@PhoneNum)";

            //SqlCommand insertCPhoneCmd = new SqlCommand(insertCPhone,_connectionPool);
            //SqlCommand insertCInfoCmd = new SqlCommand( insertCInfo,_connectionPool);

            //insertCInfoCmd.Parameters.AddWithValue("@PersonName",contact.PersonName);
            //insertCInfoCmd.Parameters.AddWithValue("@Sex",contact.Sex);
            //insertCInfoCmd.Parameters.AddWithValue("@QQ",contact.QQ);
            //insertCInfoCmd.Parameters.AddWithValue("@WeChat",contact.WeChat);
            //insertCInfoCmd.Parameters.AddWithValue("@PersonAddress",contact.PersonAddress);
            //insertCInfoCmd.Parameters.AddWithValue("@PersonGroup", contact.PersonGroup);

            //insertCPhoneCmd.Parameters.AddWithValue("@PersonName",contact.PersonName);
            //insertCPhoneCmd.Parameters.AddWithValue("@PhoneNum",contact.PhoneNum);


            //先插入必填项，必填项在数据库中不能为空
            string insertCInfo = "INSERT INTO CInfo(PersonName,Sex)VALUES(@PersonName,@Sex)";
            string insertCPhone = "INSERT INTO CPhone(PersonName,PhoneNum)VALUES(@PersonName,@PhoneNum)";
            SqlCommand insertCPhoneCmd = new SqlCommand(insertCPhone, _connectionPool);
            SqlCommand insertCInfoCmd = new SqlCommand(insertCInfo, _connectionPool);
            //CInfo必填项
            insertCInfoCmd.Parameters.AddWithValue("@PersonName", contact.PersonName);
            insertCInfoCmd.Parameters.AddWithValue("@Sex", contact.Sex);
            //CPhone必填项
            insertCPhoneCmd.Parameters.AddWithValue("@PersonName", contact.PersonName);
            insertCPhoneCmd.Parameters.AddWithValue("@PhoneNum", contact.PhoneNum);

            int count = 0;
            count += insertCInfoCmd.ExecuteNonQuery();
            count += insertCPhoneCmd.ExecuteNonQuery();

            //CInfo补充项
            //临时禁用外键约束
            string disableForeignKey = "ALTER TABLE CPhone NOCHECK CONSTRAINT FK_CPhone_CInfo_PersonName";
            //启用外键约束
            string enableForeignKey = "ALTER TABLE CPhone CHECK CONSTRAINT FK_CPhone_CInfo_PersonName";
            SqlCommand cmdDisableFK = new SqlCommand(disableForeignKey, _connectionPool);
            SqlCommand cmdEnableFK = new SqlCommand(enableForeignKey, _connectionPool);

            cmdDisableFK.ExecuteNonQuery();
            //QQ
            if (!contact.QQ.Equals(""))
            {
                string appendCInfo = "UPDATE CInfo SET QQ=@QQ WHERE PersonName=@PersonName";
                SqlCommand appendCInfoCmd = new SqlCommand(appendCInfo, _connectionPool);
                appendCInfoCmd.Parameters.AddWithValue("@QQ", contact.QQ);
                appendCInfoCmd.Parameters.AddWithValue("@PersonName", contact.PersonName);
                count += appendCInfoCmd.ExecuteNonQuery();
            }
            //微信
            if (!contact.WeChat.Equals(""))
            {
                string appendCInfo = "UPDATE CInfo SET WeChat=@WeChat WHERE PersonName=@PersonName";
                SqlCommand appendCInfoCmd = new SqlCommand(appendCInfo, _connectionPool);
                appendCInfoCmd.Parameters.AddWithValue("@WeChat", contact.WeChat);
                appendCInfoCmd.Parameters.AddWithValue("@PersonName", contact.PersonName);
                count += appendCInfoCmd.ExecuteNonQuery();
            }
            //地址
            if (!contact.PersonAddress.Equals(""))
            {
                string appendCInfo = "UPDATE CInfo SET PersonAddress=@PersonAddress WHERE PersonName=@PersonName";
                SqlCommand appendCInfoCmd = new SqlCommand(appendCInfo, _connectionPool);
                appendCInfoCmd.Parameters.AddWithValue("@PersonAddress", contact.PersonAddress);
                appendCInfoCmd.Parameters.AddWithValue("@PersonName", contact.PersonName);
                count += appendCInfoCmd.ExecuteNonQuery();
            }

            cmdEnableFK.ExecuteNonQuery();
            return count;


        }
        //已有联系人添加电话号码
        public static int AddPhoneNum(Contact contact)
        {
            int count = 0;
            if (_connectionPool != null && _connectionPool.State == ConnectionState.Closed)
            {
                _connectionPool.Open();
            }
            string insertCPhone = "INSERT INTO CPhone(PersonName,PhoneNum)VALUES(@PersonName,@PhoneNum)";
            SqlCommand insertCPhoneCmd = new SqlCommand(insertCPhone, _connectionPool);
            insertCPhoneCmd.Parameters.AddWithValue("@PersonName", contact.PersonName);
            insertCPhoneCmd.Parameters.AddWithValue("@PhoneNum", contact.PhoneNum);
            count += insertCPhoneCmd.ExecuteNonQuery();
            return count;
        }

        //更新指定联系人数据
        public static int UpdateContact(Contact oldContact, Contact newContact)
        {
            int count = 0;
            if (_connectionPool != null && _connectionPool.State == ConnectionState.Closed)
            {
                _connectionPool.Open();
            }
            //先修改必填项，必填项在数据库中不能为空
            if (!oldContact.PersonName.Equals(newContact.PersonName))
            {
                string updateCInfo = "UPDATE CINFO SET PersonName=@NewPersonName " +
                    "Where PersonName=@OldPersonName";
                SqlCommand updateCInfoCmd = new SqlCommand(updateCInfo, _connectionPool);
                updateCInfoCmd.Parameters.AddWithValue("@NewPersonName", newContact.PersonName);
                updateCInfoCmd.Parameters.AddWithValue("@OldPersonName", oldContact.PersonName);
                count += updateCInfoCmd.ExecuteNonQuery();

            }
            if (!oldContact.PhoneNum.Equals(newContact.PhoneNum))
            {
                string updateCPhone = "UPDATE CPhone SET PhoneNum=@NewPhoneNum " +
                    "WHERE PersonName=@NewPersonName";
                SqlCommand updateCPhoneCmd = new SqlCommand(updateCPhone, _connectionPool);
                updateCPhoneCmd.Parameters.AddWithValue("@NewPhoneNum", newContact.PhoneNum);
                updateCPhoneCmd.Parameters.AddWithValue("@NewPersonName", newContact.PersonName);
                count += updateCPhoneCmd.ExecuteNonQuery();
            }
            //补充
            //更新性别
            if (!oldContact.Sex.Equals(newContact.Sex))
            {
                string appendCInfo = "UPDATE CInfo SET Sex=@NewSex" +
                    " WHERE PersonName=@NewPersonName";
                SqlCommand appendCInfoCmd = new SqlCommand(appendCInfo, _connectionPool);
                appendCInfoCmd.Parameters.AddWithValue("@NewSex", newContact.Sex);
                appendCInfoCmd.Parameters.AddWithValue("@NewPersonName", newContact.PersonName);
                count += appendCInfoCmd.ExecuteNonQuery();
            }
            //更新QQ
            if (!oldContact.QQ.Equals(newContact.QQ))
            {
                string appendCInfo = "UPDATE CInfo SET QQ=@NewQQ" +
                    " WHERE PersonName=@NewPersonName";
                SqlCommand appendCInfoCmd = new SqlCommand(appendCInfo, _connectionPool);
                appendCInfoCmd.Parameters.AddWithValue("@NewQQ", newContact.QQ);
                appendCInfoCmd.Parameters.AddWithValue("@NewPersonName", newContact.PersonName);
                count += appendCInfoCmd.ExecuteNonQuery();
            }
            //更新微信
            if (!oldContact.WeChat.Equals(newContact.WeChat))
            {
                string appendCInfo = "UPDATE CInfo SET WeChat=@NewWeChat " +
                    "WHERE PersonName=@NewPersonName";
                SqlCommand appendCInfoCmd = new SqlCommand(appendCInfo, _connectionPool);
                appendCInfoCmd.Parameters.AddWithValue("@NewWeChat", newContact.WeChat);
                appendCInfoCmd.Parameters.AddWithValue("@NewPersonName", newContact.PersonName);
                count += appendCInfoCmd.ExecuteNonQuery();
            }
            //更新地址
            if (!oldContact.PersonAddress.Equals(newContact.PersonAddress))
            {
                string appendCInfo = "UPDATE CInfo SET PersonAddress=@NewPersonAddress " +
                    "WHERE PersonName=@NewPersonName";
                SqlCommand appendCInfoCmd = new SqlCommand(appendCInfo, _connectionPool);
                appendCInfoCmd.Parameters.AddWithValue("@NewPersonAddress", newContact.PersonAddress);
                appendCInfoCmd.Parameters.AddWithValue("@NewPersonName", newContact.PersonName);
                count += appendCInfoCmd.ExecuteNonQuery();
            }

            return count;

        }
        //删除联系人所有信息
        public static int DelContact(Contact contact)
        {
            if (_connectionPool != null && _connectionPool.State == ConnectionState.Closed)
            {
                _connectionPool.Open();
            }
            int count = 0;
            string delCInfo = "DELETE FROM CInfo WHERE PersonName=@PersonName";
            SqlCommand delCInfoCmd = new SqlCommand(delCInfo, _connectionPool);
            delCInfoCmd.Parameters.AddWithValue("@PersonName", contact.PersonName);
            count += delCInfoCmd.ExecuteNonQuery();
            return count;
        }
        //删除电话号码
        public static int DelPhoneNum(Contact contact)
        {
            if (_connectionPool != null && _connectionPool.State == ConnectionState.Closed)
            {
                _connectionPool.Open();
            }
            int count = 0;
            string delCPhone = "DELETE FROM CPhone WHERE CId=@CId";
            SqlCommand deleteCPhoneCmd = new SqlCommand(delCPhone, _connectionPool);
            deleteCPhoneCmd.Parameters.AddWithValue("@CId", contact.CID);
            count += deleteCPhoneCmd.ExecuteNonQuery();
            return count;
        }

    }
}
