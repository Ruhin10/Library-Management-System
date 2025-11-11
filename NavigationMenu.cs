using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Knowledge_hub;

namespace The_Knowledge_Hub
{

    public partial class NavigationMenu : Form
    {
        private Books Bk { get; set; }
        private AddBook AB { get; set; }
        private IssueReturn IR { get; set; }
        private UpdateBook Ub { get; set; }
        private Return Rn { get; set; }
        private Dashboard Dp { get; set; }
        private ShowIssue SI { get; set; }
        private Users us { get; set; }
        private AddUser Au { get; set; }
        private UpdateUser Uu { get; set; }
        private Members M { get; set; }
        private AddMember Am { get; set; }
        private Update_Member Um { get; set; }
        private LoginForm Lf { get; set; }
        private Profile Pf { get; set; }
        private string Id {  get; set; }
       



        bool BookExpand = false;
        bool MemberExpand = false;
        bool UserExpand = false;
        bool IssueReturnExpand = false;

        public void PanelControl(UserControl uc)
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        public NavigationMenu()
        {
            InitializeComponent();
        }
       public NavigationMenu(string id, string role) : this()
        {
            this.Id = id;
            if (role == "Librarian")
            {
                UserMenu.Hide();
                return;
            }

            UserMenu.Show();
        }

        private void timerBook_Tick(object sender, EventArgs e)
        {
            if (!BookExpand)
            {
                if (IssueReturnExpand)
                {
                    timerIssueReturn.Start();
                }
                if (MemberExpand)
                {
                    timerMember.Start();
                }

                if (UserExpand)
                {
                    timerUser.Start();
                }

                BookMenu.Height += 5;
                if (BookMenu.Height >= 145)
                {
                    timerBook.Stop();
                    BookExpand = true;

                }
            }
            else
            {
                BookMenu.Height -= 5;
                if (BookMenu.Height <= 52)
                {
                    timerBook.Stop();
                    BookExpand = false;

                }
            }

        }

        private void timerMember_Tick(object sender, EventArgs e)
        {
            if (!MemberExpand)
            {
                if (IssueReturnExpand)
                {
                    timerIssueReturn.Start();
                }
                if (BookExpand)
                {
                    timerBook.Start();
                }

                if (UserExpand)
                {
                    timerUser.Start();
                }

                MemberMenu.Height += 5;
                if (MemberMenu.Height >= 145)
                {
                    timerMember.Stop();
                    MemberExpand = true;

                }
            }
            else
            {
                MemberMenu.Height -= 5;
                if (MemberMenu.Height <= 52)
                {
                    timerMember.Stop();
                    MemberExpand = false;

                }
            }
        }

        private void timerUser_Tick(object sender, EventArgs e)
        {
            if (!UserExpand)
            {
                if (UserExpand)
                {
                    timerIssueReturn.Start();
                }
                if (BookExpand)
                {
                    timerBook.Start();
                }

                if (MemberExpand)
                {
                    timerMember.Start();
                }

                UserMenu.Height += 5;
                if (UserMenu.Height >= 145)
                {
                    timerUser.Stop();
                    UserExpand = true;

                }
            }
            else
            {
                UserMenu.Height -= 5;
                if (UserMenu.Height <= 52)
                {
                    timerUser.Stop();
                    UserExpand = false;

                }
            }
        }

        private void timerIssueReturn_Tick(object sender, EventArgs e)
        {
            if (!IssueReturnExpand)
            {

                if (BookExpand)
                {
                    timerBook.Start();
                }

                if (MemberExpand)
                {
                    timerMember.Start();
                }
                if (UserExpand)
                {
                    timerUser.Start();
                }

                IssueReturnMenu.Height += 5;
                if (IssueReturnMenu.Height >= 145)
                {
                    timerIssueReturn.Stop();
                    IssueReturnExpand = true;

                }
            }
            else
            {
                IssueReturnMenu.Height -= 5;
                if (IssueReturnMenu.Height <= 52)
                {
                    timerIssueReturn.Stop();
                    IssueReturnExpand = false;

                }
            }
        }
        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            if (BookExpand)
            {
                timerBook.Start();
            }
            else if (MemberExpand)
            {
                timerMember.Start();
            }
            else if (UserExpand)
            {
                timerUser.Start();
            }
            else if (IssueReturnExpand)
            {
                timerIssueReturn.Start();
            }

