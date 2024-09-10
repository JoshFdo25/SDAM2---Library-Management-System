namespace LMS_GUI
{
    partial class Transaction_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction_History));
            dataGridViewTransactions = new DataGridView();
            transactionIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateIssuedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.AutoGenerateColumns = false;
            dataGridViewTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactions.Columns.AddRange(new DataGridViewColumn[] { transactionIDDataGridViewTextBoxColumn, bookIDDataGridViewTextBoxColumn, studentIDDataGridViewTextBoxColumn, dateIssuedDataGridViewTextBoxColumn });
            dataGridViewTransactions.DataSource = transactionBindingSource;
            dataGridViewTransactions.Location = new Point(12, 12);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.RowHeadersWidth = 51;
            dataGridViewTransactions.RowTemplate.Height = 29;
            dataGridViewTransactions.Size = new Size(776, 329);
            dataGridViewTransactions.TabIndex = 0;
            dataGridViewTransactions.CellContentClick += dataGridView1_CellContentClick;
            // 
            // transactionIDDataGridViewTextBoxColumn
            // 
            transactionIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionID";
            transactionIDDataGridViewTextBoxColumn.HeaderText = "TransactionID";
            transactionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            transactionIDDataGridViewTextBoxColumn.Name = "transactionIDDataGridViewTextBoxColumn";
            transactionIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            bookIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            bookIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            studentIDDataGridViewTextBoxColumn.Width = 125;
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
            // Transaction_History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewTransactions);
            Name = "Transaction_History";
            Text = "Transaction_History";
            Load += Transaction_History_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTransactions;
        private DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateIssuedDataGridViewTextBoxColumn;
        private BindingSource transactionBindingSource;
    }
}