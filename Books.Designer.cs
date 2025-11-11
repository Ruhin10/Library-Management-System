namespace The_Knowledge_Hub
{
    partial class Books
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteB = new System.Windows.Forms.Button();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublicationYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShelfLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerHideBook = new System.Windows.Forms.Timer(this.components);
            this.lblErrorBook = new System.Windows.Forms.Label();
            this.pnlUpper.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(226)))), ((int)(((byte)(222)))));
            this.pnlUpper.Controls.Add(this.pnlBtn);
            this.pnlUpper.Controls.Add(this.cmbSearchBy);
            this.pnlUpper.Controls.Add(this.txtSearchText);
            this.pnlUpper.Controls.Add(this.label1);
            this.pnlUpper.Controls.Add(this.lblTitle);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1100, 60);
            this.pnlUpper.TabIndex = 7;
            // 
            // pnlBtn
            // 
            this.pnlBtn.Controls.Add(this.lblErrorBook);
            this.pnlBtn.Controls.Add(this.btnSearch);
            this.pnlBtn.Controls.Add(this.btnDeleteB);
            this.pnlBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtn.Location = new System.Drawing.Point(0, 0);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(1100, 60);
            this.pnlBtn.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(57, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(185, 53);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "           Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteB
            // 
            this.btnDeleteB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.btnDeleteB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteB.FlatAppearance.BorderSize = 0;
            this.btnDeleteB.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteB.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteB.Image")));
            this.btnDeleteB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteB.Location = new System.Drawing.Point(542, 7);
            this.btnDeleteB.Name = "btnDeleteB";
            this.btnDeleteB.Size = new System.Drawing.Size(185, 53);
            this.btnDeleteB.TabIndex = 19;
            this.btnDeleteB.Text = "            Delete Book";
            this.btnDeleteB.UseVisualStyleBackColor = false;
            this.btnDeleteB.Click += new System.EventHandler(this.btnDeleteB_Click);
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbSearchBy.DisplayMember = "Title";
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F);
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Author",
            "Book ID",
            "ISBN",
            "Publisher",
            "Title"});
            this.cmbSearchBy.Location = new System.Drawing.Point(213, 90);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(189, 37);
            this.cmbSearchBy.Sorted = true;
            this.cmbSearchBy.TabIndex = 13;
            // 
            // txtSearchText
            // 
            this.txtSearchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.txtSearchText.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchText.Location = new System.Drawing.Point(213, 30);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(287, 38);
            this.txtSearchText.TabIndex = 11;
            this.txtSearchText.Click += new System.EventHandler(this.txtTitle_TextChanged);
            this.txtSearchText.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search By      :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(29, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 38);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Search Text   :";
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.Author,
            this.Publisher,
            this.PublicationYear,
            this.ISBN,
            this.Language,
            this.Gategory,
            this.ShelfLocation,
            this.AvailableQuantity});
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBook.Location = new System.Drawing.Point(0, 60);
            this.dgvBook.Margin = new System.Windows.Forms.Padding(0);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersWidth = 30;
            this.dgvBook.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(1100, 540);
            this.dgvBook.TabIndex = 8;
            this.dgvBook.DoubleClick += new System.EventHandler(this.dgvBook_DoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Book ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 78;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Book Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 130;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Author ";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 90;
            // 
            // Publisher
            // 
            this.Publisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Publisher.DataPropertyName = "Publisher";
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.MinimumWidth = 6;
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            this.Publisher.Width = 125;
            // 
            // PublicationYear
            // 
            this.PublicationYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PublicationYear.DataPropertyName = "PublicationYear";
            this.PublicationYear.HeaderText = "Publication Year";
            this.PublicationYear.MinimumWidth = 50;
            this.PublicationYear.Name = "PublicationYear";
            this.PublicationYear.ReadOnly = true;
            this.PublicationYear.Width = 65;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 125;
            // 
            // Language
            // 
            this.Language.DataPropertyName = "Language";
            this.Language.HeaderText = "Language";
            this.Language.MinimumWidth = 6;
            this.Language.Name = "Language";
            this.Language.ReadOnly = true;
            this.Language.Width = 60;
            // 
            // Gategory
            // 
            this.Gategory.DataPropertyName = "Category";
            this.Gategory.HeaderText = "Category";
            this.Gategory.MinimumWidth = 6;
            this.Gategory.Name = "Gategory";
            this.Gategory.ReadOnly = true;
            this.Gategory.Width = 85;
            // 
            // ShelfLocation
            // 
            this.ShelfLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ShelfLocation.DataPropertyName = "ShelfLocation";
            this.ShelfLocation.HeaderText = "Shelf Location";
            this.ShelfLocation.MinimumWidth = 6;
            this.ShelfLocation.Name = "ShelfLocation";
            this.ShelfLocation.ReadOnly = true;
            this.ShelfLocation.Width = 50;
            // 
            // AvailableQuantity
            // 
            this.AvailableQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AvailableQuantity.DataPropertyName = "AvailableQuantity";
            this.AvailableQuantity.HeaderText = "Available Quantity";
            this.AvailableQuantity.MinimumWidth = 6;
            this.AvailableQuantity.Name = "AvailableQuantity";
            this.AvailableQuantity.ReadOnly = true;
            this.AvailableQuantity.Width = 60;
            // 
            // timerHideBook
            // 
            this.timerHideBook.Interval = 10;
            this.timerHideBook.Tick += new System.EventHandler(this.timerHideBook_Tick);
            // 
            // lblErrorBook
            // 
            this.lblErrorBook.AutoSize = true;
            this.lblErrorBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorBook.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorBook.Location = new System.Drawing.Point(791, 20);
            this.lblErrorBook.Name = "lblErrorBook";
            this.lblErrorBook.Size = new System.Drawing.Size(306, 25);
            this.lblErrorBook.TabIndex = 104;
            this.lblErrorBook.Text = "***Update Book Double Click on It";
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.pnlUpper);
            this.Name = "Books";
            this.Size = new System.Drawing.Size(1100, 600);
            this.Load += new System.EventHandler(this.Books_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.pnlBtn.ResumeLayout(false);
            this.pnlBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteB;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Timer timerHideBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublicationYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShelfLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableQuantity;
        private System.Windows.Forms.Label lblErrorBook;
    }
}
