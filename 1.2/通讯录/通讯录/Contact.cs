using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 通讯录
{
    public class Contact
    {
        public int CID { get; set; }
        public string PersonName { get; set; }
        public string PhoneNum { get; set; }
        public string Sex { get; set; }
        public string QQ { get; set; }
        public string WeChat { get; set; }
        public string PersonAddress { get; set; }
        public string PersonGroup { get; set; }
        public Contact() { }
        public static int  FindContact(List<Contact> conatcts,int index,string target)
        {
            return 0;
        }

    }
}
