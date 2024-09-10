namespace LMS_GUI
{
    partial class Issue_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Issue_Book));
            studentIdLabel = new Label();
            studentIdTxt = new TextBox();
            dataGridViewStudentIssue = new DataGridView();
            transactionIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateIssuedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionBindingSource = new BindingSource(components);
            issueBookBtn = new Button();
            bookIdTxt = new TextBox();
            bookIdLabel = new Label();
            dataGridViewStudentIssue2 = new DataGridView();
            studentIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departmentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentIssue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentIssue2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // studentIdLabel
            // 
            studentIdLabel.Anchor = AnchorStyles.None;
            studentIdLabel.AutoSize = true;
            studentIdLabel.BackColor = Color.Transparent;
            studentIdLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            studentIdLabel.Location = new Point(541, 369);
            studentIdLabel.Name = "studentIdLabel";
            studentIdLabel.Size = new Size(104, 28);
            studentIdLabel.TabIndex = 0;
            studentIdLabel.Text = "Student ID";
            // 
            // studentIdTxt
            // 
            studentIdTxt.Anchor = AnchorStyles.None;
            studentIdTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            studentIdTxt.Location = new Point(665, 366);
            studentIdTxt.Name = "studentIdTxt";
            studentIdTxt.Size = new Size(216, 34);
            studentIdTxt.TabIndex = 2;
            // 
            // dataGridViewStudentIssue
            // 
            dataGridViewStudentIssue.Anchor = AnchorStyles.None;
            dataGridViewStudentIssue.AutoGenerateColumns = false;
            dataGridViewStudentIssue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudentIssue.Columns.AddRange(new DataGridViewColumn[] { transactionIDDataGridViewTextBoxColumn, studentIDDataGridViewTextBoxColumn, bookIDDataGridViewTextBoxColumn, dateIssuedDataGridViewTextBoxColumn });
            dataGridViewStudentIssue.DataSource = transactionBindingSource;
            dataGridViewStudentIssue.Location = new Point(23, 25);
            dataGridViewStudentIssue.Name = "dataGridViewStudentIssue";
            dataGridViewStudentIssue.RowHeadersWidth = 51;
            dataGridViewStudentIssue.RowTemplate.Height = 29;
            dataGridViewStudentIssue.Size = new Size(776, 258);
            dataGridViewStudentIssue.TabIndex = 4;
            // 
            // transactionIDDataGridViewTextBoxColumn
            // 
            transactionIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionID";
            transactionIDDataGridViewTextBoxColumn.HeaderText = "TransactionID";
            transactionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            transactionIDDataGridViewTextBoxColumn.Name = "transactionIDDataGridViewTextBoxColumn";
            transactionIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            bookIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            bookIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateIssuedDataGridViewTextBoxColumn
            // 
            dateIssuedDataGridViewTextBoxColumn.DataPropertyName = "DateIssued";
            dateIssuedDataGridViewTextBoxColumn.HeaderText = "DateIssued";
            dateIssuedDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateIssuedDataGridViewTextBoxColumn.Name = "dateIssuedDataGridViewTextBoxColumn";
            dateIssuedDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(Transaction);
            // 
            // issueBookBtn
            // 
            issueBookBtn.Anchor = AnchorStyles.None;
            issueBookBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            issueBookBtn.Location = new Point(656, 505);
            issueBookBtn.Name = "issueBookBtn";
            issueBookBtn.Size = new Size(153, 44);
            issueBookBtn.TabIndex = 5;
            issueBookBtn.Text = "Issue Book";
            issueBookBtn.UseVisualStyleBackColor = true;
            issueBookBtn.Click += issueBookBtn_Click;
            // 
            // bookIdTxt
            // 
            bookIdTxt.Anchor = AnchorStyles.None;
            bookIdTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookIdTxt.Location = new Point(665, 415);
            bookIdTxt.Name = "bookIdTxt";
            bookIdTxt.Size = new Size(216, 34);
            bookIdTxt.TabIndex = 7;
            // 
            // bookIdLabel
            // 
            bookIdLabel.Anchor = AnchorStyles.None;
            bookIdLabel.AutoSize = true;
            bookIdLabel.BackColor = Color.Transparent;
            bookIdLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookIdLabel.Location = new Point(541, 418);
            bookIdLabel.Name = "bookIdLabel";
            bookIdLabel.Size = new Size(81, 28);
            bookIdLabel.TabIndex = 6;
            bookIdLabel.Text = "Book ID";
            // 
            // dataGridViewStudentIssue2
            // 
            dataGridViewStudentIssue2.Anchor = AnchorStyles.None;
            dataGridViewStudentIssue2.AutoGenerateColumns = false;
            dataGridViewStudentIssue2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudentIssue2.Columns.AddRange(new DataGridViewColumn[] { studentIDDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn, departmentDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn });
            dataGridViewStudentIssue2.DataSource = studentBindingSource;
            dataGridViewStudentIssue2.Location = new Point(832, 25);
            dataGridViewStudentIssue2.Name = "dataGridViewStudentIssue2";
            dataGridViewStudentIssue2.RowHeadersWidth = 51;
            dataGridViewStudentIssue2.RowTemplate.Height = 29;
            dataGridViewStudentIssue2.Size = new Size(553, 258);
            dataGridViewStudentIssue2.TabIndex = 8;
            // 
            // studentIDDataGridViewTextBoxColumn1
            // 
            studentIDDataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            studentIDDataGridViewTextBoxColumn1.HeaderText = "StudentID";
            studentIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            studentIDDataGridViewTextBoxColumn1.Name = "studentIDDataGridViewTextBoxColumn1";
            studentIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            departmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            yearDataGridViewTextBoxColumn.HeaderText = "Year";
            yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Student);
            // 
            // Issue_Book
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1423, 636);
            Controls.Add(dataGridViewStudentIssue2);
            Controls.Add(bookIdTxt);
            Controls.Add(bookIdLabel);
            Controls.Add(issueBookBtn);
            Controls.Add(dataGridViewStudentIssue);
            Controls.Add(studentIdTxt);
            Controls.Add(studentIdLabel);
            Name = "Issue_Book";
            Text = "Issue_Book";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentIssue).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentIssue2).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label studentIdLabel;
        private TextBox studentIdTxt;
        private DataGridView dataGridViewStudentIssue;
        private Button issueBookBtn;
        private DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateIssuedDataGridViewTextBoxColumn;
        private BindingSource transactionBindingSource;
        private TextBox bookIdTxt;
        private Label bookIdLabel;
        private DataGridView dataGridViewStudentIssue2;
        private DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private BindingSource studentBindingSource;
    }
}