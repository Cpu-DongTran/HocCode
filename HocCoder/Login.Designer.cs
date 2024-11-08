namespace HocCoder
{
    partial class Login
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
            TxtKey = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // TxtKey
            // 
            TxtKey.Location = new Point(31, 36);
            TxtKey.Multiline = true;
            TxtKey.Name = "TxtKey";
            TxtKey.Size = new Size(455, 221);
            TxtKey.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(334, 280);
            button1.Name = "button1";
            button1.Size = new Size(74, 39);
            button1.TabIndex = 1;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(414, 280);
            button2.Name = "button2";
            button2.Size = new Size(72, 39);
            button2.TabIndex = 2;
            button2.Text = "Get Key";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 339);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TxtKey);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtKey;
        private Button button1;
        private Button button2;
    }
}