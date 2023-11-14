using System;
using System.Windows.Forms;

namespace QuanLiPhongKhamNhaKhoa_New
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonQuenMK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxMatKhau = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxHienMatKhau = new System.Windows.Forms.CheckBox();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMa = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.maskedTextBoxMatKhau);
            this.panel1.Controls.Add(this.checkBoxHienMatKhau);
            this.panel1.Controls.Add(this.buttonDangNhap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxMa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.buttonThoat);
            this.panel3.Controls.Add(this.buttonQuenMK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 100);
            this.panel3.TabIndex = 18;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Image = global::QuanLiPhongKhamNhaKhoa_New.Properties.Resources.icons8_cancel_48;
            this.buttonThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThoat.Location = new System.Drawing.Point(12, 3);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(177, 94);
            this.buttonThoat.TabIndex = 18;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThoat.UseVisualStyleBackColor = true;
            // 
            // buttonQuenMK
            // 
            this.buttonQuenMK.Image = global::QuanLiPhongKhamNhaKhoa_New.Properties.Resources.icons8_body_511;
            this.buttonQuenMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuenMK.Location = new System.Drawing.Point(195, 3);
            this.buttonQuenMK.Name = "buttonQuenMK";
            this.buttonQuenMK.Size = new System.Drawing.Size(183, 94);
            this.buttonQuenMK.TabIndex = 17;
            this.buttonQuenMK.Text = "Quên mật khẩu";
            this.buttonQuenMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonQuenMK.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 92);
            this.panel2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 56);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome";
            // 
            // maskedTextBoxMatKhau
            // 
            this.maskedTextBoxMatKhau.Location = new System.Drawing.Point(112, 147);
            this.maskedTextBoxMatKhau.Name = "maskedTextBoxMatKhau";
            this.maskedTextBoxMatKhau.PasswordChar = '*';
            this.maskedTextBoxMatKhau.Size = new System.Drawing.Size(238, 26);
            this.maskedTextBoxMatKhau.TabIndex = 14;
            this.maskedTextBoxMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // checkBoxHienMatKhau
            // 
            this.checkBoxHienMatKhau.AutoSize = true;
            this.checkBoxHienMatKhau.Location = new System.Drawing.Point(12, 179);
            this.checkBoxHienMatKhau.Name = "checkBoxHienMatKhau";
            this.checkBoxHienMatKhau.Size = new System.Drawing.Size(138, 24);
            this.checkBoxHienMatKhau.TabIndex = 13;
            this.checkBoxHienMatKhau.Text = "Hiện mật khẩu";
            this.checkBoxHienMatKhau.UseVisualStyleBackColor = true;
            this.checkBoxHienMatKhau.CheckedChanged += new System.EventHandler(this.checkBoxHienMatKhau_CheckedChanged);
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Image = global::QuanLiPhongKhamNhaKhoa_New.Properties.Resources.icons8_login_50;
            this.buttonDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDangNhap.Location = new System.Drawing.Point(190, 209);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(188, 68);
            this.buttonDangNhap.TabIndex = 11;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã";
            // 
            // textBoxMa
            // 
            this.textBoxMa.Location = new System.Drawing.Point(112, 98);
            this.textBoxMa.Name = "textBoxMa";
            this.textBoxMa.Size = new System.Drawing.Size(238, 26);
            this.textBoxMa.TabIndex = 7;
            this.textBoxMa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMa_KeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(226, 179);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 24);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Đăng nhập 1 lần";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxHienMatKhau;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMa;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMatKhau;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonQuenMK;
        private CheckBox checkBox1;
    }
}