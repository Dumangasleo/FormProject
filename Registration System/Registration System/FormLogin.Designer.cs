namespace Registration_System
{
    partial class FormLogin
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
            CreateAccButton = new Label();
            Clearbutton2 = new Button();
            loginButton = new Button();
            checkShowPass = new CheckBox();
            label3 = new Label();
            textPass = new TextBox();
            textUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // CreateAccButton
            // 
            CreateAccButton.AutoSize = true;
            CreateAccButton.BackColor = Color.Transparent;
            CreateAccButton.FlatStyle = FlatStyle.Popup;
            CreateAccButton.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateAccButton.ForeColor = Color.FromArgb(116, 86, 174);
            CreateAccButton.Location = new Point(164, 487);
            CreateAccButton.Name = "CreateAccButton";
            CreateAccButton.Size = new Size(132, 23);
            CreateAccButton.TabIndex = 21;
            CreateAccButton.Text = "Create Account";
            // 
            // Clearbutton2
            // 
            Clearbutton2.BackColor = Color.White;
            Clearbutton2.Cursor = Cursors.Hand;
            Clearbutton2.FlatStyle = FlatStyle.Flat;
            Clearbutton2.ForeColor = Color.FromArgb(116, 86, 174);
            Clearbutton2.Location = new Point(52, 449);
            Clearbutton2.Name = "Clearbutton2";
            Clearbutton2.Size = new Size(216, 35);
            Clearbutton2.TabIndex = 20;
            Clearbutton2.Text = "CLEAR";
            Clearbutton2.UseVisualStyleBackColor = false;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(116, 86, 174);
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(52, 408);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(216, 35);
            loginButton.TabIndex = 19;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // checkShowPass
            // 
            checkShowPass.AutoSize = true;
            checkShowPass.Cursor = Cursors.Hand;
            checkShowPass.FlatStyle = FlatStyle.Flat;
            checkShowPass.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkShowPass.Location = new Point(144, 354);
            checkShowPass.Name = "checkShowPass";
            checkShowPass.Size = new Size(121, 21);
            checkShowPass.TabIndex = 18;
            checkShowPass.Text = "Show Password";
            checkShowPass.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(49, 300);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // textPass
            // 
            textPass.BackColor = Color.FromArgb(230, 231, 233);
            textPass.BorderStyle = BorderStyle.None;
            textPass.Font = new Font("MS Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPass.Location = new Point(49, 320);
            textPass.Multiline = true;
            textPass.Name = "textPass";
            textPass.Size = new Size(216, 28);
            textPass.TabIndex = 14;
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(230, 231, 233);
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Font = new Font("MS Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.Location = new Point(52, 253);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(216, 28);
            textUsername.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(52, 233);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 12;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(79, 184);
            label1.Name = "label1";
            label1.Size = new Size(196, 46);
            label1.TabIndex = 11;
            label1.Text = "Get Started";
            label1.Click += label1_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(313, 669);
            Controls.Add(CreateAccButton);
            Controls.Add(Clearbutton2);
            Controls.Add(loginButton);
            Controls.Add(checkShowPass);
            Controls.Add(label3);
            Controls.Add(textPass);
            Controls.Add(textUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sssss";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateAccButton;
        private Button Clearbutton2;
        private Button loginButton;
        private CheckBox checkShowPass;
        private Label label3;
        private TextBox textPass;
        private TextBox textUsername;
        private Label label2;
        private Label label1;
    }
}