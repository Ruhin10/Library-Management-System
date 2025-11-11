namespace The_Knowledge_Hub
{
    partial class Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlIssue = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlbtn = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClearB = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvIssue = new System.Windows.Forms.DataGridView();
            this.Bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlIssue.SuspendLayout();
            this.pnlbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIssue
            // 
            this.pnlIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(226)))), ((int)(((byte)(222)))));
            this.pnlIssue.Controls.Add(this.label3);
            this.pnlIssue.Controls.Add(this.txtPenalty);
            this.pnlIssue.Controls.Add(this.dtpReturn);
            this.pnlIssue.Controls.Add(this.label2);
            this.pnlIssue.Controls.Add(this.lblError);
            this.pnlIssue.Controls.Add(this.pnlbtn);
            this.pnlIssue.Controls.Add(this.label9);
            this.pnlIssue.Controls.Add(this.txtBill);
            this.pnlIssue.Controls.Add(this.label1);
            this.pnlIssue.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlIssue.Location = new System.Drawing.Point(0, 0);
            this.pnlIssue.Name = "pnlIssue";
            this.pnlIssue.Size = new System.Drawing.Size(1200, 339);
            this.pnlIssue.TabIndex = 15;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Tomato;
            this.lblError.Location = new System.Drawing.Point(515, 101);
            this.lblError.Margin = new System.Windows.Forms.Padding(0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(163, 29);
            this.lblError.TabIndex = 102;
            this.lblError.Text = "Bill No. not Match";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // pnlbtn
            // 
            this.pnlbtn.Controls.Add(this.btnReturn);
            this.pnlbtn.Controls.Add(this.btnClearB);
            this.pnlbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbtn.Location = new System.Drawing.Point(0, 279);
            this.pnlbtn.Name = "pnlbtn";
            this.pnlbtn.Size = new System.Drawing.Size(1200, 60);
            this.pnlbtn.TabIndex = 101;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(288, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(176, 53);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "      Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClearB
            // 
            this.btnClearB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.btnClearB.FlatAppearance.BorderSize = 0;
            this.btnClearB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearB.Image = ((System.Drawing.Image)(resources.GetObject("btnClearB.Image")));
            this.btnClearB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearB.Location = new System.Drawing.Point(731, 7);
            this.btnClearB.Name = "btnClearB";
            this.btnClearB.Size = new System.Drawing.Size(160, 45);
            this.btnClearB.TabIndex = 8;
            this.btnClearB.Text = "           Clear All";
            this.btnClearB.UseVisualStyleBackColor = false;
            this.btnClearB.TextChanged += new System.EventHandler(this.btnClearB_Click);
            this.btnClearB.Click += new System.EventHandler(this.btnClearB_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Kristen ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(438, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(318, 58);
            this.label9.TabIndex = 64;
            this.label9.Text = "Return  Book";
            // 
            // txtBill
            // 
            this.txtBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.txtBill.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.Location = new System.Drawing.Point(214, 96);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(287, 38);
            this.txtBill.TabIndex = 0;
            this.txtBill.TextChanged += new System.EventHandler(this.txtSearchMember_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 36);
            this.label1.TabIndex = 51;
            this.label1.Text = "Bill NO.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvIssue
            // 
            this.dgvIssue.AllowUserToAddRows = false;
            this.dgvIssue.AllowUserToDeleteRows = false;
            this.dgvIssue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvIssue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dgvIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bill,
            this.IdM,
            this.nameM,
            this.idB,
            this.nameB,
            this.issued,
            this.dateDue,
            this.issuedBy,
            this.bookCost,
            this.discountAmount,
            this.TotalCost,
            this.ReturnStatus});
            this.dgvIssue.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvIssue.Location = new System.Drawing.Point(0, 339);
            this.dgvIssue.Margin = new System.Windows.Forms.Padding(0);
            this.dgvIssue.Name = "dgvIssue";
            this.dgvIssue.ReadOnly = true;
            this.dgvIssue.RowHeadersWidth = 20;
            this.dgvIssue.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(120)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvIssue.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIssue.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dgvIssue.RowTemplate.Height = 24;
            this.dgvIssue.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIssue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssue.Size = new System.Drawing.Size(1200, 361);
            this.dgvIssue.TabIndex = 34;
            this.dgvIssue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIssue_CellClick);
            // 
            // Bill
            // 
            this.Bill.DataPropertyName = "Bill";
            this.Bill.HeaderText = "Bill No.";
            this.Bill.MinimumWidth = 6;
            this.Bill.Name = "Bill";
            this.Bill.ReadOnly = true;
            this.Bill.Width = 73;
            // 
            // IdM
            // 
            this.IdM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdM.DataPropertyName = "Member ID";
            this.IdM.HeaderText = "Member ID";
            this.IdM.MinimumWidth = 6;
            this.IdM.Name = "IdM";
            this.IdM.ReadOnly = true;
            this.IdM.Width = 55;
            // 
            // nameM
            // 
            this.nameM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameM.DataPropertyName = "Member Name";
            this.nameM.HeaderText = "Member Name";
            this.nameM.MinimumWidth = 6;
            this.nameM.Name = "nameM";
            this.nameM.ReadOnly = true;
            this.nameM.Width = 125;
            // 
            // idB
            // 
            this.idB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idB.DataPropertyName = "Book ID";
            this.idB.HeaderText = "Book Id";
            this.idB.MinimumWidth = 6;
            this.idB.Name = "idB";
            this.idB.ReadOnly = true;
            this.idB.Width = 60;
            // 
            // nameB
            // 
            this.nameB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameB.DataPropertyName = "Book Name";
            this.nameB.HeaderText = "Book Name";
            this.nameB.MinimumWidth = 6;
            this.nameB.Name = "nameB";
            this.nameB.ReadOnly = true;
            this.nameB.Width = 130;
            // 
            // issued
            // 
            this.issued.DataPropertyName = "Issue Date";
            this.issued.HeaderText = "Issue Date";
            this.issued.MinimumWidth = 6;
            this.issued.Name = "issued";
            this.issued.ReadOnly = true;
            this.issued.Width = 92;
            // 
            // dateDue
            // 
            this.dateDue.DataPropertyName = "Due Date";
            this.dateDue.HeaderText = "Due Date";
            this.dateDue.MinimumWidth = 6;
            this.dateDue.Name = "dateDue";
            this.dateDue.ReadOnly = true;
            this.dateDue.Width = 86;
            // 
            // issuedBy
            // 
            this.issuedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.issuedBy.DataPropertyName = "Issued By";
            this.issuedBy.HeaderText = "Issued BY";
            this.issuedBy.MinimumWidth = 6;
            this.issuedBy.Name = "issuedBy";
            this.issuedBy.ReadOnly = true;
            this.issuedBy.Width = 70;
            // 
            // bookCost
            // 
            this.bookCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.bookCost.DataPropertyName = "Cost";
            this.bookCost.HeaderText = "Cost";
            this.bookCost.MinimumWidth = 6;
            this.bookCost.Name = "bookCost";
            this.bookCost.ReadOnly = true;
            this.bookCost.Width = 45;
            // 
            // discountAmount
            // 
            this.discountAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.discountAmount.DataPropertyName = "Discount";
            this.discountAmount.HeaderText = "Discount";
            this.discountAmount.MinimumWidth = 6;
            this.discountAmount.Name = "discountAmount";
            this.discountAmount.ReadOnly = true;
            this.discountAmount.Width = 50;
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TotalCost.DataPropertyName = "Total Cost";
            this.TotalCost.HeaderText = "Total Cost";
            this.TotalCost.MinimumWidth = 6;
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            this.TotalCost.Width = 50;
            // 
            // ReturnStatus
            // 
            this.ReturnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ReturnStatus.DataPropertyName = "Return Status";
            this.ReturnStatus.HeaderText = "Return Status";
            this.ReturnStatus.MinimumWidth = 6;
            this.ReturnStatus.Name = "ReturnStatus";
            this.ReturnStatus.ReadOnly = true;
            this.ReturnStatus.Width = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 36);
            this.label2.TabIndex = 103;
            this.label2.Text = "Return Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpReturn
            // 
            this.dtpReturn.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dtpReturn.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dtpReturn.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dtpReturn.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dtpReturn.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dtpReturn.CustomFormat = "dd-MMMM-yyyy";
            this.dtpReturn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturn.Location = new System.Drawing.Point(214, 157);
            this.dtpReturn.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpReturn.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(287, 36);
            this.dtpReturn.TabIndex = 104;
            this.dtpReturn.ValueChanged += new System.EventHandler(this.dtpReturn_ValueChanged);
            // 
            // txtPenalty
            // 
            this.txtPenalty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.txtPenalty.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenalty.Location = new System.Drawing.Point(214, 199);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.Size = new System.Drawing.Size(195, 38);
            this.txtPenalty.TabIndex = 105;
            this.txtPenalty.Text = "00";
            this.txtPenalty.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPenalty_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 36);
            this.label3.TabIndex = 106;
            this.label3.Text = "Penalty";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvIssue);
            this.Controls.Add(this.pnlIssue);
            this.Name = "Return";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.Return_Load);
            this.pnlIssue.ResumeLayout(false);
            this.pnlIssue.PerformLayout();
            this.pnlbtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIssue;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlbtn;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClearB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdM;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameM;
        private System.Windows.Forms.DataGridViewTextBoxColumn idB;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameB;
        private System.Windows.Forms.DataGridViewTextBoxColumn issued;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.DateTimePicker dtpReturn;
    }
}
