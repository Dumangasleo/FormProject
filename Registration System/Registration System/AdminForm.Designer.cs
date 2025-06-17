namespace Registration_System
{
    partial class SmajorCombox
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
            SyearLvLCombox = new ComboBox();
            SprogramCombox = new ComboBox();
            comboBox3 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SaveBut = new Button();
            CancelBut = new Button();
            StudentRadBut = new RadioButton();
            TeacherRadBut = new RadioButton();
            SuspendLayout();
            // 
            // SyearLvLCombox
            // 
            SyearLvLCombox.AutoCompleteCustomSource.AddRange(new string[] { "FIRST YEAR", "SECOND YEAR", "THIRD YEAR", "FOURTH YEAR" });
            SyearLvLCombox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SyearLvLCombox.AutoCompleteSource = AutoCompleteSource.ListItems;
            SyearLvLCombox.BackColor = Color.FromArgb(230, 231, 233);
            SyearLvLCombox.FlatStyle = FlatStyle.Flat;
            SyearLvLCombox.FormattingEnabled = true;
            SyearLvLCombox.Location = new Point(46, 186);
            SyearLvLCombox.Margin = new Padding(3, 2, 3, 2);
            SyearLvLCombox.Name = "SyearLvLCombox";
            SyearLvLCombox.Size = new Size(190, 23);
            SyearLvLCombox.TabIndex = 0;
            // 
            // SprogramCombox
            // 
            SprogramCombox.AutoCompleteCustomSource.AddRange(new string[] { "BACHELOR OF ELEMENTARY EDUCATION", "BACHELOR OF SCIENCE IN ACCOUNTANCY", "BACHELOR OF SCIENCE IN CIVIL ENGINEERING", "BACHELOR OF SCIENCE IN COMPUTER SCIENCE", "BACHELOR OF SCIENCE IN CRIMINOLOGY", "BACHELOR OF SCIENCE IN NURSING", "BACHELOR OF SECONDARY EDUCATION" });
            SprogramCombox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SprogramCombox.AutoCompleteSource = AutoCompleteSource.ListItems;
            SprogramCombox.BackColor = Color.FromArgb(230, 231, 233);
            SprogramCombox.FlatStyle = FlatStyle.Flat;
            SprogramCombox.FormattingEnabled = true;
            SprogramCombox.Location = new Point(46, 248);
            SprogramCombox.Margin = new Padding(3, 2, 3, 2);
            SprogramCombox.Name = "SprogramCombox";
            SprogramCombox.Size = new Size(190, 23);
            SprogramCombox.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteCustomSource.AddRange(new string[] { "MAJOR IN IRRIGATION", "MAJOR IN STRUCTURAL", "MAJOR IN TRANSPORTATION" });
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox3.BackColor = Color.FromArgb(230, 231, 233);
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(46, 307);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(190, 23);
            comboBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(164, 165, 169);
            label1.Location = new Point(46, 171);
            label1.Name = "label1";
            label1.Size = new Size(109, 13);
            label1.TabIndex = 3;
            label1.Text = "SELECT YEAR LEVEL";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(164, 165, 169);
            label2.Location = new Point(46, 232);
            label2.Name = "label2";
            label2.Size = new Size(103, 13);
            label2.TabIndex = 4;
            label2.Text = "SELECT PROGRAM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(164, 165, 169);
            label3.Location = new Point(46, 292);
            label3.Name = "label3";
            label3.Size = new Size(87, 13);
            label3.TabIndex = 5;
            label3.Text = "SELECT MAJOR";
            // 
            // SaveBut
            // 
            SaveBut.BackColor = Color.FromArgb(116, 86, 174);
            SaveBut.Cursor = Cursors.Hand;
            SaveBut.FlatAppearance.BorderSize = 0;
            SaveBut.FlatStyle = FlatStyle.Flat;
            SaveBut.ForeColor = Color.White;
            SaveBut.Location = new Point(46, 353);
            SaveBut.Margin = new Padding(3, 2, 3, 2);
            SaveBut.Name = "SaveBut";
            SaveBut.Size = new Size(189, 26);
            SaveBut.TabIndex = 20;
            SaveBut.Text = "SAVE";
            SaveBut.UseVisualStyleBackColor = false;
            // 
            // CancelBut
            // 
            CancelBut.BackColor = Color.White;
            CancelBut.Cursor = Cursors.Hand;
            CancelBut.FlatStyle = FlatStyle.Flat;
            CancelBut.ForeColor = Color.FromArgb(116, 86, 174);
            CancelBut.Location = new Point(46, 384);
            CancelBut.Margin = new Padding(3, 2, 3, 2);
            CancelBut.Name = "CancelBut";
            CancelBut.Size = new Size(189, 26);
            CancelBut.TabIndex = 21;
            CancelBut.Text = "CANCEL";
            CancelBut.UseVisualStyleBackColor = false;
            // 
            // StudentRadBut
            // 
            StudentRadBut.AutoSize = true;
            StudentRadBut.FlatStyle = FlatStyle.Flat;
            StudentRadBut.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentRadBut.ForeColor = Color.FromArgb(164, 165, 169);
            StudentRadBut.Location = new Point(46, 120);
            StudentRadBut.Margin = new Padding(3, 2, 3, 2);
            StudentRadBut.Name = "StudentRadBut";
            StudentRadBut.Size = new Size(73, 17);
            StudentRadBut.TabIndex = 22;
            StudentRadBut.TabStop = true;
            StudentRadBut.Text = "STUDENT";
            StudentRadBut.UseVisualStyleBackColor = true;
            // 
            // TeacherRadBut
            // 
            TeacherRadBut.AutoSize = true;
            TeacherRadBut.FlatStyle = FlatStyle.Flat;
            TeacherRadBut.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeacherRadBut.ForeColor = Color.FromArgb(164, 165, 169);
            TeacherRadBut.Location = new Point(46, 141);
            TeacherRadBut.Margin = new Padding(3, 2, 3, 2);
            TeacherRadBut.Name = "TeacherRadBut";
            TeacherRadBut.Size = new Size(72, 17);
            TeacherRadBut.TabIndex = 23;
            TeacherRadBut.TabStop = true;
            TeacherRadBut.Text = "TEACHER";
            TeacherRadBut.UseVisualStyleBackColor = true;
            // 
            // SmajorCombox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(280, 530);
            Controls.Add(TeacherRadBut);
            Controls.Add(StudentRadBut);
            Controls.Add(CancelBut);
            Controls.Add(SaveBut);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox3);
            Controls.Add(SprogramCombox);
            Controls.Add(SyearLvLCombox);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SmajorCombox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox SyearLvLCombox;
        private ComboBox SprogramCombox;
        private ComboBox comboBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button SaveBut;
        private Button CancelBut;
        private RadioButton StudentRadBut;
        private RadioButton TeacherRadBut;
    }
}