            initializeColor(btnDashboard);

            this.Dp = new Dashboard();
            PanelControl(Dp);

        }

        private void btnBook_Click_1(object sender, EventArgs e)
        {
            timerBook.Start();
            this.Bk = new Books();
            initializeColor(btnBook);
            PanelControl(Bk);
        }


        private void btnAddB_Click(object sender, EventArgs e)
        {
            initializeColor(btnAddB);
            this.AB = new AddBook();
            PanelControl(AB);


        }

        private void initializeColor(object sender)
        {
            foreach (Control ctrl in this.SideBar.Controls)
            {
                ctrl.BackColor = this.SideBar.BackColor;
                ctrl.ForeColor = Color.White;
                Control click = (Control)sender;
                click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(226)))), ((int)(((byte)(222)))));
                click.ForeColor = this.SideBar.BackColor;
            }

            foreach (Control ctrl in this.BookMenu.Controls)
            {
                ctrl.BackColor = this.SideBar.BackColor;
                ctrl.ForeColor = Color.White;

                Control click = (Control)sender;
                click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(226)))), ((int)(((byte)(222)))));
                click.ForeColor = this.SideBar.BackColor;
            }
            foreach (Control ctrl in this.MemberMenu.Controls)
            {
                ctrl.BackColor = this.SideBar.BackColor;
                ctrl.ForeColor = Color.White;

                Control click = (Control)sender;
                click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(226)))), ((int)(((byte)(222)))));
                click.ForeColor = this.SideBar.BackColor;
            }
            foreach (Control ctrl in this.UserMenu.Controls)
            {
                ctrl.BackColor = this.SideBar.BackColor;
                ctrl.ForeColor = Color.White;

                Control click = (Control)sender;
                click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(226)))), ((int)(((byte)(222)))));
                click.ForeColor = this.SideBar.BackColor;
            }
            foreach (Control ctrl in this.IssueReturnMenu.Controls)
            {
                ctrl.BackColor = this.SideBar.BackColor;
                ctrl.ForeColor = Color.White;

                Control click = (Control)sender;
                click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(226)))), ((int)(((byte)(222)))));
                click.ForeColor = this.SideBar.BackColor;
            }

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            initializeColor(btnIssue);
            this.IR = new IssueReturn(this.Id);
            PanelControl(IR);

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            initializeColor(btnReturn);
            this.Rn = new Return();
            PanelControl(Rn);
        }

        private void btnIssueorReturn_Click(object sender, EventArgs e)
        {
            timerIssueReturn.Start();
            this.SI = new ShowIssue();
            PanelControl(SI);
            initializeColor(btnIssueorReturn);

        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            timerMember.Start();
            this.M = new Members();
            PanelControl(M);
            initializeColor(btnMember);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            timerUser.Start();
            this.us = new Users();
            PanelControl(us);
            initializeColor(btnUser);
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            this.Ub = new UpdateBook();
            PanelControl(Ub);
            initializeColor(this.btnUpdateBook);
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Lf=new LoginForm();
            Lf.Show();
            this.Close();
        }

        private void NavigationMenuAdmin_Load(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            this.Am = new AddMember();
            PanelControl(Am);
            initializeColor(btnAddB);

        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            this.Um = new Update_Member();
            PanelControl(Um);
            initializeColor(btnUpdateMember);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Au = new AddUser();
            PanelControl(Au);
            initializeColor(btnAddUser);
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            this.Uu = new UpdateUser();
            PanelControl(Uu);
            initializeColor(btnUpdateUser);
        }



        private void btnProfile_Click(object sender, EventArgs e)
        {
            Pf = new Profile(this.Id);
            PanelControl(Pf);
            initializeColor(btnProfile);
        }
    }

}
