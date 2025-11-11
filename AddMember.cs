using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Knowledge_Hub
{
    public partial class AddMember : UserControl
    {
        private DataAccess Da { get; set; }

        public AddMember()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            IdGnerate();
        }

        public bool IsValid() 
        {
            if

             (string.IsNullOrEmpty(this.txtName.Text) || string.IsNullOrEmpty(this.txtPhnNumber.Text) || string.IsNullOrEmpty(this.dtpDOB.Text) || string.IsNullOrEmpty(this.rbMale.Text) || string.IsNullOrEmpty(this.rbFemale.Text) || string.IsNullOrEmpty(this.txtHouse.Text) || string.IsNullOrEmpty(this.txtRoad.Text) || string.IsNullOrEmpty(this.txtCity.Text) || string.IsNullOrEmpty(this.txtDistrict.Text) || string.IsNullOrEmpty(this.dtpMembershipDate.Text))
            { 
                return false;
            }

            else 
                { return true; }
        }

        private void btnMemberSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string gender;
                if (!this.IsValid())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }
                if (rbFemale.Checked)
                {
                   gender = rbFemale.Text; 
                }
                else
                {
                    gender = rbMale.Text;
                }
                    var sql = "insert into Member values('" + this.txtName.Text + "','" + this.dtpDOB.Text + "','"+gender+"','"+this.txtPhnNumber.Text+"','" + this.txtHouse.Text + "','" + this.txtRoad.Text + "','" + this.txtCity.Text + "','" + this.txtDistrict.Text + "','" +this.txtHouse.Text + " " +this.txtRoad.Text + " " + this.txtCity.Text + " " + this.txtDistrict.Text + "','" + this.dtpMembershipDate.Text + "',0);";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(txtName.Text+" has been added");
                Clear();
            }

            catch(Exception exc)
            {
                MessageBox.Show(" Please enter all field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Clear()
        {
            txtName.Text = string.Empty;
            txtHouse.Text = string.Empty;
            txtRoad.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtDistrict.Text = string.Empty;
            txtPhnNumber.Text = string.Empty;
            dtpDOB.Text = string.Empty;
            dtpMembershipDate.Text = string.Empty;
            rbFemale.Checked = false;
            rbMale.Checked = false;
        }
        private void IdGnerate()
        {
            var ds = Da.ExecuteQuery("select Max(Id) from Member");
            var newId = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            txtMemberId.Text = (++newId).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
