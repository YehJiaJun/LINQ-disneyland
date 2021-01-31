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
    public partial class signup : Form
    {
        public signup()
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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Control ct in this.Controls)
            {
                if(ct is TextBox)
                {
                    if(string.IsNullOrEmpty(ct.Text))
                    {
                        MessageBox.Show("項目不能為空");
                        return;
                    }
                }
            }
            if(Mail(txtemail.Text) == false)
            {
                MessageBox.Show("電子郵件不符合格式");
                return;
            }
            methon.sqolconDataContext cn = new methon.sqolconDataContext();
            methon.Account ac = cn.Account.FirstOrDefault(a => a.Email == txtemail.Text);
            if(ac != null)
            {
                MessageBox.Show("此賬號已註冊");
                return;
            }
            var aid = cn.Account.OrderByDescending(x => x.AccountID);
            string[] test = new string[99];
            int i = 0;
            foreach (var item in aid)
            {
                test[i] = item.AccountID;
                i += 1;
            }
            string str = (Convert.ToInt32(test[0]) + 1).ToString().PadLeft(10,'0');
            var signup = new methon.Account
            {
                AccountID = str,
                Name = txtname.Text.Replace("'", "''"),
                Email = txtemail.Text.Replace("'", "''"),
                Birthday = txtBirthday.Value,
                Gender = txtsex.Text[0],
                GroupID = 1,
                Password = txtpass.Text.Replace("'","''"),
                Citizenship = txtcity.Text.Replace("'","''")
            };
            cn.Account.InsertOnSubmit(signup);
            cn.SubmitChanges();
            MessageBox.Show("註冊完成，將返回登錄畫面");
            this.Hide();
            var admin = new Form1();
            admin.FormClosed += (s, args) => this.Close();
            admin.Show();
        }

        private void signup_Load(object sender, EventArgs e)
        {
            txtBirthday.MaxDate = DateTime.Today;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            methon.variable va = new methon.variable();
            if(va.Back == "1")
            {
                this.Hide();
                var admin = new Form1();
                admin.FormClosed += (s, args) => this.Close();
                admin.Show();
            }
        }
    }
}
