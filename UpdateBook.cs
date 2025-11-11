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
    public partial class UpdateBook : UserControl
    {
        private DataAccess Da {  get; set; }
        public UpdateBook()
        {
            InitializeComponent();
            Da =new  DataAccess();
        }
        public  void FillContent(string bookId, string title, string author, string publisher, string publicationYear, string isbn, string language, string category, string shelfLocation, string availableQuantity)
        {
            txtBookId.Text = bookId;
            txtTitle.Text = title;
            txtAuthor.Text = author;
            txtPublisher.Text = publisher;
            txtPublicationYear.Text = publicationYear;
            txtISBN.Text = isbn;
            txtLanguage.Text = language;
            txtCategory.Text = category;
            txtShelfLocation.Text = shelfLocation;
            txtAvailableQuantity.Text = availableQuantity;
        }
        private void Clear()
        {
            txtBookId.Text=string.Empty;
            txtTitle.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtPublisher.Text = string.Empty;
            txtPublicationYear.Text = string.Empty;
            txtISBN.Text = string.Empty;
            txtLanguage.Text = string.Empty;
            txtCategory.Text = string.Empty;
            txtShelfLocation.Text = string.Empty;
            txtAvailableQuantity.Text = string.Empty;
        }
           

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAddB_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = "Select * from Books Where Id ='" + txtBookId.Text + "'";
                var ds = Da.ExecuteQueryTable(sql);
                if (ds.Rows.Count != 1)
                {
                    lblErrorId.Visible = true;
                    return;
                }

                var sql1 = " update Books Set Title = '" + txtTitle.Text + "',Author='" + txtAuthor.Text + "',Publisher='" + txtPublisher.Text + "',PublicationYear=" + txtPublicationYear.Text + ",ISBN='" + txtISBN.Text + "',Language='" + txtLanguage.Text + "',Category='" + txtCategory.Text + "',ShelfLocation='" + txtShelfLocation.Text + "',AvailableQuantity=" + txtAvailableQuantity.Text + "where Id=" + txtBookId.Text + ";";
                var count = this.Da.ExecuteDMLQuery(sql1);

                if (count == 1)
                    MessageBox.Show("Book ID :\"" + txtBookId.Text + "\" has been Updated");
                else
                    MessageBox.Show("Book ID :\"" + txtBookId.Text + "\" has been Updated");

                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }

        }
    }
}
