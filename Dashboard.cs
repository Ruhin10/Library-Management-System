using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Knowledge_Hub
{
    public partial class Dashboard : UserControl
    {
        private DataAccess Da { get; set; }
        public Dashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            ShowCount();

        }
        private void ShowCount()
        {
            try
            {
                var ds = Da.ExecuteQueryTable("Select * from Books");
                var ds1 = Da.ExecuteQueryTable("Select * from Issued;");
                var ds2 = Da.ExecuteQueryTable("select sum([Total Cost] ) from Issued");
                var ds3 = Da.ExecuteQueryTable("Select * from Issued Where [Return Status]= 'Not Return';");
                var ds4 = Da.ExecuteQueryTable("select * from Issued where Cast([Issue Date] AS date)= Cast(GETDATE() AS date);");
                var ds5 = Da.ExecuteQueryTable("Select * from Member");
                lblTotalBookCount.Text = ds.Rows.Count.ToString();
                lblTotalISsuedCount.Text = ds1.Rows.Count.ToString();
                lblHaventReturnCount.Text = ds3.Rows.Count.ToString();
                lblTotalIncome.Text = ds2.Rows[0][0].ToString();
                lblTodayIssued.Text = ds4.Rows.Count.ToString();
                lblTotalMemberCount.Text = ds5.Rows.Count.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
