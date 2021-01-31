using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Disneyland.methon;
using Disneyland.group;

namespace Disneyland
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        methon.sqolconDataContext cn = new sqolconDataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account ac = cn.Account.FirstOrDefault(a => a.Email == txtemail.Text);
            if(ac == null)
            {
                MessageBox.Show("賬號錯誤");
                return;
            }
            if(ac.Password != txtpass.Text)
            {
                MessageBox.Show("密碼錯誤");
                return;
            }
            variable va = new variable();
            va.Accid = ac.AccountID;
            #region
            if (ac.GroupID == 1 || ac.GroupID == 2)
            {
                this.Hide();
                var admin = new user();
                admin.FormClosed += (s, args) => this.Close();
                admin.Show();
            }
            if(ac.GroupID == 3 || ac.GroupID == 4)
            {
                this.Hide();
                var admin = new admin();
                admin.FormClosed += (s, args) => this.Close();
                admin.Show();
            }
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            variable va = new variable();
            va.Back = "1";
            this.Hide();
            var admin = new function.signup();
            admin.FormClosed += (s, args) => this.Close();
            admin.Show();
        }
    }
}
