namespace LMS_GUI
{
    partial class Mainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainmenu));
            lmsLabel = new Label();
            pictureBox1 = new PictureBox();
            manageBooksBtn = new Button();
            button1 = new Button();
            manageStudentsBtn = new Button();
            closeAppBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lmsLabel
            // 
            lmsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lmsLabel.AutoSize = true;
            lmsLabel.BackColor = Color.Transparent;
            lmsLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lmsLabel.Location = new Point(157, 33);
            lmsLabel.Name = "lmsLabel";
            lmsLabel.Size = new Size(520, 50);
            lmsLabel.TabIndex = 0;
            lmsLabel.Text = "Library Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(219, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(582, 336);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // manageBooksBtn
            // 
            manageBooksBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            manageBooksBtn.Location = new Point(12, 143);
            manageBooksBtn.Name = "manageBooksBtn";
            manageBooksBtn.Size = new Size(201, 68);
            manageBooksBtn.TabIndex = 2;
            manageBooksBtn.Text = "Manage Books";
            manageBooksBtn.UseVisualStyleBackColor = true;
            manageBooksBtn.Click += manageBooksBtn_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 291);
            button1.Name = "button1";
            button1.Size = new Size(201, 68);
            button1.TabIndex = 6;
            button1.Text = "Transcation History";
            button1.UseVisualStyleBackColor = true;
            button1.Click += transactionHistoryBtn;
            // 
            // manageStudentsBtn
            // 
            manageStudentsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            manageStudentsBtn.Location = new Point(12, 217);
            manageStudentsBtn.Name = "manageStudentsBtn";
            manageStudentsBtn.Size = new Size(201, 68);
            manageStudentsBtn.TabIndex = 7;
            manageStudentsBtn.Text = "Manage Students";
            manageStudentsBtn.UseVisualStyleBackColor = true;
            manageStudentsBtn.Click += manageStudentsBtn_Click;
            // 
            // closeAppBtn
            // 
            closeAppBtn.BackColor = Color.IndianRed;
            closeAppBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            closeAppBtn.Location = new Point(12, 365);
            closeAppBtn.Name = "closeAppBtn";
            closeAppBtn.Size = new Size(201, 68);
            closeAppBtn.TabIndex = 8;
            closeAppBtn.Text = "Close Application";
            closeAppBtn.UseVisualStyleBackColor = false;
            closeAppBtn.Click += closeAppBtn_Click;
            // 
            // Mainmenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(closeAppBtn);
            Controls.Add(manageStudentsBtn);
            Controls.Add(button1);
            Controls.Add(manageBooksBtn);
            Controls.Add(pictureBox1);
            Controls.Add(lmsLabel);
            Name = "Mainmenu";
            Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lmsLabel;
        private PictureBox pictureBox1;
        private Button manageBooksBtn;
        private Button button1;
        private Button manageStudentsBtn;
        private Button closeAppBtn;
    }
}