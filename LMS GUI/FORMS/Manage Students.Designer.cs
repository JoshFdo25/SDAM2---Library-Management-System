namespace LMS_GUI
{
    partial class Manage_Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Students));
            studentIdLabel = new Label();
            studentNameLabel = new Label();
            studentDepartmentLabel = new Label();
            studentYearLabel = new Label();
            studentIdTxt = new TextBox();
            studentNameTxt = new TextBox();
            studentDepartmentTxt = new TextBox();
            studentYearTxt = new TextBox();
            dataGridViewStudents = new DataGridView();
            studentIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departmentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            addStudentBtn = new Button();
            removeStudentBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // studentIdLabel
            // 
            studentIdLabel.AutoSize = true;
            studentIdLabel.BackColor = Color.Transparent;
            studentIdLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            studentIdLabel.Location = new Point(12, 50);
            studentIdLabel.Name = "studentIdLabel";
            studentIdLabel.Size = new Size(104, 28);
            studentIdLabel.TabIndex = 0;
            studentIdLabel.Text = "Student ID";
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.BackColor = Color.Transparent;
            studentNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            studentNameLabel.Location = new Point(12, 88);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new Size(137, 28);
            studentNameLabel.TabIndex = 1;
            studentNameLabel.Text = "Student Name";
            // 
            // studentDepartmentLabel
            // 
            studentDepartmentLabel.AutoSize = true;
            studentDepartmentLabel.BackColor = Color.Transparent;
            studentDepartmentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            studentDepartmentLabel.Location = new Point(12, 126);
            studentDepartmentLabel.Name = "studentDepartmentLabel";
            studentDepartmentLabel.Size = new Size(117, 28);
            studentDepartmentLabel.TabIndex = 2;
            studentDepartmentLabel.Text = "Department";
            // 
            // studentYearLabel
            // 
            studentYearLabel.AutoSize = true;
            studentYearLabel.BackColor = Color.Transparent;
            studentYearLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            studentYearLabel.Location = new Point(12, 164);
            studentYearLabel.Name = "studentYearLabel";
            studentYearLabel.Size = new Size(48, 28);
            studentYearLabel.TabIndex = 3;
            studentYearLabel.Text = "Year";
            // 
            // studentIdTxt
            // 
            studentIdTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            studentIdTxt.Location = new Point(155, 44);
            studentIdTxt.Name = "studentIdTxt";
            studentIdTxt.PlaceholderText = "Enter Student ID";
            studentIdTxt.Size = new Size(249, 34);
            studentIdTxt.TabIndex = 4;
            // 
            // studentNameTxt
            // 
            studentNameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            studentNameTxt.Location = new Point(155, 82);
            studentNameTxt.Name = "studentNameTxt";
            studentNameTxt.PlaceholderText = "Enter Student Name";
            studentNameTxt.Size = new Size(249, 34);
            studentNameTxt.TabIndex = 5;
            // 
            // studentDepartmentTxt
            // 
            studentDepartmentTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            studentDepartmentTxt.Location = new Point(155, 120);
            studentDepartmentTxt.Name = "studentDepartmentTxt";
            studentDepartmentTxt.PlaceholderText = "Enter Student Department";
            studentDepartmentTxt.Size = new Size(249, 34);
            studentDepartmentTxt.TabIndex = 6;
            // 
            // studentYearTxt
            // 
            studentYearTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            studentYearTxt.Location = new Point(155, 158);
            studentYearTxt.Name = "studentYearTxt";
            studentYearTxt.PlaceholderText = "Enter Course Year";
            studentYearTxt.Size = new Size(249, 34);
            studentYearTxt.TabIndex = 7;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AutoGenerateColumns = false;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Columns.AddRange(new DataGridViewColumn[] { studentIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, departmentDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn });
            dataGridViewStudents.DataSource = studentBindingSource;
            dataGridViewStudents.Location = new Point(12, 232);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.RowTemplate.Height = 29;
            dataGridViewStudents.Size = new Size(813, 296);
            dataGridViewStudents.TabIndex = 8;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            studentIDDataGridViewTextBoxColumn.Width = 125;
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
            // addStudentBtn
            // 
            addStudentBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            addStudentBtn.Location = new Point(513, 82);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(181, 34);
            addStudentBtn.TabIndex = 9;
            addStudentBtn.Text = "Add Student";
            addStudentBtn.UseVisualStyleBackColor = true;
            addStudentBtn.Click += addStudentBtn_Click;
            // 
            // removeStudentBtn
            // 
            removeStudentBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            removeStudentBtn.Location = new Point(513, 126);
            removeStudentBtn.Name = "removeStudentBtn";
            removeStudentBtn.Size = new Size(181, 37);
            removeStudentBtn.TabIndex = 10;
            removeStudentBtn.Text = "Remove Student";
            removeStudentBtn.UseVisualStyleBackColor = true;
            removeStudentBtn.Click += removeStudentBtn_Click;
            // 
            // Manage_Students
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(837, 540);
            Controls.Add(removeStudentBtn);
            Controls.Add(addStudentBtn);
            Controls.Add(dataGridViewStudents);
            Controls.Add(studentYearTxt);
            Controls.Add(studentDepartmentTxt);
            Controls.Add(studentNameTxt);
            Controls.Add(studentIdTxt);
            Controls.Add(studentYearLabel);
            Controls.Add(studentDepartmentLabel);
            Controls.Add(studentNameLabel);
            Controls.Add(studentIdLabel);
            Name = "Manage_Students";
            Text = "Manage_Students";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label studentIdLabel;
        private Label studentNameLabel;
        private Label studentDepartmentLabel;
        private Label studentYearLabel;
        private TextBox studentIdTxt;
        private TextBox studentNameTxt;
        private TextBox studentDepartmentTxt;
        private TextBox studentYearTxt;
        private DataGridView dataGridViewStudents;
        private Button addStudentBtn;
        private Button removeStudentBtn;
        private DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private BindingSource studentBindingSource;
    }
}