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
    public partial class Users : UserControl
    {
        private DataAccess Da { get; set; }
        private UpdateUser uu { get; set; }
        public Users()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
        }
        private void PopulateGridView(String sql = "Select* From UserInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvSearchUser.AutoGenerateColumns = false;
            this.dgvSearchUser.DataSource = ds.Tables[0];
        }

        private void dgvSearchUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbSearchUser.Text))
                {
                    MessageBox.Show("Please Select an option");

                }
                else if (this.cmbSearchUser.Text == "User Id")
                {
                    string sql = "Select * from UserInfo where Id Like '" + txtSearchUser.Text + "%'";
                    dgvSearchUser.DataSource = Da.ExecuteQueryTable(sql);
                }



                else if (this.cmbSearchUser.Text == "User Name")
                {
                    string sql = "Select * from UserInfo where Name Like '" + txtSearchUser.Text + "%'";
                    dgvSearchUser.DataSource = Da.ExecuteQueryTable(sql);

                }
            }
            catch 
            {
                MessageBox.Show("Error");
            }
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvSearchUser.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var id = this.dgvSearchUser.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvSearchUser.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + name + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from UserInfo where Id = '" + id + "';";
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

        private void Users_Load(object sender, EventArgs e)
        {
            dgvSearchUser.ClearSelection();
        }

        private void dgvSearchUser_DoubleClick(object sender, EventArgs e)
        {
            this.uu = new UpdateUser();
            uu.FillContent(dgvSearchUser.CurrentRow.Cells[0].Value.ToString(), dgvSearchUser.CurrentRow.Cells[1].Value.ToString(), dgvSearchUser.CurrentRow.Cells[2].Value.ToString(), dgvSearchUser.CurrentRow.Cells[3].Value.ToString(), dgvSearchUser.CurrentRow.Cells[4].Value.ToString(), dgvSearchUser.CurrentRow.Cells[5].Value.ToString(), dgvSearchUser.CurrentRow.Cells[6].Value.ToString(), dgvSearchUser.CurrentRow.Cells[7].Value.ToString(), dgvSearchUser.CurrentRow.Cells[8].Value.ToString(), dgvSearchUser.CurrentRow.Cells[9].Value.ToString(), dgvSearchUser.CurrentRow.Cells[11].Value.ToString(), dgvSearchUser.CurrentRow.Cells[12].Value.ToString());
            NavigationMenu nv = (NavigationMenu)this.ParentForm;
            nv.PanelControl(uu);
        }
    }
}
