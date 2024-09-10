namespace LMS_GUI.FORMS
{
    partial class Select_Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select_Interface));
            cli_Btn = new Button();
            gui_Btn = new Button();
            SuspendLayout();
            // 
            // cli_Btn
            // 
            cli_Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cli_Btn.Location = new Point(585, 200);
            cli_Btn.Name = "cli_Btn";
            cli_Btn.Size = new Size(131, 49);
            cli_Btn.TabIndex = 0;
            cli_Btn.Text = "CLI";
            cli_Btn.UseVisualStyleBackColor = true;
            cli_Btn.Click += cli_Btn_Click;
            // 
            // gui_Btn
            // 
            gui_Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gui_Btn.Location = new Point(585, 274);
            gui_Btn.Name = "gui_Btn";
            gui_Btn.Size = new Size(131, 49);
            gui_Btn.TabIndex = 1;
            gui_Btn.Text = "GUI";
            gui_Btn.UseVisualStyleBackColor = true;
            gui_Btn.Click += gui_Btn_Click;
            // 
            // Select_Interface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(gui_Btn);
            Controls.Add(cli_Btn);
            Name = "Select_Interface";
            Text = "Select_Interface";
            Load += Select_Interface_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button cli_Btn;
        private Button gui_Btn;
    }
}