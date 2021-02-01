using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Disneyland.function
{
    public partial class changeuser : UserControl
    {
        public changeuser()
        {
            InitializeComponent();
        }

        private bool Mail(string str)
        {
            bool bin;
            try
            {
                MailAddress ma = new MailAddress(str);
                bin = true;
            }
            catch
            {
                bin = false;
            }
            return bin;
        }

        string email;
        string id;
        private void changeuser_Load(object sender, EventArgs e)
        {
            methon.variable va = new methon.variable();
            id = va.Accid;
            txtBirthday.MaxDate = DateTime.Today;
            var select = db.Account.FirstOrDefault(x => x.AccountID == id);
            txtBirthday.Value = select.Birthday.Value;
            txtcity.Text = select.Citizenship;
            txtemail.Text = select.Email;
            email = txtemail.Text;
            txtname.Text = select.Name;
            txtpass.Text = select.Password;
            txtsex.Text = select.Gender.ToString();
        }
        methon.sqolconDataContext db = new methon.sqolconDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            if (Mail(txtemail.Text) == false)
            {
                MessageBox.Show("電子郵件不符合格式");
                return;
            }
            if(txtemail.Text != email)
            {
                methon.Account ac = db.Account.FirstOrDefault(a => a.Email == txtemail.Text);
                if (ac != null)
                {
                    MessageBox.Show("此賬號已註冊");
                    return;
                }
            }
                var update = from a in db.Account where a.AccountID == id select a;
                foreach(var i in update)
                {
                    i.Birthday = txtBirthday.Value;
                    i.Name = txtname.Text.Replace("'", "''");
                    i.Email = txtemail.Text.Replace("'", "''");
                    i.Gender = txtsex.Text[0];
                    i.Password = txtpass.Text.Replace("'", "''");
                    i.Citizenship = txtcity.Text.Replace("'", "''");
                }
                db.SubmitChanges();
            MessageBox.Show("保存完成");
        }
    }
}
