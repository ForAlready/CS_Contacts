using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Claims;
using System.IO;

namespace 通讯录
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //联系人信息列表
        List<Contact> contacts = new List<Contact>();
        //查询联系人的信息
        void GetContacts()
        {
            try
            {
                //从连接池中获取连接并打开
                DBUtils.GetConnection();
                SqlDataReader dataReader = DBUtils.GetDataReader();
                contacts = new List<Contact>();
                while (dataReader.Read())
                {
                    Contact contact = new Contact();
                    contact.CID = int.Parse(dataReader["CId"].ToString());
                    contact.PersonName = dataReader["PersonName"].ToString();
                    contact.PhoneNum = dataReader["PhoneNum"].ToString();
                    contact.Sex = dataReader["Sex"].ToString();
                    contact.QQ = dataReader["QQ"].ToString();
                    contact.WeChat = dataReader["WeChat"].ToString();
                    contact.PersonAddress = dataReader["PersonAddress"].ToString();
                    contact.PersonGroup = dataReader["PersonGroup"].ToString();
                    //加入contacts链表
                    contacts.Add(contact);
                }
                dataReader.Close();
            }
            finally
            {
                DBUtils.Close();
            }
        }
        //将数据显示到dgv中
        void FillGrid()
        {
            GetContacts();
            //清空旧数据
            dgv.Rows.Clear();
            //填充新数据
            for (int i = 0; i < contacts.Count; i++)
            {
                int count = dgv.RowCount;
                dgv.Rows.Add();

                dgv.Rows[count].Cells["CID"].Value = contacts[i].CID;
                dgv.Rows[count].Cells["PersonName"].Value = contacts[i].PersonName;
                dgv.Rows[count].Cells["PhoneNum"].Value = contacts[i].PhoneNum;
                dgv.Rows[count].Cells["Sex"].Value = contacts[i].Sex;
                dgv.Rows[count].Cells["QQ"].Value = contacts[i].QQ;
                dgv.Rows[count].Cells["WeChat"].Value = contacts[i].WeChat;
                dgv.Rows[count].Cells["PersonAddress"].Value = contacts[i].PersonAddress;
                //dgv.Rows[count].Cells["PersonGroup"].Value = contacts[i].PersonGroup;

            }
        }
        //窗口初始化时，显示数据
        private void Form1_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorFrm afrm = new AuthorFrm();
            afrm.ShowDialog();
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MBtnShow_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void MBtnAdd_Click(object sender, EventArgs e)
        {
            AddFrm addFrm = new AddFrm();
            addFrm.contacts = contacts;
            addFrm.ShowDialog();
            FillGrid();
        }

        private void MBtnModify_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("请选择联系人");
                return;
            }
            int index = dgv.CurrentRow.Index;
            //Console.WriteLine(index);
            MdFrm mdFrm = new MdFrm();
            mdFrm.contact = contacts[index];
            mdFrm.contacts=contacts;
            mdFrm.ShowDialog();
            FillGrid();
        }

        private void MBtnDel_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("请选择联系人");
                return;
            }
            int index = dgv.CurrentRow.Index;
            string PersonName = contacts[index].PersonName;
            //该联系人信息只剩一条数据，删除该联系人所有信息
            if (contacts.FindAll(c => c.PersonName == PersonName).Count() <= 1)
            {
                if (MessageBox.Show("删除联系人：" + contacts[index].PersonName, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    DBUtils.DelContact(contacts[index]);
                }
            }
            else
            {
                if (MessageBox.Show("删除联系人：" + contacts[index].PersonName + "\r\n删除电话号码：" + contacts[index].PhoneNum, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    DBUtils.DelPhoneNum(contacts[index]);
                }
            }
            FillGrid();
            //Console.WriteLine(index);
        }

        private void MBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //查询
        private void BtnFind_Click(object sender, EventArgs e)
        {
            if (textFind == null && textFind.Equals(""))
            {
                return;
            }
            if (contacts.FindAll(c => c.PersonName.Contains(textFind.Text)).Count == 0)
            {
                MessageBox.Show("未找到联系人：" + textFind.Text, "搜索结果", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //清空当前行
            dgv.Rows.Clear();
            foreach (Contact contact in contacts.FindAll(c => c.PersonName.Contains(textFind.Text)))
            {
                int count = dgv.Rows.Count;
                dgv.Rows.Add();
                dgv.Rows[count].Cells["CID"].Value = contact.CID;
                dgv.Rows[count].Cells["PersonName"].Value = contact.PersonName;
                dgv.Rows[count].Cells["PhoneNum"].Value = contact.PhoneNum;
                dgv.Rows[count].Cells["Sex"].Value = contact.Sex;
                dgv.Rows[count].Cells["QQ"].Value = contact.QQ;
                dgv.Rows[count].Cells["WeChat"].Value = contact.WeChat;
                dgv.Rows[count].Cells["PersonAddress"].Value = contact.PersonAddress;
            }
        }

        private void MBtnSearch_Click(object sender, EventArgs e)
        {
            textFind.Visible = !textFind.Visible;
            //将焦点设置在查询文本框上
            if (textFind.Visible == true)
            {
                textFind.Focus();
            }
            BtnFind.Visible = !BtnFind.Visible;
        }

        private void MBtnExport_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count <= 0)
            {
                MessageBox.Show("当前无可导出数据", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string exportContent = "ID,姓名,联系电话,性别,QQ,微信号,联系地址\r\n";
            foreach (DataGridViewRow d in dgv.Rows)
            {
                exportContent += d.Cells["CID"].Value;
                exportContent += ",";
                exportContent += d.Cells["PersonName"].Value;
                exportContent += ",";
                exportContent += d.Cells["PhoneNum"].Value;
                exportContent += ",";
                exportContent += d.Cells["Sex"].Value;
                exportContent += ",";
                exportContent += d.Cells["QQ"].Value;
                exportContent += ",";
                exportContent += d.Cells["WeChat"].Value;
                exportContent += ",";
                exportContent += d.Cells["PersonAddress"].Value;
                exportContent += "\r\n";
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, exportContent, Encoding.UTF8);
                //保存失败错误弹窗
                if (!File.Exists(saveFileDialog1.FileName))
                {
                    MessageBox.Show("联系人导出失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //MessageBox.Show(exportContent);   //测试
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //未选择行；选择标题行
            if (dgv.CurrentRow == null || dgv.CurrentRow.Index <= -1)
            {
                MessageBox.Show("请选择联系人");
                return;
            }
            int index = dgv.CurrentRow.Index;
            DetailForm detailForm = new DetailForm();
            detailForm.contact = contacts[index];
            detailForm.ShowDialog();
        }

        private void textFind_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.BtnFind_Click(sender, e);
            }
        }
    }
}
