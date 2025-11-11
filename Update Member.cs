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
    public partial class Update_Member : UserControl
    {
        private DataAccess Da { get; set; }
        public Update_Member()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnMemberUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string Gender;

                if (rbFemale.Checked)
                {
                    Gender = rbFemale.Text;
                }
                else
                {
                    Gender = rbMale.Text;
                }

                var sql = "Update Member Set Name = '" + txtName.Text + "',[Date of Birth] = '" + dtpDOB.Text + "',Gender = '" + Gender + "',[Phone Number] = '" + txtPhnNumber.Text + "',House = '" + txtHouse.Text + "',Road = '" + txtRoad.Text + "',City = '" + txtCity.Text + "',District = '" + txtDistrict.Text + "',Address = '" + this.txtHouse.Text + " " + this.txtRoad.Text + " " + this.txtCity.Text + " " + this.txtDistrict.Text + "',[Membership Date] = '" + dtpMembershipDate.Text + "'Where Id = '"+txtMemberId.Text+"'";
                    var Count = this.Da.ExecuteDMLQuery(sql);
                if (Count == 1)
                    MessageBox.Show("Member Id :\"" + txtMemberId.Text + "\" has been updated");
                else
                    MessageBox.Show("Member Id :\"" + txtMemberId.Text + "\" hasn't been updated");
                Clear();
            }
            catch 
            {
                MessageBox.Show("Error");
            }
                    
        }
        private void Clear()
        {
            txtName.Text = string.Empty;
            txtPhnNumber.Text = string.Empty;
            dtpDOB.Text = string.Empty;
            rbFemale.Checked = false;
            rbMale.Checked = false;
            txtHouse.Text = string.Empty;
            txtRoad.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtDistrict.Text = string.Empty;
            dtpMembershipDate.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void FillContent(string MemberId, string Name, string DateofBirth, string Gender, string PhoneNumber, string House, string Road, string City, string District, string MembershipDate)
        {
            txtMemberId.Text = MemberId;
            txtName.Text = Name;
            txtPhnNumber.Text = PhoneNumber;
            dtpDOB.Text = DateofBirth;
            dtpMembershipDate.Text = MembershipDate;
            txtHouse.Text = House;
            txtRoad.Text = Road;
            txtCity.Text = City;
            txtDistrict.Text = District;
            if(Gender == "Male")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
        }
    }
}
