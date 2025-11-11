using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Knowledge_Hub
{
    public partial class Return : UserControl
    {
        private DataAccess Da { get; set; }

        public Return()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            

        }
        private void CalculatePenalty()
        {
            var sql = "Select * from Issued Where Bill ='" + txtBill.Text + "'";
            var ds = Da.ExecuteQueryTable(sql);

            DateTime dueDate = Convert.ToDateTime(ds.Rows[0][6]);
            DateTime returnDate = dtpReturn.Value;

            int dayLate = (returnDate - dueDate).Days;
            int penalty = 0;
            int penaltyPerDay = 10;

            if (dayLate > 0)
            {
                penalty = dayLate * penaltyPerDay;
                txtPenalty.Text = penalty.ToString();
                return;
            }
            if (dayLate <= 0)
            {
                txtPenalty.Text = "00";
            }
        }
        private void PopulateGridView(string sql = "Select * from Issued")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvIssue.AutoGenerateColumns = false;
            this.dgvIssue.DataSource = ds.Tables[0];
        }

        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select * from Issued Where Bill Like '" + txtBill.Text + "%';";
                dgvIssue.DataSource = Da.ExecuteQueryTable(sql);

                if (dgvIssue.Rows.Count == 0)
                {
                    lblError.Visible = true; return;
                }

                dgvIssue.ClearSelection();
                lblError.Visible = false;
                CalculatePenalty();
            }
            catch
            {
                MessageBox.Show("Enter Bill No. Properly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnClearB_Click(sender, e);
            }

        }

        private void btnClearB_Click(object sender, EventArgs e)
        {
            this.txtBill.Text = String.Empty;
            lblError.Visible = false;

        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (dgvIssue.CurrentRow.Cells[11].Value.ToString() == "Not Return")
                {
                    DialogResult res = MessageBox.Show("Are you sure ?", "Returned", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.No)
                        return;
                    var sql = "update Issued set [Return Status]= 'Return', [Return Date] = '"+dtpReturn.Text+ "',Penalty='"+txtPenalty.Text+ "',[Total Cost]=[Total Cost]+"+txtPenalty.Text+" Where Bill=" + dgvIssue.CurrentRow.Cells[0].Value.ToString() + "; Update Books set AvailableQuantity+=1 Where ID =" + dgvIssue.CurrentRow.Cells[3].Value.ToString() + ";";
                    var count = Da.ExecuteDMLQuery(sql);

                    MessageBox.Show("Updated", "Updated"); PopulateGridView();
                    btnClearB.PerformClick();

                    return;
                }
                if (dgvIssue.CurrentRow.Cells[11].Value.ToString() == "Return")
                {
                    DialogResult res = MessageBox.Show("Are you sure ?", "Not Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.No)
                        return;
                    var sql = "update Issued set [Return Status]= 'Not Return',[Return Date] = 'NULL',Penalty='0' ,[Total Cost]=[Total Cost]+"+txtPenalty.Text+" Where Bill=" + dgvIssue.CurrentRow.Cells[0].Value.ToString() + "; Update Books set AvailableQuantity-= 1 Where ID = " + dgvIssue.CurrentRow.Cells[3].Value.ToString() + "; ";
                    var count = Da.ExecuteDMLQuery(sql);


                    MessageBox.Show("Updated", "Updated"); PopulateGridView();
                    
                    btnClearB.PerformClick();   

                    return;
                }
            }
            catch
            {
                MessageBox.Show("Enter Bill No. Properly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvIssue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIssue.CurrentRow.Cells[11].Value.ToString() == "Not Return") { btnReturn.Text = "      Return"; return; }
            if (dgvIssue.CurrentRow.Cells[11].Value.ToString() == "Return") { btnReturn.Text = "             Undo Return"; return; }
        }

        private void Return_Load(object sender, EventArgs e)
        {
            dgvIssue.ClearSelection();
        }

        private void dtpReturn_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                CalculatePenalty();
            }
            
            catch
            {
                MessageBox.Show("Enter valid BIll NO.","Invalid Bill NO.",MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void txtPenalty_MouseClick(object sender, MouseEventArgs e)
        {
            txtPenalty.Text = string.Empty;
        }
    }
}
