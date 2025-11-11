using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Knowledge_Hub
{
    public partial class BillWindow : Form
    {
        public BillWindow()
        {
            InitializeComponent();
        }
        public BillWindow(string idM, string nameM, int idB, string nameB, string issueD, string returnD, string issuedBy, int cost, int discount, int totalCost) : this()
        {
            this.lblmId.Text += "" + idM;
            this.lblnameM.Text += "" + nameM;
            this.lblIdB.Text += "" + idB;
            this.lblnameB.Text += "" + nameB;
            this.lblIssue.Text += "" + issueD;
            this.lblReturn.Text += "" + returnD;
            this.lblIssuedBy.Text += "" + issuedBy;
            this.lblCost.Text += "" + cost;
            this.lblDiscount.Text += "" + discount;
            this.lblTotalCost.Text += "" + totalCost;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
