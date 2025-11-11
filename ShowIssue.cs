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
    public partial class ShowIssue : UserControl
    {
        private DataAccess Da {  get; set; }
        private IssueReturn IR { get; set; }
        public ShowIssue()
        {
            InitializeComponent();
            this.Da= new DataAccess();
            PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from  Issued;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvIssue.AutoGenerateColumns = false;
            this.dgvIssue.DataSource = ds.Tables[0];
        }

        private void txtBill_TextChanged(object sender, EventArgs e)
        {
            var sql = "Select * from Issued Where Bill like '"+txtBill.Text+"%'";
            dgvIssue.DataSource = this.Da.ExecuteQueryTable(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvIssue.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var billid = this.dgvIssue.CurrentRow.Cells[0].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from Issued where Bill = '" + billid + "';Update Books set AvailableQuantity+=1 Where Id =" + dgvIssue.CurrentRow.Cells[3].Value.ToString() + ";";
                var count = this.Da.ExecuteDMLQuery(sql);

                MessageBox.Show("Bill ID (" + billid + ") has been removed from the list");

                PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error happens");
            }
        }

        private void ShowIssue_Load(object sender, EventArgs e)
        {
            dgvIssue.ClearSelection();
        }

        private void dgvIssue_DoubleClick(object sender, EventArgs e)
        {
            this.IR = new IssueReturn();
            IR.FillContent(dgvIssue.CurrentRow.Cells[0].Value.ToString(), dgvIssue.CurrentRow.Cells[1].Value.ToString(), dgvIssue.CurrentRow.Cells[2].Value.ToString(), dgvIssue.CurrentRow.Cells[3].Value.ToString(), dgvIssue.CurrentRow.Cells[4].Value.ToString(), dgvIssue.CurrentRow.Cells[5].Value.ToString(), dgvIssue.CurrentRow.Cells[6].Value.ToString(), dgvIssue.CurrentRow.Cells[8].Value.ToString(), dgvIssue.CurrentRow.Cells[9].Value.ToString(), dgvIssue.CurrentRow.Cells[10].Value.ToString(), dgvIssue.CurrentRow.Cells[10].Value.ToString());
            NavigationMenu nv = (NavigationMenu)this.ParentForm;
            nv.PanelControl(IR);
        }
    }
    }

