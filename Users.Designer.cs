namespace The_Knowledge_Hub
{
    partial class Users
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSearchMemberBox = new System.Windows.Forms.Panel();
            this.cmbSearchUser = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.lblSearchMember = new System.Windows.Forms.Label();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.dgvSearchUser = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateofBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.House = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Road = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblComment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSearchMemberBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearchMemberBox
            // 
            this.pnlSearchMemberBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(226)))), ((int)(((byte)(222)))));
            this.pnlSearchMemberBox.Controls.Add(this.label1);
            this.pnlSearchMemberBox.Controls.Add(this.lblComment);
            this.pnlSearchMemberBox.Controls.Add(this.cmbSearchUser);
            this.pnlSearchMemberBox.Controls.Add(this.lblSearchBy);
            this.pnlSearchMemberBox.Controls.Add(this.lblSearchMember);
            this.pnlSearchMemberBox.Controls.Add(this.btnUserDelete);
            this.pnlSearchMemberBox.Controls.Add(this.txtSearchUser);
            this.pnlSearchMemberBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchMemberBox.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchMemberBox.Name = "pnlSearchMemberBox";
            this.pnlSearchMemberBox.Size = new System.Drawing.Size(1200, 201);
            this.pnlSearchMemberBox.TabIndex = 11;
            // 
            // cmbSearchUser
            // 
            this.cmbSearchUser.FormattingEnabled = true;
            this.cmbSearchUser.Items.AddRange(new object[] {
            "User Id",
            "User Name"});
            this.cmbSearchUser.Location = new System.Drawing.Point(246, 94);
            this.cmbSearchUser.Name = "cmbSearchUser";
            this.cmbSearchUser.Size = new System.Drawing.Size(178, 24);
            this.cmbSearchUser.TabIndex = 1;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(46, 84);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(116, 36);
            this.lblSearchBy.TabIndex = 9;
            this.lblSearchBy.Text = "Search By";
            // 
            // lblSearchMember
            // 
            this.lblSearchMember.AutoSize = true;
            this.lblSearchMember.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMember.Location = new System.Drawing.Point(46, 30);
            this.lblSearchMember.Name = "lblSearchMember";
            this.lblSearchMember.Size = new System.Drawing.Size(137, 36);
            this.lblSearchMember.TabIndex = 8;
            this.lblSearchMember.Text = "Search User";
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.btnUserDelete.FlatAppearance.BorderSize = 0;
            this.btnUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserDelete.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDelete.Location = new System.Drawing.Point(591, 52);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(185, 53);
            this.btnUserDelete.TabIndex = 4;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = false;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(246, 40);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(178, 22);
            this.txtSearchUser.TabIndex = 0;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // dgvSearchUser
            // 
            this.dgvSearchUser.AllowUserToAddRows = false;
            this.dgvSearchUser.AllowUserToDeleteRows = false;
            this.dgvSearchUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dgvSearchUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UserName,
            this.Password,
            this.DateofBirth,
            this.Gender,
            this.PhoneNumber,
            this.House,
            this.Road,
            this.City,
            this.District,
            this.Address,
            this.JoinningDate,
            this.Role});
            this.dgvSearchUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSearchUser.Location = new System.Drawing.Point(0, 195);
            this.dgvSearchUser.Name = "dgvSearchUser";
            this.dgvSearchUser.ReadOnly = true;
            this.dgvSearchUser.RowHeadersWidth = 30;
            this.dgvSearchUser.RowTemplate.Height = 24;
            this.dgvSearchUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchUser.Size = new System.Drawing.Size(1200, 505);
            this.dgvSearchUser.TabIndex = 12;
            this.dgvSearchUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchUser_CellContentClick);
            this.dgvSearchUser.DoubleClick += new System.EventHandler(this.dgvSearchUser_DoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserName.DataPropertyName = "Name";
            this.UserName.HeaderText = "User Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 60;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 35;
            // 
            // DateofBirth
            // 
            this.DateofBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DateofBirth.DataPropertyName = "DOB";
            this.DateofBirth.HeaderText = "Date of Birth";
            this.DateofBirth.MinimumWidth = 6;
            this.DateofBirth.Name = "DateofBirth";
            this.DateofBirth.ReadOnly = true;
            this.DateofBirth.Width = 70;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 50;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 90;
            // 
            // House
            // 
            this.House.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.House.DataPropertyName = "House";
            this.House.HeaderText = "House";
            this.House.MinimumWidth = 6;
            this.House.Name = "House";
            this.House.ReadOnly = true;
            this.House.Width = 50;
            // 
            // Road
            // 
            this.Road.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Road.DataPropertyName = "Road";
            this.Road.HeaderText = "Road";
            this.Road.MinimumWidth = 6;
            this.Road.Name = "Road";
            this.Road.ReadOnly = true;
            this.Road.Width = 50;
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 50;
            // 
            // District
            // 
            this.District.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.District.DataPropertyName = "District";
            this.District.HeaderText = "District";
            this.District.MinimumWidth = 6;
            this.District.Name = "District";
            this.District.ReadOnly = true;
            this.District.Width = 60;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 150;
            // 
            // JoinningDate
            // 
            this.JoinningDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.JoinningDate.DataPropertyName = "JoinningDate";
            this.JoinningDate.HeaderText = "Joinning Date";
            this.JoinningDate.MinimumWidth = 6;
            this.JoinningDate.Name = "JoinningDate";
            this.JoinningDate.ReadOnly = true;
            this.JoinningDate.Width = 70;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 50;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblComment.Location = new System.Drawing.Point(932, 171);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(195, 21);
            this.lblComment.TabIndex = 11;
            this.lblComment.Text = "Double tap to Row for Update";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(932, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select a Row for Delete";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSearchUser);
            this.Controls.Add(this.pnlSearchMemberBox);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.Users_Load);
            this.pnlSearchMemberBox.ResumeLayout(false);
            this.pnlSearchMemberBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearchMemberBox;
        private System.Windows.Forms.ComboBox cmbSearchUser;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Label lblSearchMember;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.DataGridView dgvSearchUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateofBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn House;
        private System.Windows.Forms.DataGridViewTextBoxColumn Road;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn District;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label label1;
    }
}
