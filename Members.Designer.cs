namespace The_Knowledge_Hub
{
    partial class Members
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
            this.cmbSearchMember = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.lblSearchMember = new System.Windows.Forms.Label();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.dgvSearchMember = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateofBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.House = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Road = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalIssued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblComment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSearchMemberBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchMember)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearchMemberBox
            // 
            this.pnlSearchMemberBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(226)))), ((int)(((byte)(222)))));
            this.pnlSearchMemberBox.Controls.Add(this.label1);
            this.pnlSearchMemberBox.Controls.Add(this.lblComment);
            this.pnlSearchMemberBox.Controls.Add(this.cmbSearchMember);
            this.pnlSearchMemberBox.Controls.Add(this.lblSearchBy);
            this.pnlSearchMemberBox.Controls.Add(this.lblSearchMember);
            this.pnlSearchMemberBox.Controls.Add(this.btnDeleteMember);
            this.pnlSearchMemberBox.Controls.Add(this.txtSearchMember);
            this.pnlSearchMemberBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchMemberBox.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchMemberBox.Name = "pnlSearchMemberBox";
            this.pnlSearchMemberBox.Size = new System.Drawing.Size(1200, 199);
            this.pnlSearchMemberBox.TabIndex = 2;
            // 
            // cmbSearchMember
            // 
            this.cmbSearchMember.FormattingEnabled = true;
            this.cmbSearchMember.Items.AddRange(new object[] {
            "Member Id",
            "Member Name"});
            this.cmbSearchMember.Location = new System.Drawing.Point(246, 94);
            this.cmbSearchMember.Name = "cmbSearchMember";
            this.cmbSearchMember.Size = new System.Drawing.Size(178, 24);
            this.cmbSearchMember.TabIndex = 1;
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
            this.lblSearchMember.Size = new System.Drawing.Size(176, 36);
            this.lblSearchMember.TabIndex = 8;
            this.lblSearchMember.Text = "Search Member";
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.btnDeleteMember.FlatAppearance.BorderSize = 0;
            this.btnDeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMember.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMember.Location = new System.Drawing.Point(591, 52);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(185, 53);
            this.btnDeleteMember.TabIndex = 4;
            this.btnDeleteMember.Text = "Delete";
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Location = new System.Drawing.Point(246, 40);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(178, 22);
            this.txtSearchMember.TabIndex = 0;
            this.txtSearchMember.TextChanged += new System.EventHandler(this.txtSearchMember_TextChanged);
            // 
            // dgvSearchMember
            // 
            this.dgvSearchMember.AllowUserToAddRows = false;
            this.dgvSearchMember.AllowUserToDeleteRows = false;
            this.dgvSearchMember.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dgvSearchMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.MemberName,
            this.DateofBirth,
            this.Gender,
            this.PhoneNumber,
            this.House,
            this.Road,
            this.City,
            this.District,
            this.Address,
            this.MembershipDate,
            this.TotalIssued});
            this.dgvSearchMember.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSearchMember.Location = new System.Drawing.Point(0, 196);
            this.dgvSearchMember.Name = "dgvSearchMember";
            this.dgvSearchMember.ReadOnly = true;
            this.dgvSearchMember.RowHeadersWidth = 30;
            this.dgvSearchMember.RowTemplate.Height = 24;
            this.dgvSearchMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchMember.Size = new System.Drawing.Size(1200, 504);
            this.dgvSearchMember.TabIndex = 3;
            this.dgvSearchMember.DoubleClick += new System.EventHandler(this.dgvSearchMember_DoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 49;
            // 
            // MemberName
            // 
            this.MemberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MemberName.DataPropertyName = "Name";
            this.MemberName.HeaderText = "Member Name";
            this.MemberName.MinimumWidth = 6;
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            this.MemberName.Width = 116;
            // 
            // DateofBirth
            // 
            this.DateofBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DateofBirth.DataPropertyName = "Date of Birth";
            this.DateofBirth.HeaderText = "Date of Birth";
            this.DateofBirth.MinimumWidth = 6;
            this.DateofBirth.Name = "DateofBirth";
            this.DateofBirth.ReadOnly = true;
            this.DateofBirth.Width = 76;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 81;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PhoneNumber.DataPropertyName = "Phone Number";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 105;
            // 
            // House
            // 
            this.House.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.House.DataPropertyName = "House";
            this.House.HeaderText = "House";
            this.House.MinimumWidth = 6;
            this.House.Name = "House";
            this.House.ReadOnly = true;
            this.House.Width = 76;
            // 
            // Road
            // 
            this.Road.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Road.DataPropertyName = "Road";
            this.Road.HeaderText = "Road";
            this.Road.MinimumWidth = 6;
            this.Road.Name = "Road";
            this.Road.ReadOnly = true;
            this.Road.Width = 70;
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 58;
            // 
            // District
            // 
            this.District.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.District.DataPropertyName = "District";
            this.District.HeaderText = "District";
            this.District.MinimumWidth = 6;
            this.District.Name = "District";
            this.District.ReadOnly = true;
            this.District.Width = 76;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 87;
            // 
            // MembershipDate
            // 
            this.MembershipDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MembershipDate.DataPropertyName = "Membership Date";
            this.MembershipDate.HeaderText = "Membership Date";
            this.MembershipDate.MinimumWidth = 6;
            this.MembershipDate.Name = "MembershipDate";
            this.MembershipDate.ReadOnly = true;
            this.MembershipDate.Width = 131;
            // 
            // TotalIssued
            // 
            this.TotalIssued.DataPropertyName = "Total Issued";
            this.TotalIssued.HeaderText = "Total Issued";
            this.TotalIssued.MinimumWidth = 6;
            this.TotalIssued.Name = "TotalIssued";
            this.TotalIssued.ReadOnly = true;
            this.TotalIssued.Width = 125;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblComment.Location = new System.Drawing.Point(932, 171);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(195, 21);
            this.lblComment.TabIndex = 10;
            this.lblComment.Text = "Double tap to Row for Update";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(942, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select a Row for Delete";
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSearchMember);
            this.Controls.Add(this.pnlSearchMemberBox);
            this.Name = "Members";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.Members_Load);
            this.pnlSearchMemberBox.ResumeLayout(false);
            this.pnlSearchMemberBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearchMemberBox;
        private System.Windows.Forms.ComboBox cmbSearchMember;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Label lblSearchMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.DataGridView dgvSearchMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateofBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn House;
        private System.Windows.Forms.DataGridViewTextBoxColumn Road;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn District;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalIssued;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label label1;
    }
}
