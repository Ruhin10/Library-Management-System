namespace The_Knowledge_Hub
{
    partial class BillWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblIssuedBy = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblIssue = new System.Windows.Forms.Label();
            this.lblnameB = new System.Windows.Forms.Label();
            this.lblIdB = new System.Windows.Forms.Label();
            this.lblnameM = new System.Windows.Forms.Label();
            this.lblmId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(226)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.lblTotalCost);
            this.panel1.Controls.Add(this.lblDiscount);
            this.panel1.Controls.Add(this.lblCost);
            this.panel1.Controls.Add(this.lblIssuedBy);
            this.panel1.Controls.Add(this.lblReturn);
            this.panel1.Controls.Add(this.lblIssue);
            this.panel1.Controls.Add(this.lblnameB);
            this.panel1.Controls.Add(this.lblIdB);
            this.panel1.Controls.Add(this.lblnameM);
            this.panel1.Controls.Add(this.lblmId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 700);
            this.panel1.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(223, 624);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(113, 45);
            this.btnOk.TabIndex = 38;
            this.btnOk.Text = "     OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(23, 551);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(143, 27);
            this.lblTotalCost.TabIndex = 23;
            this.lblTotalCost.Text = "Total Cost:";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(23, 506);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(128, 27);
            this.lblDiscount.TabIndex = 22;
            this.lblDiscount.Text = "Discount:";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(23, 461);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(73, 27);
            this.lblCost.TabIndex = 21;
            this.lblCost.Text = "Cost:";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIssuedBy
            // 
            this.lblIssuedBy.AutoSize = true;
            this.lblIssuedBy.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedBy.Location = new System.Drawing.Point(23, 416);
            this.lblIssuedBy.Name = "lblIssuedBy";
            this.lblIssuedBy.Size = new System.Drawing.Size(136, 27);
            this.lblIssuedBy.TabIndex = 20;
            this.lblIssuedBy.Text = "Issued By:";
            this.lblIssuedBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.Location = new System.Drawing.Point(23, 371);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(160, 27);
            this.lblReturn.TabIndex = 19;
            this.lblReturn.Text = "Return Date";
            this.lblReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssue.Location = new System.Drawing.Point(23, 326);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(145, 27);
            this.lblIssue.TabIndex = 18;
            this.lblIssue.Text = "Issed Date:";
            this.lblIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnameB
            // 
            this.lblnameB.AutoSize = true;
            this.lblnameB.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameB.Location = new System.Drawing.Point(23, 281);
            this.lblnameB.Name = "lblnameB";
            this.lblnameB.Size = new System.Drawing.Size(164, 27);
            this.lblnameB.TabIndex = 17;
            this.lblnameB.Text = "Book Name :";
            this.lblnameB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdB
            // 
            this.lblIdB.AutoSize = true;
            this.lblIdB.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdB.Location = new System.Drawing.Point(23, 236);
            this.lblIdB.Name = "lblIdB";
            this.lblIdB.Size = new System.Drawing.Size(117, 27);
            this.lblIdB.TabIndex = 16;
            this.lblIdB.Text = "Book ID:";
            this.lblIdB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnameM
            // 
            this.lblnameM.AutoSize = true;
            this.lblnameM.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameM.Location = new System.Drawing.Point(23, 191);
            this.lblnameM.Name = "lblnameM";
            this.lblnameM.Size = new System.Drawing.Size(202, 27);
            this.lblnameM.TabIndex = 15;
            this.lblnameM.Text = "Member Name :";
            this.lblnameM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblmId
            // 
            this.lblmId.AutoSize = true;
            this.lblmId.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmId.Location = new System.Drawing.Point(23, 146);
            this.lblmId.Name = "lblmId";
            this.lblmId.Size = new System.Drawing.Size(155, 27);
            this.lblmId.TabIndex = 14;
            this.lblmId.Text = "Member ID:";
            this.lblmId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bill Receipt";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "The Knowledge Hub";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(540, 27);
            this.label3.TabIndex = 39;
            this.label3.Text = "..................................................................";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BillWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblIssuedBy;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.Label lblnameB;
        private System.Windows.Forms.Label lblIdB;
        private System.Windows.Forms.Label lblnameM;
        private System.Windows.Forms.Label lblmId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}