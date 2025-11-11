using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace The_Knowledge_Hub
{
    public partial class IssueReturn : UserControl
    {
        DateTime issueDate;
        DateTime dueDate;
        private int cost { get; set; }
        private int discount { get; set; }
        private string nameMem { get; set; }
        private string idBook { get; set; }
        public string Id { get; set; }

        private DataAccess Da { get; set; }
        private BillWindow Bw { get; set; }
        public IssueReturn()
        {
            InitializeComponent();
        }
        public IssueReturn(string id)
        {
            this.Id = id;
            InitializeComponent();
            this.Da = new DataAccess();
            string sql = "select * from  Books Where AvailableQuantity >0;";
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvBook.AutoGenerateColumns = false;
            this.dgvBook.DataSource = ds.Tables[0];

            BillGnerate();

        }




        private void clearData()
        {
            this.txtSearchMember.Text = String.Empty;
            this.txtSearchBook.Text = String.Empty;
            this.txtCost.Text = string.Empty;
            this.dtpDue.Text = string.Empty;
            this.dtpIssue.Text = string.Empty;
            this.txtSearchBook.Text = string.Empty;
            this.txtSearchMember.Text = string.Empty;
            Calculatecost();
        }
        private void Calculatecost()
        {
            try
            {
                issueDate = dtpIssue.Value;
                dueDate = dtpDue.Value;
                TimeSpan Due = (dueDate - issueDate);
                int Week = Due.Days / 7;


                if (issueDate.Date > dueDate.Date || issueDate.Month > dueDate.Month && issueDate.Year > dueDate.Year)
                {
                    MessageBox.Show("Return Date is Less than Issue Date", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.dtpDue.Value = issueDate;

                }

                if (Week > 0)
                {
                    cost = 50 + (Week * 50);
                    this.txtCost.Text = cost.ToString();
                    this.txtTotalCost.Text = (cost - discount).ToString();

                }
                else
                {
                    cost = 50;
                    this.txtCost.Text = cost.ToString();
                    this.txtTotalCost.Text = (cost - discount).ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Something Error has occured !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void BillGnerate()
        {
            var ds = Da.ExecuteQuery("select MAX(Bill) from Issued;");
            var newId = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            txtBill.Text = (++newId).ToString();
        }
        private void dtpIssue_ValueChanged(object sender, EventArgs e)
        {
            Calculatecost();
        }

        private void dtpDue_ValueChanged(object sender, EventArgs e)
        {
            Calculatecost();
        }


        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrWhiteSpace(txtDiscount.Text) || String.IsNullOrEmpty(txtDiscount.Text))
                {
                    discount = 0;
                    Calculatecost();

                    return;
                }

                discount = Convert.ToInt32(txtDiscount.Text);

                if (cost < discount)
                {
                    MessageBox.Show("Discount can't be more than cost ,,,");
                    this.txtDiscount.Text = "00";
                    return;
                }
                Calculatecost();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Enter Numeric Value", "Invalid !!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtDiscount.Text = string.Empty;

            }

        }

        private void btnClearB_Click(object sender, EventArgs e)
        {
            clearData();
            BillGnerate();

        }

        private void btnIssueB_Click(object sender, EventArgs e)
        {
            //try
            //{
            lblErrorBook.Visible = false;
            lblErrorMember.Visible = false;
            string sql = "Select * from Books Where Title = '" + txtSearchBook.Text + "'; Select * from Member Where Id ='" + txtSearchMember.Text + "';";
            var ds = Da.ExecuteQuery(sql);
            //var sq = Da.ExecuteQuery("Select * from UserInfo Where Id =101");/**/
            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[1].Rows.Count == 1)
            {
                string idM = this.txtSearchMember.Text.ToString();
                this.nameMem = ds.Tables[1].Rows[0][1].ToString();
                this.idBook = ds.Tables[0].Rows[0][0].ToString();
                string nameB = txtSearchBook.Text.ToString();
                string issue = dtpIssue.Text;
                string returnB = dtpDue.Text;
                string issuedBy = "10";/* sq.Tables[0].Rows[0][1].ToString();*/
                int cost = Convert.ToInt32(txtCost.Text);
                int discount = Convert.ToInt32(txtDiscount.Text);
                int total = Convert.ToInt32(txtTotalCost.Text);

                var insertsql = "insert into Issued Values ('" + idM + "','" + nameMem + "'," + idBook + ",'" + nameB + "','" + issue + "','" + returnB + "',null,'" + issuedBy + "'," + cost + "," + discount + ",0," + total + ",'Not Return';";
                var count = Da.ExecuteDMLQuery(insertsql);


                clearData();
                BillGnerate();

                //MessageBox.Show("\"" + nameB + "\" is issued to " + nameMem.ToUpper(), "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bw = new BillWindow(idM, nameMem, Convert.ToInt32(idBook), nameB, issue, returnB, issuedBy, cost, discount, total);
                Bw.Show();
                return;
            }
            if (ds.Tables[0].Rows.Count == 0)
            {
                lblErrorBook.Visible = true;
            }
            if (ds.Tables[1].Rows.Count != 1)
            {

                lblErrorMember.Visible = true;
            }

            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show("Enter Title and Member ID Properly");
            //}
        }





        private void txtDiscount_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtDiscount.Text == "00")
            {
                txtDiscount.Text = string.Empty;
            }
        }

        private void txtDiscount_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiscount.Text))
            {
                txtDiscount.Text = "00";
            }
        }

        private void IssueReturn_Load(object sender, EventArgs e)
        {
            this.dgvBook.ClearSelection();

        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = "update Issued set [Member ID]='" + this.txtSearchMember.Text + "',[Book Name] ='" + txtSearchBook.Text + "',[Issue Date]='" + dtpIssue.Text + "',[Due Date]='" + dtpDue.Text + "',Cost ='" + txtCost.Text + "',Discount='" + txtDiscount.Text + "',[Total Cost]='" + txtTotalCost.Text + "' Where Bill ='" + txtBill.Text + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Bill No." + txtBill.Text + " has been updated");
                else
                    MessageBox.Show("Bill No." + txtBill.Text + " hasn't been updated");
                clearData();
                BillGnerate();

                ShowIssue us = new ShowIssue();
                NavigationMenu nv = (NavigationMenu)this.ParentForm;
                nv.PanelControl(us);
            }
            catch
            {
                MessageBox.Show("Not Updated ,Try Again", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            var sql = "Select * from Books where Title like '" + txtSearchBook.Text + "%'";
            dgvBook.DataSource = Da.ExecuteQueryTable(sql);

        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSearchBook.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
        }

        public void FillContent(string billiD, string idM, string nameM, string idB, string title, string issue, string due, string issuedBy, string cost, string discount, string totalcost)
        {
            txtBill.Text = billiD;
            txtSearchMember.Text = idM;
            this.nameMem = nameM;
            this.idBook = idB;
            txtSearchBook.Text = title;
            dtpIssue.Text = issue;
            dtpDue.Text = due;
            txtIssuedBy.Text = issuedBy;
            txtCost.Text = cost;
            txtDiscount.Text = discount;
            txtTotalCost.Text = totalcost;
            btnIssueB.Visible = false;
            btnUpdate.Visible = true;
        }
    }
}