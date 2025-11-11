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
    public partial class AddBook : UserControl
    {
        private DataAccess Da { get; set; }

        public AddBook()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            IdGnerate();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            Clear();

        }
        private void IdGnerate()
        {
            var ds = Da.ExecuteQuery("select MAX(Id) from Books");
            int  newId = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            txtBookId.Text = (++newId).ToString();
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(this.txtTitle.Text) || string.IsNullOrEmpty(this.txtAuthor.Text) || string.IsNullOrEmpty(this.txtPublisher.Text) || string.IsNullOrEmpty(this.txtPublicationYear.Text) || string.IsNullOrEmpty(this.txtISBN.Text) || string.IsNullOrEmpty(this.txtLanguage.Text) || string.IsNullOrEmpty(this.txtCategory.Text) || string.IsNullOrEmpty(this.txtShelfLocation.Text) || string.IsNullOrEmpty(this.txtAvailableQuantity.Text))
            { return false; }
            else
            {
                return true;
            }
        }

        private void btnAddB_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValid())
                {
                    MessageBox.Show("All Text Feild aren't filled.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                var sql = "insert into Books Values('" + this.txtTitle.Text + "', '" + this.txtAuthor.Text + "',' " + this.txtPublisher.Text + "', " +Convert.ToInt32( this.txtPublicationYear.Text) + ", '" + this.txtISBN.Text + "', '" + this.txtLanguage.Text + "', '" + this.txtCategory.Text + "','" + txtShelfLocation.Text + "'," + Convert.ToInt32(txtAvailableQuantity.Text )+ ")";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(txtTitle.Text+" has been added");
                else
                    MessageBox.Show(txtTitle.Text+ " hasn't been added");

                Clear();
                IdGnerate();
            }


            catch (Exception exc)
            {
                MessageBox.Show("Please Enter all feild properly", "Something error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Clear()
        {
            txtTitle.Text=string.Empty;
            txtAuthor.Text=string.Empty;
            txtPublisher.Text=string.Empty;
            txtPublicationYear.Text=string.Empty;  
            txtISBN.Text=string.Empty;
            txtLanguage.Text=string.Empty;
            txtCategory.Text=string.Empty;
            txtShelfLocation.Text=string.Empty ;
            txtAvailableQuantity.Text=string.Empty;
        }
    }
}


