using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 通讯录
{
    public partial class MdFrm : Form
    {
        public MdFrm()
        {
            InitializeComponent();
        }
        //通过Contact对象传递数据
        public Contact contact = null;
        //
        public List<Contact> contacts = null;
        private void MdFrm_Load(object sender, EventArgs e)
        {
            textName.Text = contact.PersonName;
            if (contact.Sex.Contains("男"))
            {
                rBtnM.Checked = true;
            }
            else if (contact.Sex.Contains("女"))
            {
                rBtnF.Checked = true;
            }
            textPhone.Text = contact.PhoneNum;
            textQQ.Text = contact.QQ;
            textWeChat.Text = contact.WeChat;
            textAddress.Text = contact.PersonAddress;

        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            lbNameStar.Visible = true;
        }

        private void rBtnF_CheckedChanged(object sender, EventArgs e)
        {
            lbSexStar.Visible = true;
        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {
            lbPhoneStar.Visible = true;
        }

        private void textQQ_TextChanged(object sender, EventArgs e)
        {
            lbQQStar.Visible = true;
        }

        private void textWeChat_TextChanged(object sender, EventArgs e)
        {
            lbWeChatStar.Visible = true;
        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {
            lbAddressStar.Visible = true;
        }

        //确认，更新数据
        private void btnConfrim_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact();  //封装新数据
            int phoneNum = 0;    //记录旧联系人中电话号码个数
            try
            {
                if (rBtnM.Checked)
                {
                    newContact.Sex = "男";
                }
                else if (rBtnF.Checked)
                {
                    newContact.Sex = "女";
                }

                newContact.WeChat = textWeChat.Text;
                newContact.QQ = textQQ.Text;
                newContact.PersonAddress = textAddress.Text;
                newContact.PersonGroup = "";
            }
            finally
            {
                if (textName.Text.Equals(""))
                {
                    lbWarning.Text = "姓名不能为空！";
                }
                else if (textPhone.Text.Equals(""))
                {
                    lbPhoneWaring.Text = "电话号码不能为空！";
                }
                else
                {
                    newContact.PersonName = textName.Text;
                    newContact.PhoneNum = textPhone.Text;
                    //已存在同名联系人，将电话号码并入
                    if (newContact.PersonName!=contact.PersonName && contacts.FindAll(c => c.PersonName == newContact.PersonName).Count>0)
                    {
                        if (MessageBox.Show("已存在联系人：" + newContact.PersonName +
                            "\r\n是否将电话号码添加到该联系人信息中？\r\n(注：仅保留电话号码！)",
                            "联系人已存在", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            DBUtils.GetConnection();

                            //统计旧联系人中电话号码个数
                            phoneNum = contacts.FindAll(c => c.PersonName == contact.PersonName).Count;
                            //先删除旧数据
                            //旧联系人信息只剩一条数据，删除旧联系人所有信息
                            if (phoneNum <= 1)
                            {
                                DBUtils.DelContact(contact);
                            }
                            else
                            {
                                DBUtils.DelPhoneNum(contact);
                            }
                            //添加数据
                            DBUtils.AddPhoneNum(newContact);
                            DBUtils.Close();
                            lbMess.Text = textName.Text + "已成功修改并添加！";
                            this.Close();
                        }
                        //取消对话框，姓名文本框提示
                        textName.BackColor = Color.MintCream;
                        textName.ForeColor = Color.Red;
                        textName.Focus();
                    }
                    else
                    {
                        DBUtils.GetConnection();
                        DBUtils.UpdateContact(contact, newContact);
                        DBUtils.Close();
                        lbMess.Text = textName.Text + "已成功修改！";
                        this.Close();

                    }
                }
            }
        }

        private void textPhone_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.btnConfrim_Click(sender, e);
            }
        }

        private void textName_TextChanged_1(object sender, EventArgs e)
        {
            if(textName.ForeColor== Color.Red)
            {
                textName.ForeColor = Color.DodgerBlue; 
            }
        }
    }
}
