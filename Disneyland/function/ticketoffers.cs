using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disneyland.function
{
    public partial class ticketoffers : UserControl
    {
        public ticketoffers()
        {
            InitializeComponent();
        }
        methon.sqolconDataContext db = new methon.sqolconDataContext();
        private void res()
        {
            cb.DataSource = db.TicketOffers;
            cb.DisplayMember = "TicketName";
        }
        private void ticketoffers_Load(object sender, EventArgs e)
        {
            res();
        }
        int id;
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = db.TicketOffers.FirstOrDefault(x => x.TicketName == cb.SelectedItem.ToString());
            id = sel.TicketOffersID;
            txttn.Text = sel.TicketName;
            txtdis.Text = sel.Discount.ToString();
            txttp.Text = sel.TicketPrice.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sel = db.TicketOffers.FirstOrDefault(x => x.TicketName == cb.SelectedItem.ToString());
            if(sel != null)
            {
                MessageBox.Show("項目已存在");
                return;
            }
            
        }
    }
}
