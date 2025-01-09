namespace QLGROTO
{
    partial class LIENHE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LIENHE));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            thoatbtn = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(102, 43);
            label1.Name = "label1";
            label1.Size = new Size(474, 31);
            label1.TabIndex = 0;
            label1.Text = "© 2024 Nhóm PHD -LT windows 22DTHD4 ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(225, 97);
            label2.Name = "label2";
            label2.Size = new Size(189, 23);
            label2.TabIndex = 1;
            label2.Text = "Đội ngũ lập trình viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(68, 139);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 1;
            label3.Text = "Phan Tiến Dũng";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(68, 162);
            label4.Name = "label4";
            label4.Size = new Size(187, 23);
            label4.TabIndex = 1;
            label4.Text = "Đậu Mai Xuân Phương";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(68, 185);
            label5.Name = "label5";
            label5.Size = new Size(120, 23);
            label5.TabIndex = 1;
            label5.Text = "Lê Việt Hoàng";
            // 
            // thoatbtn
            // 
            thoatbtn.Location = new Point(525, 250);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(94, 29);
            thoatbtn.TabIndex = 2;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = true;
            thoatbtn.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(278, 185);
            label6.Name = "label6";
            label6.Size = new Size(198, 23);
            label6.TabIndex = 3;
            label6.Text = "Gmail : hoangle3102004";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(278, 162);
            label7.Name = "label7";
            label7.Size = new Size(318, 23);
            label7.TabIndex = 4;
            label7.Text = "Gmail : xuanphuong221104@gmail.com";
            label7.Click += label7_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(278, 139);
            label8.Name = "label8";
            label8.Size = new Size(282, 23);
            label8.TabIndex = 5;
            label8.Text = "Gmail  : ptiendung644@gmail.com";
            // 
            // LIENHE
            // 
            AcceptButton = thoatbtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(631, 291);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(thoatbtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LIENHE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Liên hệ";
            Load += ContactForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button thoatbtn;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}