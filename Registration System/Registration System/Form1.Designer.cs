namespace Registration_System
{
    partial class frmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Textcfrmpass = new TextBox();
            checkShowPass = new CheckBox();
            RegButton = new Button();
            ClearButton = new Button();
            AlrdyHvAccButton = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(59, 143);
            label1.Name = "label1";
            label1.Size = new Size(171, 74);
            label1.TabIndex = 0;
            label1.Text = "Create New \r\n   Account";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(33, 231);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(230, 231, 233);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("MS Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(33, 251);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 28);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(230, 231, 233);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("MS Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(33, 251);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 28);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(230, 231, 233);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("MS Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(33, 318);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 28);
            textBox3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(33, 298);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(33, 361);
            label4.Name = "label4";
            label4.Size = new Size(120, 17);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // Textcfrmpass
            // 
            Textcfrmpass.BackColor = Color.FromArgb(230, 231, 233);
            Textcfrmpass.BorderStyle = BorderStyle.None;
            Textcfrmpass.Font = new Font("MS Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Textcfrmpass.Location = new Point(33, 381);
            Textcfrmpass.Multiline = true;
            Textcfrmpass.Name = "Textcfrmpass";
            Textcfrmpass.Size = new Size(216, 28);
            Textcfrmpass.TabIndex = 6;
            // 
            // checkShowPass
            // 
            checkShowPass.AutoSize = true;
            checkShowPass.Cursor = Cursors.Hand;
            checkShowPass.FlatStyle = FlatStyle.Flat;
            checkShowPass.Location = new Point(127, 415);
            checkShowPass.Name = "checkShowPass";
            checkShowPass.Size = new Size(119, 21);
            checkShowPass.TabIndex = 7;
            checkShowPass.Text = "Show Password";
            checkShowPass.UseVisualStyleBackColor = true;
            // 
            // RegButton
            // 
            RegButton.BackColor = Color.FromArgb(116, 86, 174);
            RegButton.Cursor = Cursors.Hand;
            RegButton.FlatAppearance.BorderSize = 0;
            RegButton.FlatStyle = FlatStyle.Flat;
            RegButton.ForeColor = Color.White;
            RegButton.Location = new Point(33, 452);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(216, 35);
            RegButton.TabIndex = 8;
            RegButton.Text = "REGISTER";
            RegButton.UseVisualStyleBackColor = false;
            RegButton.Click += RegButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.White;
            ClearButton.Cursor = Cursors.Hand;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.ForeColor = Color.FromArgb(116, 86, 174);
            ClearButton.Location = new Point(33, 493);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(216, 35);
            ClearButton.TabIndex = 9;
            ClearButton.Text = "CLEAR";
            ClearButton.UseVisualStyleBackColor = false;
            // 
            // AlrdyHvAccButton
            // 
            AlrdyHvAccButton.AutoSize = true;
            AlrdyHvAccButton.BackColor = Color.Transparent;
            AlrdyHvAccButton.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AlrdyHvAccButton.ForeColor = Color.FromArgb(116, 86, 174);
            AlrdyHvAccButton.Location = new Point(127, 531);
            AlrdyHvAccButton.Name = "AlrdyHvAccButton";
            AlrdyHvAccButton.Size = new Size(122, 13);
            AlrdyHvAccButton.TabIndex = 10;
            AlrdyHvAccButton.Text = "Already Have Account";
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(296, 629);
            Controls.Add(AlrdyHvAccButton);
            Controls.Add(ClearButton);
            Controls.Add(RegButton);
            Controls.Add(checkShowPass);
            Controls.Add(Textcfrmpass);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private TextBox Textcfrmpass;
        private CheckBox checkShowPass;
        private Button RegButton;
        private Button ClearButton;
        private Label AlrdyHvAccButton;
    }
}
