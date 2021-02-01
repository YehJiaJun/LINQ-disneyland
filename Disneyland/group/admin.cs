using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disneyland.group
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            color1.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            changeuser1.BringToFront();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            var admin = new Form1();
            admin.FormClosed += (s, args) => this.Close();
            admin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            themePark1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            traffic1.BringToFront();
        }
    }
}
