namespace The_Knowledge_Hub
{
    partial class NavigationMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationMenu));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.SideBar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.UserMenu = new System.Windows.Forms.Panel();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.MemberMenu = new System.Windows.Forms.Panel();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.IssueReturnMenu = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnIssueorReturn = new System.Windows.Forms.Button();
            this.BookMenu = new System.Windows.Forms.Panel();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnAddB = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.timerBook = new System.Windows.Forms.Timer(this.components);
            this.timerMember = new System.Windows.Forms.Timer(this.components);
            this.timerUser = new System.Windows.Forms.Timer(this.components);
            this.timerIssueReturn = new System.Windows.Forms.Timer(this.components);
            this.SideBar.SuspendLayout();
            this.UserMenu.SuspendLayout();
            this.MemberMenu.SuspendLayout();
            this.IssueReturnMenu.SuspendLayout();
            this.BookMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(226)))), ((int)(((byte)(222)))));
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(228, 77);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1254, 726);
            this.pnlContainer.TabIndex = 9;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.SideBar.Controls.Add(this.btnLogout);
            this.SideBar.Controls.Add(this.btnProfile);
            this.SideBar.Controls.Add(this.UserMenu);
            this.SideBar.Controls.Add(this.MemberMenu);
            this.SideBar.Controls.Add(this.IssueReturnMenu);
            this.SideBar.Controls.Add(this.BookMenu);
            this.SideBar.Controls.Add(this.btnDashboard);
            this.SideBar.Controls.Add(this.panel1);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 77);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(228, 726);
            this.SideBar.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 474);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(228, 62);
            this.btnLogout.TabIndex = 66;
            this.btnLogout.Text = "        Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 412);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(228, 62);
            this.btnProfile.TabIndex = 65;
            this.btnProfile.Text = "            Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // UserMenu
            // 
            this.UserMenu.Controls.Add(this.btnUpdateUser);
            this.UserMenu.Controls.Add(this.btnAddUser);
            this.UserMenu.Controls.Add(this.btnUser);
            this.UserMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserMenu.Location = new System.Drawing.Point(0, 350);
            this.UserMenu.Name = "UserMenu";
            this.UserMenu.Size = new System.Drawing.Size(228, 62);
            this.UserMenu.TabIndex = 64;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateUser.Location = new System.Drawing.Point(0, 124);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(228, 62);
            this.btnUpdateUser.TabIndex = 3;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddUser.Location = new System.Drawing.Point(0, 62);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(228, 62);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(228, 62);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "     User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // MemberMenu
            // 
            this.MemberMenu.Controls.Add(this.btnUpdateMember);
            this.MemberMenu.Controls.Add(this.btnAddMember);
            this.MemberMenu.Controls.Add(this.btnMember);
            this.MemberMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.MemberMenu.Location = new System.Drawing.Point(0, 288);
            this.MemberMenu.Name = "MemberMenu";
            this.MemberMenu.Size = new System.Drawing.Size(228, 62);
            this.MemberMenu.TabIndex = 63;
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateMember.FlatAppearance.BorderSize = 0;
            this.btnUpdateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMember.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMember.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMember.Location = new System.Drawing.Point(0, 124);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(228, 62);
            this.btnUpdateMember.TabIndex = 3;
            this.btnUpdateMember.Text = "Update Member";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.Location = new System.Drawing.Point(0, 62);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(228, 62);
            this.btnAddMember.TabIndex = 2;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnMember
            // 
            this.btnMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.ForeColor = System.Drawing.Color.White;
            this.btnMember.Image = ((System.Drawing.Image)(resources.GetObject("btnMember.Image")));
            this.btnMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.Location = new System.Drawing.Point(0, 0);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(228, 62);
            this.btnMember.TabIndex = 1;
            this.btnMember.Text = "          Member";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // IssueReturnMenu
            // 
            this.IssueReturnMenu.Controls.Add(this.btnReturn);
            this.IssueReturnMenu.Controls.Add(this.btnIssue);
            this.IssueReturnMenu.Controls.Add(this.btnIssueorReturn);
            this.IssueReturnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.IssueReturnMenu.Location = new System.Drawing.Point(0, 226);
            this.IssueReturnMenu.Name = "IssueReturnMenu";
            this.IssueReturnMenu.Size = new System.Drawing.Size(228, 62);
            this.IssueReturnMenu.TabIndex = 62;
            // 
            // btnReturn
            // 
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(0, 124);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(228, 62);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIssue.FlatAppearance.BorderSize = 0;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIssue.Location = new System.Drawing.Point(0, 62);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(228, 62);
            this.btnIssue.TabIndex = 5;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnIssueorReturn
            // 
            this.btnIssueorReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIssueorReturn.FlatAppearance.BorderSize = 0;
            this.btnIssueorReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueorReturn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueorReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIssueorReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnIssueorReturn.Image")));
            this.btnIssueorReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueorReturn.Location = new System.Drawing.Point(0, 0);
            this.btnIssueorReturn.Name = "btnIssueorReturn";
            this.btnIssueorReturn.Size = new System.Drawing.Size(228, 62);
            this.btnIssueorReturn.TabIndex = 4;
            this.btnIssueorReturn.Text = "          Issue/Return";
            this.btnIssueorReturn.UseVisualStyleBackColor = true;
            this.btnIssueorReturn.Click += new System.EventHandler(this.btnIssueorReturn_Click);
            // 
            // BookMenu
            // 
            this.BookMenu.Controls.Add(this.btnUpdateBook);
            this.BookMenu.Controls.Add(this.btnAddB);
            this.BookMenu.Controls.Add(this.btnBook);
            this.BookMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookMenu.Location = new System.Drawing.Point(0, 164);
            this.BookMenu.Name = "BookMenu";
            this.BookMenu.Size = new System.Drawing.Size(228, 62);
            this.BookMenu.TabIndex = 1;
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateBook.FlatAppearance.BorderSize = 0;
            this.btnUpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBook.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateBook.Location = new System.Drawing.Point(0, 124);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(228, 62);
            this.btnUpdateBook.TabIndex = 3;
            this.btnUpdateBook.Text = "    Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnAddB
            // 
            this.btnAddB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddB.FlatAppearance.BorderSize = 0;
            this.btnAddB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddB.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddB.Location = new System.Drawing.Point(0, 62);
            this.btnAddB.Name = "btnAddB";
            this.btnAddB.Size = new System.Drawing.Size(228, 62);
            this.btnAddB.TabIndex = 2;
            this.btnAddB.Text = "Add Book";
            this.btnAddB.UseVisualStyleBackColor = true;
            this.btnAddB.Click += new System.EventHandler(this.btnAddB_Click);
            // 
            // btnBook
            // 
            this.btnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBook.Image = ((System.Drawing.Image)(resources.GetObject("btnBook.Image")));
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.Location = new System.Drawing.Point(0, 0);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(228, 62);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "      Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click_1);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 102);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(228, 62);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "            Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 102);
            this.panel1.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(226)))), ((int)(((byte)(222)))));
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1482, 77);
            this.pnlHeader.TabIndex = 7;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Elephant", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblWelcome.Location = new System.Drawing.Point(516, 8);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(510, 60);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "The Knowledge Hub";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerBook
            // 
            this.timerBook.Interval = 10;
            this.timerBook.Tick += new System.EventHandler(this.timerBook_Tick);
            // 
            // timerMember
            // 
            this.timerMember.Interval = 10;
            this.timerMember.Tick += new System.EventHandler(this.timerMember_Tick);
            // 
            // timerUser
            // 
            this.timerUser.Interval = 10;
            this.timerUser.Tick += new System.EventHandler(this.timerUser_Tick);
            // 
            // timerIssueReturn
            // 
            this.timerIssueReturn.Interval = 10;
            this.timerIssueReturn.Tick += new System.EventHandler(this.timerIssueReturn_Tick);
            // 
            // NavigationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NavigationMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Knowledge Hub";
            this.Load += new System.EventHandler(this.NavigationMenuAdmin_Load);
            this.SideBar.ResumeLayout(false);
            this.UserMenu.ResumeLayout(false);
            this.MemberMenu.ResumeLayout(false);
            this.IssueReturnMenu.ResumeLayout(false);
            this.BookMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Timer timerBook;
        private System.Windows.Forms.Timer timerMember;
        private System.Windows.Forms.Timer timerUser;
        private System.Windows.Forms.Timer timerIssueReturn;
        private System.Windows.Forms.Panel IssueReturnMenu;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnIssueorReturn;
        private System.Windows.Forms.Panel BookMenu;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnAddB;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel UserMenu;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel MemberMenu;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

