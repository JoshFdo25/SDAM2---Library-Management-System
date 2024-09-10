namespace LMS_GUI
{
    partial class Manage_Books
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Books));
            dataGridViewBooks = new DataGridView();
            bookIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iSBNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isAvailableDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            bookBindingSource = new BindingSource(components);
            availableBooksRBtn = new RadioButton();
            existingBooksRBtn = new RadioButton();
            BookIdLabel = new Label();
            bookTitleLabel = new Label();
            bookAuthorLabel = new Label();
            bookIsbnLabel = new Label();
            bookIdTxt = new TextBox();
            bookTitleTxt = new TextBox();
            bookAuthorTxt = new TextBox();
            bookIsbnTxt = new TextBox();
            addBookBtn = new Button();
            removeBookBtn = new Button();
            issueBookBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.Anchor = AnchorStyles.None;
            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { bookIDDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, authorDataGridViewTextBoxColumn, iSBNDataGridViewTextBoxColumn, isAvailableDataGridViewCheckBoxColumn });
            dataGridViewBooks.DataSource = bookBindingSource;
            dataGridViewBooks.Location = new Point(210, 12);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.RowTemplate.Height = 29;
            dataGridViewBooks.Size = new Size(701, 300);
            dataGridViewBooks.TabIndex = 0;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            bookIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            bookIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            authorDataGridViewTextBoxColumn.HeaderText = "Author";
            authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            authorDataGridViewTextBoxColumn.Width = 125;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            iSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            iSBNDataGridViewTextBoxColumn.Width = 125;
            // 
            // isAvailableDataGridViewCheckBoxColumn
            // 
            isAvailableDataGridViewCheckBoxColumn.DataPropertyName = "IsAvailable";
            isAvailableDataGridViewCheckBoxColumn.HeaderText = "IsAvailable";
            isAvailableDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isAvailableDataGridViewCheckBoxColumn.Name = "isAvailableDataGridViewCheckBoxColumn";
            isAvailableDataGridViewCheckBoxColumn.Width = 125;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // availableBooksRBtn
            // 
            availableBooksRBtn.Anchor = AnchorStyles.None;
            availableBooksRBtn.AutoSize = true;
            availableBooksRBtn.BackColor = Color.Transparent;
            availableBooksRBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            availableBooksRBtn.Location = new Point(29, 84);
            availableBooksRBtn.Name = "availableBooksRBtn";
            availableBooksRBtn.Size = new Size(171, 32);
            availableBooksRBtn.TabIndex = 1;
            availableBooksRBtn.TabStop = true;
            availableBooksRBtn.Text = "Available Books";
            availableBooksRBtn.UseVisualStyleBackColor = false;
            availableBooksRBtn.CheckedChanged += availableBooksRBtn_CheckedChanged;
            // 
            // existingBooksRBtn
            // 
            existingBooksRBtn.Anchor = AnchorStyles.None;
            existingBooksRBtn.AutoSize = true;
            existingBooksRBtn.BackColor = Color.Transparent;
            existingBooksRBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            existingBooksRBtn.Location = new Point(29, 131);
            existingBooksRBtn.Name = "existingBooksRBtn";
            existingBooksRBtn.Size = new Size(158, 32);
            existingBooksRBtn.TabIndex = 2;
            existingBooksRBtn.TabStop = true;
            existingBooksRBtn.Text = "Existing Books";
            existingBooksRBtn.UseVisualStyleBackColor = false;
            existingBooksRBtn.CheckedChanged += existingBooksRBtn_CheckedChanged;
            // 
            // BookIdLabel
            // 
            BookIdLabel.Anchor = AnchorStyles.None;
            BookIdLabel.AutoSize = true;
            BookIdLabel.BackColor = Color.Transparent;
            BookIdLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BookIdLabel.Location = new Point(78, 408);
            BookIdLabel.Name = "BookIdLabel";
            BookIdLabel.Size = new Size(81, 28);
            BookIdLabel.TabIndex = 3;
            BookIdLabel.Text = "Book ID";
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.Anchor = AnchorStyles.None;
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.BackColor = Color.Transparent;
            bookTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookTitleLabel.Location = new Point(78, 455);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new Size(49, 28);
            bookTitleLabel.TabIndex = 4;
            bookTitleLabel.Text = "Title";
            // 
            // bookAuthorLabel
            // 
            bookAuthorLabel.Anchor = AnchorStyles.None;
            bookAuthorLabel.AutoSize = true;
            bookAuthorLabel.BackColor = Color.Transparent;
            bookAuthorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookAuthorLabel.Location = new Point(566, 408);
            bookAuthorLabel.Name = "bookAuthorLabel";
            bookAuthorLabel.Size = new Size(73, 28);
            bookAuthorLabel.TabIndex = 5;
            bookAuthorLabel.Text = "Author";
            // 
            // bookIsbnLabel
            // 
            bookIsbnLabel.Anchor = AnchorStyles.None;
            bookIsbnLabel.AutoSize = true;
            bookIsbnLabel.BackColor = Color.Transparent;
            bookIsbnLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookIsbnLabel.Location = new Point(566, 455);
            bookIsbnLabel.Name = "bookIsbnLabel";
            bookIsbnLabel.Size = new Size(54, 28);
            bookIsbnLabel.TabIndex = 6;
            bookIsbnLabel.Text = "ISBN";
            // 
            // bookIdTxt
            // 
            bookIdTxt.Anchor = AnchorStyles.None;
            bookIdTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookIdTxt.Location = new Point(165, 405);
            bookIdTxt.Name = "bookIdTxt";
            bookIdTxt.PlaceholderText = "Enter Book ID";
            bookIdTxt.Size = new Size(321, 34);
            bookIdTxt.TabIndex = 7;
            // 
            // bookTitleTxt
            // 
            bookTitleTxt.Anchor = AnchorStyles.None;
            bookTitleTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookTitleTxt.Location = new Point(165, 452);
            bookTitleTxt.Name = "bookTitleTxt";
            bookTitleTxt.PlaceholderText = "Enter Book Title";
            bookTitleTxt.Size = new Size(321, 34);
            bookTitleTxt.TabIndex = 8;
            // 
            // bookAuthorTxt
            // 
            bookAuthorTxt.Anchor = AnchorStyles.None;
            bookAuthorTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookAuthorTxt.Location = new Point(653, 405);
            bookAuthorTxt.Name = "bookAuthorTxt";
            bookAuthorTxt.PlaceholderText = "Enter Book Author";
            bookAuthorTxt.Size = new Size(329, 34);
            bookAuthorTxt.TabIndex = 9;
            // 
            // bookIsbnTxt
            // 
            bookIsbnTxt.Anchor = AnchorStyles.None;
            bookIsbnTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookIsbnTxt.Location = new Point(653, 452);
            bookIsbnTxt.Name = "bookIsbnTxt";
            bookIsbnTxt.PlaceholderText = "Enter ISBN";
            bookIsbnTxt.Size = new Size(329, 34);
            bookIsbnTxt.TabIndex = 10;
            // 
            // addBookBtn
            // 
            addBookBtn.Anchor = AnchorStyles.None;
            addBookBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            addBookBtn.Location = new Point(270, 544);
            addBookBtn.Name = "addBookBtn";
            addBookBtn.Size = new Size(171, 52);
            addBookBtn.TabIndex = 11;
            addBookBtn.Text = "Add Book";
            addBookBtn.UseVisualStyleBackColor = true;
            addBookBtn.Click += addBookBtn_Click;
            // 
            // removeBookBtn
            // 
            removeBookBtn.Anchor = AnchorStyles.None;
            removeBookBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            removeBookBtn.Location = new Point(467, 544);
            removeBookBtn.Name = "removeBookBtn";
            removeBookBtn.Size = new Size(171, 52);
            removeBookBtn.TabIndex = 12;
            removeBookBtn.Text = "Remove Book";
            removeBookBtn.UseVisualStyleBackColor = true;
            removeBookBtn.Click += removeBookBtn_Click;
            // 
            // issueBookBtn
            // 
            issueBookBtn.Anchor = AnchorStyles.None;
            issueBookBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            issueBookBtn.Location = new Point(663, 544);
            issueBookBtn.Name = "issueBookBtn";
            issueBookBtn.Size = new Size(171, 52);
            issueBookBtn.TabIndex = 13;
            issueBookBtn.Text = "Issue Book";
            issueBookBtn.UseVisualStyleBackColor = true;
            issueBookBtn.Click += issueBookBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1, 318);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1123, 55);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Manage_Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1124, 639);
            Controls.Add(pictureBox1);
            Controls.Add(issueBookBtn);
            Controls.Add(removeBookBtn);
            Controls.Add(addBookBtn);
            Controls.Add(bookIsbnTxt);
            Controls.Add(bookAuthorTxt);
            Controls.Add(bookTitleTxt);
            Controls.Add(bookIdTxt);
            Controls.Add(bookIsbnLabel);
            Controls.Add(bookAuthorLabel);
            Controls.Add(bookTitleLabel);
            Controls.Add(BookIdLabel);
            Controls.Add(existingBooksRBtn);
            Controls.Add(availableBooksRBtn);
            Controls.Add(dataGridViewBooks);
            Name = "Manage_Books";
            Text = "Manage_Books";
            Load += Manage_Books_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBooks;
        private RadioButton availableBooksRBtn;
        private RadioButton existingBooksRBtn;
        private Label BookIdLabel;
        private Label bookTitleLabel;
        private Label bookAuthorLabel;
        private Label bookIsbnLabel;
        private TextBox bookIdTxt;
        private TextBox bookTitleTxt;
        private TextBox bookAuthorTxt;
        private TextBox bookIsbnTxt;
        private Button addBookBtn;
        private Button removeBookBtn;
        private Button issueBookBtn;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isAvailableDataGridViewCheckBoxColumn;
        private BindingSource bookBindingSource;
    }
}