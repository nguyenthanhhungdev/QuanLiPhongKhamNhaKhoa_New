﻿namespace QuanLiPhongKhamNhaKhoa_New
{
    partial class ThayDoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxXacNhan = new System.Windows.Forms.TextBox();
            this.buttonXacNhan = new System.Windows.Forms.Button();
            this.textBoxThayDoiMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonThayDoiMK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 108);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thay đổi mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã xác nhận";
            // 
            // textBoxXacNhan
            // 
            this.textBoxXacNhan.Location = new System.Drawing.Point(261, 176);
            this.textBoxXacNhan.Name = "textBoxXacNhan";
            this.textBoxXacNhan.Size = new System.Drawing.Size(297, 26);
            this.textBoxXacNhan.TabIndex = 2;
            this.textBoxXacNhan.KeyDown += txtMaXacNhan_KeyDown;
            // 
            // buttonXacNhan
            // 
            this.buttonXacNhan.Image = global::QuanLiPhongKhamNhaKhoa_New.Properties.Resources.icons8_confirm_64;
            this.buttonXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXacNhan.Location = new System.Drawing.Point(261, 230);
            this.buttonXacNhan.Name = "buttonXacNhan";
            this.buttonXacNhan.Size = new System.Drawing.Size(252, 119);
            this.buttonXacNhan.TabIndex = 3;
            this.buttonXacNhan.Text = "Xác nhận";
            this.buttonXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonXacNhan.UseVisualStyleBackColor = true;
            this.buttonXacNhan.Click += buttonXacNhan_Click;
            // 
            // textBoxThayDoiMK
            // 
            this.textBoxThayDoiMK.Location = new System.Drawing.Point(261, 414);
            this.textBoxThayDoiMK.Name = "textBoxThayDoiMK";
            this.textBoxThayDoiMK.Size = new System.Drawing.Size(297, 26);
            this.textBoxThayDoiMK.TabIndex = 4;
            this.textBoxThayDoiMK.KeyDown += txtThayDoiMK_KeyDown;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu mới";
            // 
            // buttonThayDoiMK
            // 
            this.buttonThayDoiMK.Image = global::QuanLiPhongKhamNhaKhoa_New.Properties.Resources.icons8_change_64;
            this.buttonThayDoiMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThayDoiMK.Location = new System.Drawing.Point(261, 466);
            this.buttonThayDoiMK.Name = "buttonThayDoiMK";
            this.buttonThayDoiMK.Size = new System.Drawing.Size(252, 113);
            this.buttonThayDoiMK.TabIndex = 6;
            this.buttonThayDoiMK.Text = "Thay đổi";
            this.buttonThayDoiMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThayDoiMK.UseVisualStyleBackColor = true;
            this.buttonThayDoiMK.Click += buttonThayDoi_Click;
            // 
            // ThayDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.buttonThayDoiMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxThayDoiMK);
            this.Controls.Add(this.buttonXacNhan);
            this.Controls.Add(this.textBoxXacNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ThayDoiMatKhau";
            this.Text = "ThayDoiMatKhau";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxXacNhan;
        private System.Windows.Forms.Button buttonXacNhan;
        private System.Windows.Forms.TextBox textBoxThayDoiMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonThayDoiMK;
    }
}