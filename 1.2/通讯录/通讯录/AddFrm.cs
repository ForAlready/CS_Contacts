using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 通讯录
{
    public partial class AddFrm : Form
    {
        public AddFrm()
        {
            InitializeComponent();
        }
        public List<Contact> contacts = null;
        //初始化，清空
        void Init()
        {
            textName.Text = "";
            textPhone.Text = "";
            textPhone.ForeColor = Color.Black;
            textPhone.Text = "";
            textQQ.Text = "";
            textWeChat.Text= "";
            textAddress.Text = "";
            lbWarning.Text = "";
            lbPhoneWaring.Text = "";
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfrim_Click(object sender, EventArgs e)
        {
            //创建contact对象封装联系人信息
            Contact contact = new Contact();
            try
            {
                if (rBtnM.Checked)
                {
                    contact.Sex = "男";
                }
                else if (rBtnF.Checked)
                {
                    contact.Sex = "女";
                }
                
                contact.WeChat = textWeChat.Text;
                contact.QQ = textQQ.Text;
                contact.PersonAddress = textAddress.Text;
                contact.PersonGroup = "";
            }
            finally
            {
                if(textName.Text.Equals(""))
                {
                    lbWarning.Text = "姓名不能为空！";
                }
                else if(textPhone.Text.Equals(""))
                {
                    lbPhoneWaring.Text = "电话号码不能为空！";
                }
                else
                {
                    contact.PersonName = textName.Text;
                    contact.PhoneNum = textPhone.Text;
                    if(contacts.Find(c=>c.PhoneNum == contact.PhoneNum)!=null)
                    {
                        lbPhoneWaring.Text = "该电话号码已存在！";
                        textPhone.Focus();
                        textPhone.BackColor = Color.MintCream;
                        textPhone.ForeColor = Color.Red;
                    }
                    else if(contacts.Find(c=>c.PersonName==contact.PersonName)!=null)
                    {
                        DBUtils.GetConnection();
                        DBUtils.AddPhoneNum(contact);
                        DBUtils.Close();
                        lbMess.Text = "已存在联系人：" + textName.Text + "\r\n已成功添加新电话号码！";
                        Init();
                    }
                    else
                    {
                        DBUtils.GetConnection();
                        DBUtils.InsertContact(contact);
                        DBUtils.Close();
                        lbMess.Text = textName.Text + "已成功添加！";
                        Init();
                    }
                    //this.Close();
                }
            }

        }

        private void AddFrm_Load(object sender, EventArgs e)
        {

        }

        private void lbPhoneWaring_Click(object sender, EventArgs e)
        {

        }

        private void lbWarning_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lbMess_Click(object sender, EventArgs e)
        {

        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textWeChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textQQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {
            if(textPhone.ForeColor==Color.Red)
            {
                textPhone.ForeColor = Color.DodgerBlue;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void textPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.btnConfrim_Click(sender,e);
            }
        }


    }
}
