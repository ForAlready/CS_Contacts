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
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();
        }

        public Contact contact = null;
        private void DetailForm_Load(object sender, EventArgs e)
        {
            this.Text = "联系人详情：" + contact.PersonName;
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
    }
}
