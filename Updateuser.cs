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
    
    public partial class UpdateUser : UserControl
    {
        private DataAccess Da { get; set; }
        public UpdateUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
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

                var sql = "Update UserInfo Set Name = '" + txtName.Text + "',Password ='"+txtPassword.Text+"',Role = '"+txtRole.Text+ "',PhoneNumber = '" + txtPhnNumber.Text + "',DOB = '" + dtpDOB.Text + "',Gender = '" + Gender + "',House = '" + txtHouse.Text + "',Road = '" + txtRoad.Text + "',City = '" + txtCity.Text + "',District = '" + txtDistrict.Text + "',Address = '" + this.txtHouse.Text + " " + this.txtRoad.Text + " " + this.txtCity.Text + " " + this.txtDistrict.Text + "',JoinningDate = '" + dtpJoinningDate.Text + "'Where Id = '"+txtUserId.Text+"'";
                var Count = this.Da.ExecuteDMLQuery(sql);
                if (Count == 1)
                    MessageBox.Show("UserInfo Id :\"" + txtUserId.Text + "\" has been updated");
                else
                    MessageBox.Show("UserInfo Id :\"" + txtUserId.Text + "\" hasn't been updated");
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
            txtPassword.Text = string.Empty;
            txtRole.Text = string.Empty;
            txtPhnNumber.Text = string.Empty;
            dtpDOB.Text = string.Empty;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtHouse.Text = string.Empty;
            txtRoad.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtDistrict.Text = string.Empty;
            dtpJoinningDate.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void FillContent(string UserId, string Name, string Password, string DateofBirth, string Gender, string PhoneNumber, string House, string Road, string City, string District, string JoiningDate, string Role)
        {
            txtUserId.Text = UserId;
            txtName.Text = Name;
            txtPassword.Text = Password;
            txtRole.Text = Role;
            txtPhnNumber.Text = PhoneNumber;
            dtpDOB.Text = DateofBirth;
            txtHouse.Text = House;
            txtRoad.Text = Road;
            txtCity.Text = City;
            txtDistrict.Text = District;
            dtpJoinningDate.Text = JoiningDate ;
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
