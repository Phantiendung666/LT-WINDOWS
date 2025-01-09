﻿namespace QLGROTO
{
    partial class DANGNHAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DANGNHAP));
            TitleLabel = new Label();
            panel1 = new Panel();
            chedokhachbtn = new Button();
            EscapeButton = new Button();
            LogInButtion = new Button();
            pass_txtbox = new TextBox();
            tendangnhap_txtbox = new TextBox();
            PassLabel = new Label();
            UsernameLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.BackColor = Color.DarkGoldenrod;
            TitleLabel.Dock = DockStyle.Top;
            TitleLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.Location = new Point(0, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(498, 38);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "PHẦN MỀM QUẢN LÝ GARA Ô TÔ";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            TitleLabel.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(chedokhachbtn);
            panel1.Controls.Add(EscapeButton);
            panel1.Controls.Add(LogInButtion);
            panel1.Controls.Add(pass_txtbox);
            panel1.Controls.Add(tendangnhap_txtbox);
            panel1.Controls.Add(PassLabel);
            panel1.Controls.Add(UsernameLabel);
            panel1.Location = new Point(0, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 180);
            panel1.TabIndex = 1;
            // 
            // chedokhachbtn
            // 
            chedokhachbtn.AutoSize = true;
            chedokhachbtn.Location = new Point(12, 89);
            chedokhachbtn.Name = "chedokhachbtn";
            chedokhachbtn.Size = new Size(108, 30);
            chedokhachbtn.TabIndex = 5;
            chedokhachbtn.Text = "Chế độ khách";
            chedokhachbtn.UseVisualStyleBackColor = true;
            chedokhachbtn.Click += chedokhachbtn_Click;
            // 
            // EscapeButton
            // 
            EscapeButton.Location = new Point(392, 89);
            EscapeButton.Name = "EscapeButton";
            EscapeButton.Size = new Size(94, 29);
            EscapeButton.TabIndex = 4;
            EscapeButton.Text = "Thoát";
            EscapeButton.UseVisualStyleBackColor = true;
            EscapeButton.Click += escbtn_Click;
            // 
            // LogInButtion
            // 
            LogInButtion.Location = new Point(292, 89);
            LogInButtion.Name = "LogInButtion";
            LogInButtion.Size = new Size(94, 29);
            LogInButtion.TabIndex = 3;
            LogInButtion.Text = "Đăng nhập";
            LogInButtion.UseVisualStyleBackColor = true;
            LogInButtion.Click += lginbtn_Click;
            // 
            // pass_txtbox
            // 
            pass_txtbox.BackColor = SystemColors.HighlightText;
            pass_txtbox.Location = new Point(148, 50);
            pass_txtbox.Name = "pass_txtbox";
            pass_txtbox.Size = new Size(338, 27);
            pass_txtbox.TabIndex = 2;
            pass_txtbox.UseSystemPasswordChar = true;
            // 
            // tendangnhap_txtbox
            // 
            tendangnhap_txtbox.BackColor = SystemColors.HighlightText;
            tendangnhap_txtbox.Location = new Point(148, 15);
            tendangnhap_txtbox.Name = "tendangnhap_txtbox";
            tendangnhap_txtbox.Size = new Size(338, 27);
            tendangnhap_txtbox.TabIndex = 1;
            tendangnhap_txtbox.TextChanged += UsernameTextbox_TextChanged;
            // 
            // PassLabel
            // 
            PassLabel.AutoSize = true;
            PassLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            PassLabel.Location = new Point(44, 49);
            PassLabel.Name = "PassLabel";
            PassLabel.Size = new Size(98, 25);
            PassLabel.TabIndex = 0;
            PassLabel.Text = "Mật khẩu:";
            PassLabel.Click += label2_Click;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameLabel.Location = new Point(3, 14);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(143, 25);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Tên đăng nhập:";
            UsernameLabel.Click += label2_Click;
            // 
            // DANGNHAP
            // 
            AcceptButton = LogInButtion;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = EscapeButton;
            ClientSize = new Size(498, 171);
            Controls.Add(panel1);
            Controls.Add(TitleLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DANGNHAP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += Form1_FormClosing;
            Load += DANGNHAP_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label TitleLabel;
        private Panel panel1;
        private Label UsernameLabel;
        private Button EscapeButton;
        private Button LogInButtion;
        private TextBox pass_txtbox;
        private TextBox tendangnhap_txtbox;
        private Label PassLabel;
        private Button chedokhachbtn;
    }
}