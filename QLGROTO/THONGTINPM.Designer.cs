namespace QLGROTO
{
    partial class THONGTINPM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THONGTINPM));
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            thoatbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 6);
            label1.Name = "label1";
            label1.Size = new Size(462, 38);
            label1.TabIndex = 0;
            label1.Text = "PHẦN MỀM QUẢN LÝ GARA Ô TÔ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 56);
            label2.Name = "label2";
            label2.Size = new Size(295, 20);
            label2.TabIndex = 1;
            label2.Text = "© 2024 Nhóm PHD -LT windows 22DTHD4 ";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 89);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 1;
            label4.Text = "Mọi quyền được bảo lưu";
            // 
            // thoatbtn
            // 
            thoatbtn.Location = new Point(464, 120);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(94, 29);
            thoatbtn.TabIndex = 2;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = true;
            thoatbtn.Click += button1_Click;
            // 
            // THONGTINPM
            // 
            AcceptButton = thoatbtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(570, 161);
            Controls.Add(thoatbtn);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "THONGTINPM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin phần mềm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Button thoatbtn;
    }
}