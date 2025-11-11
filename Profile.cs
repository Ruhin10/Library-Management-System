using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Knowledge_Hub;

namespace The_Knowledge_hub
{
    public partial class Profile : UserControl
    {
        public DataAccess Da { get; set; }
        private string Id { get; set; }

        public Profile(string id)
        {
            Id = id;
            InitializeComponent();
            this.Da = new DataAccess();
            showDetails();
        }


        private void showDetails()
        {
            try
            {
                var ds = Da.ExecuteQuery("Select * from UserInfo Where ID ='" + Id + "'");


                lblUserID.Text += "  :  " + ds.Tables[0].Rows[0][0].ToString();
                lblName.Text += "  :  " + ds.Tables[0].Rows[0][1].ToString(); ;
                txtPassword.Text = "********";
                lblRole.Text += "  :  " + ds.Tables[0].Rows[0][3].ToString();
                lblDOB.Text += "  :  " + ds.Tables[0].Rows[0][4].ToString();
                lblPhnNumber.Text += "  :  " + ds.Tables[0].Rows[0][5].ToString();
                lblGender.Text += "  :  " + ds.Tables[0].Rows[0][6].ToString();
                lblAdderss.Text += "  :  " + ds.Tables[0].Rows[0][11].ToString();
                lblJoiningDate.Text += "  :  " + ds.Tables[0].Rows[0][12].ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

            pnlChangePassword.Visible = true;
            pnlProfile.Visible = false;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewPass.Text == txtConfirmPass.Text && !string.IsNullOrWhiteSpace(txtConfirmPass.Text) && !string.IsNullOrWhiteSpace(txtConfirmPass.Text))
                {
                    var count = Da.ExecuteDMLQuery("Update UserInfo Set Password ='" + txtConfirmPass.Text + "' Where ID ='" + Id + "'");
                    if (count > 0)
                    {

                        pnlProfile.Visible = true;
                        pnlChangePassword.Visible = false;
                        MessageBox.Show("Password has been updated", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Both password should be same", "Not Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Show();
            }
            catch
            {
                MessageBox.Show("Something happens");
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = true;
            pnlChangePassword.Visible = false;
        }

        bool show = false;
        private void btnShow_Click(object sender, EventArgs e)
        {
            var ds = Da.ExecuteQuery("Select * from UserInfo Where ID ='" + Id + "'");

            if (!show)
            {
                show = true;
                txtPassword.Text =  ds.Tables[0].Rows[0][2].ToString();

            }
            else
            {
                show = false;
                txtPassword.Text = "********";

            }
        }

     
    }
}
