namespace The_Knowledge_Hub
{
    partial class ShowIssue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowIssue));
            this.dgvIssue = new System.Windows.Forms.DataGridView();
            this.Bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Penalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlIssue = new System.Windows.Forms.Panel();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.lblBIll = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblErrorBook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssue)).BeginInit();
            this.pnlIssue.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.ReturnDate,
            this.issuedBy,
            this.bookCost,
            this.discountAmount,
            this.Penalty,
            this.TotalCost,
            this.ReturnStatus});
            this.dgvIssue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvIssue.Location = new System.Drawing.Point(0, 249);
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
            this.dgvIssue.Size = new System.Drawing.Size(1200, 451);
            this.dgvIssue.TabIndex = 34;
            this.dgvIssue.DoubleClick += new System.EventHandler(this.dgvIssue_DoubleClick);
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
            this.nameM.Width = 130;
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
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "Return Date";
            this.ReturnDate.HeaderText = "Return Date";
            this.ReturnDate.MinimumWidth = 6;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            this.ReturnDate.Width = 99;
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
            // Penalty
            // 
            this.Penalty.DataPropertyName = "Penalty";
            this.Penalty.HeaderText = "Penalty";
            this.Penalty.MinimumWidth = 6;
            this.Penalty.Name = "Penalty";
            this.Penalty.ReadOnly = true;
            this.Penalty.Width = 81;
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
            // pnlIssue
            // 
            this.pnlIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(226)))), ((int)(((byte)(222)))));
            this.pnlIssue.Controls.Add(this.panel1);
            this.pnlIssue.Controls.Add(this.txtBill);
            this.pnlIssue.Controls.Add(this.lblBIll);
            this.pnlIssue.Controls.Add(this.label9);
            this.pnlIssue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlIssue.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pnlIssue.Location = new System.Drawing.Point(0, 0);
            this.pnlIssue.Name = "pnlIssue";
            this.pnlIssue.Size = new System.Drawing.Size(1200, 249);
            this.pnlIssue.TabIndex = 35;
            // 
            // txtBill
            // 
            this.txtBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.txtBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBill.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.Location = new System.Drawing.Point(294, 123);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(165, 38);
            this.txtBill.TabIndex = 4;
            this.txtBill.TextChanged += new System.EventHandler(this.txtBill_TextChanged);
            // 
            // lblBIll
            // 
            this.lblBIll.AutoSize = true;
            this.lblBIll.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBIll.Location = new System.Drawing.Point(94, 125);
            this.lblBIll.Margin = new System.Windows.Forms.Padding(0);
            this.lblBIll.Name = "lblBIll";
            this.lblBIll.Size = new System.Drawing.Size(97, 36);
            this.lblBIll.TabIndex = 106;
            this.lblBIll.Text = "Bill NO :";
            this.lblBIll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Kristen ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(438, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 58);
            this.label9.TabIndex = 64;
            this.label9.Text = "Issue List";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblErrorBook);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 60);
            this.panel1.TabIndex = 107;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(675, 7);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 45);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "         Update Issue";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(270, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 45);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "            Delete Issue";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblErrorBook
            // 
            this.lblErrorBook.AutoSize = true;
            this.lblErrorBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorBook.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorBook.Location = new System.Drawing.Point(863, 16);
            this.lblErrorBook.Name = "lblErrorBook";
            this.lblErrorBook.Size = new System.Drawing.Size(306, 25);
            this.lblErrorBook.TabIndex = 105;
            this.lblErrorBook.Text = "***Update Book Double Click on It";
            // 
            // ShowIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlIssue);
            this.Controls.Add(this.dgvIssue);
            this.Name = "ShowIssue";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.ShowIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssue)).EndInit();
            this.pnlIssue.ResumeLayout(false);
            this.pnlIssue.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdM;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameM;
        private System.Windows.Forms.DataGridViewTextBoxColumn idB;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameB;
        private System.Windows.Forms.DataGridViewTextBoxColumn issued;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Penalty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnStatus;
        private System.Windows.Forms.Panel pnlIssue;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label lblBIll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblErrorBook;
    }
}
