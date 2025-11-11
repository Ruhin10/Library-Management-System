using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Knowledge_Hub
{
    public partial class Members : UserControl
    {

        private DataAccess Da { get; set; }
        private Update_Member um { get; set; }
        public Members()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "Select * from Member;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvSearchMember .AutoGenerateColumns = false;
            this.dgvSearchMember.DataSource = ds.Tables[0];
        }

        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbSearchMember.Text))
                {
                    MessageBox.Show("Please Select an option");

                }
                else if (this.cmbSearchMember.Text == "Member Id")
                {
                    string sql = "Select * from Member where Id Like '" + txtSearchMember.Text + "%'";
                    dgvSearchMember.DataSource = Da.ExecuteQueryTable(sql);
                }



                else if (this.cmbSearchMember.Text == "Member Name")
                {
                    string sql = "Select * from Member where Name Like '" + txtSearchMember.Text + "%'";
                    dgvSearchMember.DataSource = Da.ExecuteQueryTable(sql);

                }
            }
            catch 
            {
                MessageBox.Show("Error");

            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvSearchMember.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var id = this.dgvSearchMember.CurrentRow.Cells[0].Value.ToString();
                var  name = this.dgvSearchMember.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + name + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from Member where Id = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list");

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show(" An error has occure: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Members_Load(object sender, EventArgs e)
        {
            dgvSearchMember.ClearSelection();
        }

        private void dgvSearchMember_DoubleClick(object sender, EventArgs e)
        {
            this.um = new Update_Member();
            um.FillContent(dgvSearchMember.CurrentRow.Cells[0].Value.ToString(), dgvSearchMember.CurrentRow.Cells[1].Value.ToString(), dgvSearchMember.CurrentRow.Cells[2].Value.ToString(), dgvSearchMember.CurrentRow.Cells[3].Value.ToString(), dgvSearchMember.CurrentRow.Cells[4].Value.ToString(), dgvSearchMember.CurrentRow.Cells[5].Value.ToString(), dgvSearchMember.CurrentRow.Cells[6].Value.ToString(), dgvSearchMember.CurrentRow.Cells[7].Value.ToString(), dgvSearchMember.CurrentRow.Cells[8].Value.ToString(), dgvSearchMember.CurrentRow.Cells[10].Value.ToString());
            NavigationMenu nv = (NavigationMenu)this.ParentForm;
            nv.PanelControl(um);
        }
    }
}
