namespace The_Knowledge_Hub
{
    partial class Update_Member
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMembershipDate = new System.Windows.Forms.DateTimePicker();
            this.lblMembershipDate = new System.Windows.Forms.Label();
            this.btnMemberUpdate = new System.Windows.Forms.Button();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtRoad = new System.Windows.Forms.TextBox();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.lblRoad = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblHouse = new System.Windows.Forms.Label();
            this.txtPhnNumber = new System.Windows.Forms.TextBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAdderss = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblPhnNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddMember = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(226)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtMemberId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpMembershipDate);
            this.panel1.Controls.Add(this.lblMembershipDate);
            this.panel1.Controls.Add(this.btnMemberUpdate);
            this.panel1.Controls.Add(this.txtDistrict);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.txtRoad);
            this.panel1.Controls.Add(this.txtHouse);
            this.panel1.Controls.Add(this.lblRoad);
            this.panel1.Controls.Add(this.lblDistrict);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.lblHouse);
            this.panel1.Controls.Add(this.txtPhnNumber);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.dtpDOB);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblAdderss);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.lblDOB);
            this.panel1.Controls.Add(this.lblPhnNumber);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblAddMember);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 700);
            this.panel1.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(333, 538);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 48);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtMemberId
            // 
            this.txtMemberId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.txtMemberId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMemberId.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMemberId.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberId.Location = new System.Drawing.Point(308, 132);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.ReadOnly = true;
            this.txtMemberId.Size = new System.Drawing.Size(179, 23);
            this.txtMemberId.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "Member Id";
            // 
            // dtpMembershipDate
            // 
            this.dtpMembershipDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dtpMembershipDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dtpMembershipDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dtpMembershipDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dtpMembershipDate.CustomFormat = "dd-MMMM-yyyy";
            this.dtpMembershipDate.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMembershipDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMembershipDate.Location = new System.Drawing.Point(314, 462);
            this.dtpMembershipDate.Name = "dtpMembershipDate";
            this.dtpMembershipDate.Size = new System.Drawing.Size(305, 30);
            this.dtpMembershipDate.TabIndex = 9;
            // 
            // lblMembershipDate
            // 
            this.lblMembershipDate.AutoSize = true;
            this.lblMembershipDate.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipDate.Location = new System.Drawing.Point(108, 456);
            this.lblMembershipDate.Name = "lblMembershipDate";
            this.lblMembershipDate.Size = new System.Drawing.Size(197, 36);
            this.lblMembershipDate.TabIndex = 21;
            this.lblMembershipDate.Text = "Membership Date";
            // 
            // btnMemberUpdate
            // 
            this.btnMemberUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.btnMemberUpdate.FlatAppearance.BorderSize = 0;
            this.btnMemberUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberUpdate.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberUpdate.Location = new System.Drawing.Point(785, 538);
            this.btnMemberUpdate.Name = "btnMemberUpdate";
            this.btnMemberUpdate.Size = new System.Drawing.Size(142, 48);
            this.btnMemberUpdate.TabIndex = 10;
            this.btnMemberUpdate.Text = "Update";
            this.btnMemberUpdate.UseVisualStyleBackColor = false;
            this.btnMemberUpdate.Click += new System.EventHandler(this.btnMemberUpdate_Click);
            // 
            // txtDistrict
            // 
            this.txtDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.txtDistrict.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDistrict.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistrict.Location = new System.Drawing.Point(915, 402);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(114, 23);
            this.txtDistrict.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(727, 402);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(114, 23);
            this.txtCity.TabIndex = 7;
            // 
            // txtRoad
            // 
            this.txtRoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.txtRoad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoad.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoad.Location = new System.Drawing.Point(562, 401);
            this.txtRoad.Name = "txtRoad";
            this.txtRoad.Size = new System.Drawing.Size(114, 23);
            this.txtRoad.TabIndex = 6;
            // 
            // txtHouse
            // 
            this.txtHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.txtHouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHouse.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHouse.Location = new System.Drawing.Point(385, 402);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(114, 23);
            this.txtHouse.TabIndex = 5;
            // 
            // lblRoad
            // 
            this.lblRoad.AutoSize = true;
            this.lblRoad.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoad.Location = new System.Drawing.Point(499, 399);
            this.lblRoad.Name = "lblRoad";
            this.lblRoad.Size = new System.Drawing.Size(58, 29);
            this.lblRoad.TabIndex = 15;
            this.lblRoad.Text = "Road";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.Location = new System.Drawing.Point(841, 401);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(72, 29);
            this.lblDistrict.TabIndex = 14;
            this.lblDistrict.Text = "District";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(676, 399);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(44, 29);
            this.lblCity.TabIndex = 13;
            this.lblCity.Text = "City";
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouse.Location = new System.Drawing.Point(312, 399);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(67, 29);
            this.lblHouse.TabIndex = 12;
            this.lblHouse.Text = "House";
            // 
            // txtPhnNumber
            // 
            this.txtPhnNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.txtPhnNumber.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhnNumber.Location = new System.Drawing.Point(308, 238);
            this.txtPhnNumber.Name = "txtPhnNumber";
            this.txtPhnNumber.Size = new System.Drawing.Size(462, 30);
            this.txtPhnNumber.TabIndex = 1;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(507, 336);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(111, 40);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(313, 336);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(87, 40);
            this.rbMale.TabIndex = 3;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dtpDOB.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dtpDOB.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dtpDOB.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dtpDOB.CustomFormat = "dd-MMMM-yyyy";
            this.dtpDOB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(309, 288);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(305, 30);
            this.dtpDOB.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.txtName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(308, 184);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(462, 30);
            this.txtName.TabIndex = 0;
            // 
            // lblAdderss
            // 
            this.lblAdderss.AutoSize = true;
            this.lblAdderss.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdderss.Location = new System.Drawing.Point(107, 397);
            this.lblAdderss.Name = "lblAdderss";
            this.lblAdderss.Size = new System.Drawing.Size(97, 36);
            this.lblAdderss.TabIndex = 5;
            this.lblAdderss.Text = "Address";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(107, 342);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(89, 36);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(107, 288);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(144, 36);
            this.lblDOB.TabIndex = 3;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblPhnNumber
            // 
            this.lblPhnNumber.AutoSize = true;
            this.lblPhnNumber.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhnNumber.Location = new System.Drawing.Point(107, 234);
            this.lblPhnNumber.Name = "lblPhnNumber";
            this.lblPhnNumber.Size = new System.Drawing.Size(167, 36);
            this.lblPhnNumber.TabIndex = 2;
            this.lblPhnNumber.Text = "Phone Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(107, 180);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 36);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblAddMember
            // 
            this.lblAddMember.AutoSize = true;
            this.lblAddMember.Font = new System.Drawing.Font("Kristen ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMember.Location = new System.Drawing.Point(104, 27);
            this.lblAddMember.Name = "lblAddMember";
            this.lblAddMember.Size = new System.Drawing.Size(383, 58);
            this.lblAddMember.TabIndex = 0;
            this.lblAddMember.Text = "Update Member";
            // 
            // Update_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Update_Member";
            this.Size = new System.Drawing.Size(1200, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpMembershipDate;
        private System.Windows.Forms.Label lblMembershipDate;
        private System.Windows.Forms.Button btnMemberUpdate;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtRoad;
        private System.Windows.Forms.TextBox txtHouse;
        private System.Windows.Forms.Label lblRoad;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblHouse;
        private System.Windows.Forms.TextBox txtPhnNumber;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAdderss;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblPhnNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddMember;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
    }
}
