namespace QuanLiPhongKhamNhaKhoa_New
{
    partial class QuenMatKhau
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonThayDoi = new System.Windows.Forms.Button();
            this.textBoxThayDoiMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonXacNhan = new System.Windows.Forms.Button();
            this.textBoxXacNhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGuiMail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonThayDoi);
            this.panel1.Controls.Add(this.textBoxThayDoiMK);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonXacNhan);
            this.panel1.Controls.Add(this.textBoxXacNhan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonGuiMail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 572);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 84);
            this.panel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(86, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quên mật khẩu";
            // 
            // buttonThayDoi
            // 
            this.buttonThayDoi.Image = global::QuanLiPhongKhamNhaKhoa_New.Properties.Resources.icons8_change_64;
            this.buttonThayDoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThayDoi.Location = new System.Drawing.Point(123, 409);
            this.buttonThayDoi.Name = "buttonThayDoi";
            this.buttonThayDoi.Size = new System.Drawing.Size(164, 109);
            this.buttonThayDoi.TabIndex = 8;
            this.buttonThayDoi.Text = "Thay đổi";
            this.buttonThayDoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThayDoi.UseVisualStyleBackColor = true;
            this.buttonThayDoi.Click += new System.EventHandler(this.buttonThayDoi_Click);
            // 
            // textBoxThayDoiMK
            // 
            this.textBoxThayDoiMK.Location = new System.Drawing.Point(139, 377);
            this.textBoxThayDoiMK.Name = "textBoxThayDoiMK";
            this.textBoxThayDoiMK.Size = new System.Drawing.Size(205, 26);
            this.textBoxThayDoiMK.TabIndex = 7;
            this.textBoxThayDoiMK.KeyDown += txtThayDoiMK_KeyDown;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu mới";
            // 
            // buttonXacNhan
            // 
            this.buttonXacNhan.Image = global::QuanLiPhongKhamNhaKhoa_New.Properties.Resources.icons8_confirm_64;
            this.buttonXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXacNhan.Location = new System.Drawing.Point(123, 261);
            this.buttonXacNhan.Name = "buttonXacNhan";
            this.buttonXacNhan.Size = new System.Drawing.Size(164, 110);
            this.buttonXacNhan.TabIndex = 5;
            this.buttonXacNhan.Text = "Xác nhận";
            this.buttonXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonXacNhan.UseVisualStyleBackColor = true;
            this.buttonXacNhan.Click += new System.EventHandler(this.buttonXacNhan_Click);
            // 
            // textBoxXacNhan
            // 
            this.textBoxXacNhan.Location = new System.Drawing.Point(123, 229);
            this.textBoxXacNhan.Name = "textBoxXacNhan";
            this.textBoxXacNhan.Size = new System.Drawing.Size(222, 26);
            this.textBoxXacNhan.TabIndex = 4;
            this.textBoxXacNhan.KeyDown += txtMaXacNhan_KeyDown;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã xác nhận";
            // 
            // buttonGuiMail
            // 
            this.buttonGuiMail.Image = global::QuanLiPhongKhamNhaKhoa_New.Properties.Resources.icons8_send_email_48;
            this.buttonGuiMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuiMail.Location = new System.Drawing.Point(123, 122);
            this.buttonGuiMail.Name = "buttonGuiMail";
            this.buttonGuiMail.Size = new System.Drawing.Size(164, 101);
            this.buttonGuiMail.TabIndex = 2;
            this.buttonGuiMail.Text = "Gửi email";
            this.buttonGuiMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuiMail.UseVisualStyleBackColor = true;
            this.buttonGuiMail.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(106, 90);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(239, 26);
            this.textBoxEmail.TabIndex = 0;
            this.textBoxEmail.KeyDown += txtEmail_KeyDown;
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 572);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuenMatKhau";
            this.Text = "QuenMatKhau";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGuiMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonXacNhan;
        private System.Windows.Forms.TextBox textBoxXacNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonThayDoi;
        private System.Windows.Forms.TextBox textBoxThayDoiMK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}