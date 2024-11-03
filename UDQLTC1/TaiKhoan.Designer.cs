namespace UDQLTC
{
    partial class TaiKhoan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bttThongKe = new System.Windows.Forms.Button();
            this.bttMucTieu = new System.Windows.Forms.Button();
            this.bttKhoanchi = new System.Windows.Forms.Button();
            this.bttKhoanThu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bttThongKe);
            this.panel1.Controls.Add(this.bttMucTieu);
            this.panel1.Controls.Add(this.bttKhoanchi);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 579);
            this.panel1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nhập khoản thu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bttThongKe
            // 
            this.bttThongKe.Location = new System.Drawing.Point(74, 366);
            this.bttThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.bttThongKe.Name = "bttThongKe";
            this.bttThongKe.Size = new System.Drawing.Size(184, 50);
            this.bttThongKe.TabIndex = 1;
            this.bttThongKe.Text = "Báo cáo & Thống kê";
            this.bttThongKe.UseVisualStyleBackColor = true;
            this.bttThongKe.Click += new System.EventHandler(this.button4_Click);
            // 
            // bttMucTieu
            // 
            this.bttMucTieu.Location = new System.Drawing.Point(74, 258);
            this.bttMucTieu.Margin = new System.Windows.Forms.Padding(2);
            this.bttMucTieu.Name = "bttMucTieu";
            this.bttMucTieu.Size = new System.Drawing.Size(184, 50);
            this.bttMucTieu.TabIndex = 1;
            this.bttMucTieu.Text = "Mục tiêu";
            this.bttMucTieu.UseVisualStyleBackColor = true;
            this.bttMucTieu.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttKhoanchi
            // 
            this.bttKhoanchi.Location = new System.Drawing.Point(74, 48);
            this.bttKhoanchi.Margin = new System.Windows.Forms.Padding(2);
            this.bttKhoanchi.Name = "bttKhoanchi";
            this.bttKhoanchi.Size = new System.Drawing.Size(184, 49);
            this.bttKhoanchi.TabIndex = 0;
            this.bttKhoanchi.Text = "Nhập khoản chi";
            this.bttKhoanchi.UseVisualStyleBackColor = true;
            this.bttKhoanchi.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttKhoanThu
            // 
            this.bttKhoanThu.Location = new System.Drawing.Point(2, 568);
            this.bttKhoanThu.Margin = new System.Windows.Forms.Padding(2);
            this.bttKhoanThu.Name = "bttKhoanThu";
            this.bttKhoanThu.Size = new System.Drawing.Size(11, 12);
            this.bttKhoanThu.TabIndex = 1;
            this.bttKhoanThu.UseVisualStyleBackColor = true;
            this.bttKhoanThu.Click += new System.EventHandler(this.button3_Click);
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1050, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttKhoanThu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaiKhoan";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaiKhoan_FormClosing);
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttKhoanThu;
        private System.Windows.Forms.Button bttThongKe;
        private System.Windows.Forms.Button bttMucTieu;
        private System.Windows.Forms.Button bttKhoanchi;
        private System.Windows.Forms.Button button1;
    }
}