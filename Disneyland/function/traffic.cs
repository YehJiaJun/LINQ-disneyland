using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Disneyland.function
{
    public partial class traffic : UserControl
    {
        public traffic()
        {
            InitializeComponent();
        }
        methon.sqolconDataContext db = new methon.sqolconDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            tc.SelectedTab = tp1;
            color1.Hide();
            var select = db.Newtext.FirstOrDefault(x => x.Newid == 1);
            txt1.Text = select.Newtxt1;
            txt2.Text = select.Newtxt2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tc.SelectedTab = tp2;
            color1.Hide();
            var select = db.Newtext.FirstOrDefault(x => x.Newid == 2);
            txt3.Text = select.Newtxt1;
            txt4.Text = select.Newtxt2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tc.SelectedTab = tp3;
            color1.Hide();
            var select = db.Newtext.FirstOrDefault(x => x.Newid == 3);
            txttitle.Text = select.Newtxt1;
            txtsh.Text = select.Newtxt2;
            txtintroduction.Text = select.Newtxt3;
            object picstr = select.NewPic;
            if (picstr != null && picstr != "")
                picbox.Image = Image.FromFile(picstr.ToString());
            else
                picbox.Image = default;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tc.SelectedTab = tp4;
            color1.Hide();
            var select = db.Newtext.FirstOrDefault(x => x.Newid == 4);
            txt5.Text = select.Newtxt1;
            txt6.Text = select.Newtxt2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tc.SelectedTab = tp5;
            color1.Hide();
            var select = db.Newtext.FirstOrDefault(x => x.Newid == 5);
            txt7.Text = select.Newtxt1;
            txt8.Text = select.Newtxt2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "-匯入圖片";
            if(op.ShowDialog() == DialogResult.OK)
            {
                Guid guid = Guid.NewGuid();
                string file = @".\image\" + guid + ".jpg";
                string picstr = Path.GetFullPath(op.FileName);
                File.Copy(picstr, file);
                methon.Newtext mn = db.Newtext.FirstOrDefault(x => x.Newid == 3);
                mn.NewPic = file;
                db.SubmitChanges();
                picbox.Image = Image.FromFile(file);
                MessageBox.Show("匯入成功");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var up = from x in db.Newtext where x.Newid == 3 select x;
            foreach (var i in up)
                i.NewPic = null;
            db.SubmitChanges();
            picbox.Image = default;
            MessageBox.Show("刪除成功");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var up = from x in db.Newtext where x.Newid == 1 select x;
            foreach(var i in up)
            {
                i.Newtxt1 = txt1.Text.Replace("'", "''");
                i.Newtxt2 = txt2.Text.Replace("'", "''");
            }
            MessageBox.Show("保存完成");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var up = from x in db.Newtext where x.Newid == 2 select x;
            foreach (var i in up)
            {
                i.Newtxt1 = txt3.Text.Replace("'", "''");
                i.Newtxt2 = txt4.Text.Replace("'", "''");
            }
            MessageBox.Show("保存完成");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var up = from x in db.Newtext where x.Newid == 3 select x;
            foreach (var i in up)
            {
                i.Newtxt1 = txttitle.Text.Replace("'", "''");
                i.Newtxt2 = txtsh.Text.Replace("'", "''");
                i.Newtxt3 = txtintroduction.Text.Replace("'", "''");
            }
            MessageBox.Show("保存完成");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var up = from x in db.Newtext where x.Newid == 4 select x;
            foreach (var i in up)
            {
                i.Newtxt1 = txt5.Text.Replace("'", "''");
                i.Newtxt2 = txt6.Text.Replace("'", "''");
            }
            MessageBox.Show("保存完成");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var up = from x in db.Newtext where x.Newid == 5 select x;
            foreach (var i in up)
            {
                i.Newtxt1 = txt7.Text.Replace("'", "''");
                i.Newtxt2 = txt8.Text.Replace("'", "''");
            }
            MessageBox.Show("保存完成");
        }
    }
}
