using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Knowledge_Hub
{
    public partial class Books : UserControl
    {
        bool SearchPanelExpand = false;
        private DataAccess Da { get; set; }
        private UpdateBook Ub {  get; set; }
       
        public Books()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();

        }
        public void Clear()
        {
            this.txtSearchText.Text=string.Empty;
        }
        private void PopulateGridView(string sql = "select * from  Books;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvBook.AutoGenerateColumns = false;
            this.dgvBook.DataSource = ds.Tables[0];
        }

        private void timerHideBook_Tick(object sender, EventArgs e)
        {
            if (!SearchPanelExpand)
            {


                pnlUpper.Height += 5;
                if (pnlUpper.Height >= 180)
                {
                    this.btnSearch.Text = "           Hide Search";
                    timerHideBook.Stop();
                    SearchPanelExpand = true;

                }
            }
            else
            {
                pnlUpper.Height -= 5;
                if (pnlUpper.Height <= 50)
                {
                    this.btnSearch.Text = "\t \t  Search";
                    timerHideBook.Stop();
                    SearchPanelExpand = false;

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            timerHideBook.Start();

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbSearchBy.Text == "")
                {
                    MessageBox.Show("Select any Search By option.....");
                }
                else if (this.cmbSearchBy.Text == "Title")
                {
                    string sql = "Select * from Books Where Title like '" + txtSearchText.Text + "%' ";
                    this.dgvBook.DataSource = Da.ExecuteQueryTable(sql);
                }
                if (this.cmbSearchBy.Text == "Book ID")
                {
                    string sql = "Select * from Books Where ID like '" + txtSearchText.Text + "%';";
                    this.dgvBook.DataSource = Da.ExecuteQueryTable(sql);
                }
                else if (this.cmbSearchBy.Text == "Author")
                {
                    string sql = "Select * from Books Where Author like '" + txtSearchText.Text + "%'";
                    this.dgvBook.DataSource = Da.ExecuteQueryTable(sql);
                }
                else if (this.cmbSearchBy.Text == "Publisher")
                {
                    string sql = "Select * from Books Where Publisher like '" + txtSearchText.Text + "%'";
                    this.dgvBook.DataSource = Da.ExecuteQueryTable(sql);
                }
                else if (this.cmbSearchBy.Text == "ISBN")
                {
                    string sql = "Select * from Books Where ISBN like '" + txtSearchText.Text + "%'";
                    this.dgvBook.DataSource = Da.ExecuteQueryTable(sql);
                }
            }
            catch
            {
                MessageBox.Show("Something error happesns");
            }

        }

        private void btnDeleteB_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvBook.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var id = this.dgvBook.CurrentRow.Cells[0].Value.ToString();
                var title = this.dgvBook.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove \"" + title + "\"?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from Books where Id = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(title.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("Data hasn't been deleted");

                this.PopulateGridView();
                this.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void Books_Load(object sender, EventArgs e)
        {
            dgvBook.ClearSelection();
        }

        private void dgvBook_DoubleClick(object sender, EventArgs e)
        {
            this.Ub =new UpdateBook();
            Ub.FillContent(dgvBook.CurrentRow.Cells[0].Value.ToString(), dgvBook.CurrentRow.Cells[1].Value.ToString(), dgvBook.CurrentRow.Cells[2].Value.ToString(), dgvBook.CurrentRow.Cells[3].Value.ToString(), dgvBook.CurrentRow.Cells[4].Value.ToString(), dgvBook.CurrentRow.Cells[5].Value.ToString(), dgvBook.CurrentRow.Cells[6].Value.ToString(), dgvBook.CurrentRow.Cells[7].Value.ToString(), dgvBook.CurrentRow.Cells[8].Value.ToString(), dgvBook.CurrentRow.Cells[9].Value.ToString());
            NavigationMenu nv = (NavigationMenu)this.ParentForm;
            nv.PanelControl(Ub);
            
        }
    }
}
