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
    public partial class ThemePark : UserControl
    {
        public ThemePark()
        {
            InitializeComponent();
        }
        methon.sqolconDataContext db = new methon.sqolconDataContext();
        int accountid;
        private void res()
        {
            var th = from a in db.ThemePark.AsEnumerable() select a;
            dgv.DataSource = th.ToList();
            dgv.Columns[0].Visible = false;
            dgv.Columns[3].Visible = false;
        }
        private void ThemePark_Load(object sender, EventArgs e)
        {
            res();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            btnchange.Enabled = btndel.Enabled = true;
            accountid = int.Parse(dgv.CurrentRow.Cells[0].Value.ToString());
            txttpn.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            txtido.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            object pic= dgv.CurrentRow.Cells[3].Value;
            if (pic == null|| pic == "")
                picbox.Image = default;
            else
                picbox.Image = Image.FromFile(pic.ToString());
        }
        string picstr;
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "匯入圖片";
            ofd.DefaultExt = "jpg(*.jpg)|*.jpg";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Guid guid = Guid.NewGuid();
                string file = @".\image\" + guid + ".jpg";
                picstr = Path.GetFullPath(ofd.FileName);
                File.Copy(picstr, file);
                picbox.Image = Image.FromFile(file);
                if (accountid != 0)
                {
                    var up = from a in db.ThemePark where a.ThemeParkID == accountid select a;
                    foreach (var i in up)
                        i.NewPic = file;
                    db.SubmitChanges();
                }
                else
                    picstr = file;
                MessageBox.Show("匯入完成");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (accountid != 0)
            {
                var del = from a in db.ThemePark where a.ThemeParkID == accountid select a;
                foreach (var i in del)
                    i.NewPic = null;
                db.SubmitChanges();
            }
            else
                picstr = "";
            MessageBox.Show("刪除完成");
            picbox.Image = default;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var add = db.ThemePark.FirstOrDefault(a => a.ThemeParkName == txttpn.Text.Replace("'", "''"));
            if(add!= null)
            {
                MessageBox.Show("項目已存在");
                return;
            }
            var ins = new methon.ThemePark
            {
                ThemeParkName = txttpn.Text.Replace("'", "''"),
                Introduction = txtido.Text.Replace("'","''")
            };
            db.ThemePark.InsertOnSubmit(ins);
            db.SubmitChanges();
            MessageBox.Show("新增完成");
            btnchange.Enabled = btndel.Enabled = true;
            var ex = db.ThemePark.FirstOrDefault(x => x.ThemeParkName == txttpn.Text.Replace("'","''"));
            accountid = Convert.ToInt32(ex.ThemeParkID);
            res();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var del = from a in db.ThemePark where a.ThemeParkID == accountid select a;
            foreach (var i in del)
                db.ThemePark.DeleteOnSubmit(i);
            db.SubmitChanges();
            MessageBox.Show("刪除完成");
            accountid = 0;
            btndel.Enabled = btnchange.Enabled = false;
            btnadd.Enabled = true;
            res();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            var up = from a in db.ThemePark where a.ThemeParkID == accountid select a;
            foreach(var i in up)
            {
                i.ThemeParkName = txttpn.Text.Replace("'", "''");
                i.Introduction = txtido.Text.Replace("'", "''");
                i.NewPic = picstr;
            }
            db.SubmitChanges();
            res();
            MessageBox.Show("更改完成");
        }
    }
}
