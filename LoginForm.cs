using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Knowledge_Hub
{
    public partial class LoginForm : Form
    {
        private DataAccess Da { get; set; }
        private NavigationMenu Nv {  get; set; }

        public LoginForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();


        }

        private void btalogin_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = "Select * from UserInfo Where Id ='" + txtuserid.Text + "' AND  Password ='" + txtpassword.Text + "'";
                var ds = Da.ExecuteQuery(sql);
                var id = ds.Tables[0].Rows[0][0].ToString();
                var role = ds.Tables[0].Rows[0][3].ToString();
                if (ds.Tables[0].Rows.Count == 1)
                {
                    if (role == "Admin")
                    {
                        
                        this.Nv = new NavigationMenu(id, role);
                        Nv.Visible = true;
                        this.Hide();
                    }
                    else if (role == "Librarian")
                    {
                      
                        this.Nv = new NavigationMenu(id, role);
                        Nv.Visible = true;
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("User Id or Password not match");
                }

            }

            catch (Exception exc)
            {
                MessageBox.Show("User Id or Password not match");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
