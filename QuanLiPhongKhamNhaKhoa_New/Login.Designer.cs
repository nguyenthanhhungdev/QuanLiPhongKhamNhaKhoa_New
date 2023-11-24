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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonQuenMK = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxMatKhau = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxHienMatKhau = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMa = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonQuenMK);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 333);
            this.panel1.TabIndex = 0;
            // 
            // buttonQuenMK
            // 
            this.buttonQuenMK.Image = global::QuanLiPhongKhamNhaKhoa_New.Properties.Resources.icons8_body_25;
            this.buttonQuenMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuenMK.Location = new System.Drawing.Point(11, 188);
            this.buttonQuenMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuenMK.Name = "buttonQuenMK";
            this.buttonQuenMK.Size = new System.Drawing.Size(154, 42);
            this.buttonQuenMK.TabIndex = 17;
            this.buttonQuenMK.Text = "Quên mật khẩu";
            this.buttonQuenMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonQuenMK.UseVisualStyleBackColor = true;
            this.buttonQuenMK.Click += new System.EventHandler(this.buttonQuenMK_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.checkBox1);
            this.panelControl1.Controls.Add(this.maskedTextBoxMatKhau);
            this.panelControl1.Controls.Add(this.checkBoxHienMatKhau);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.textBoxMa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 74);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(336, 179);
            this.panelControl1.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(197, 91);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 20);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Đăng nhập 1 lần";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxMatKhau
            // 
            this.maskedTextBoxMatKhau.Location = new System.Drawing.Point(96, 66);
            this.maskedTextBoxMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxMatKhau.Name = "maskedTextBoxMatKhau";
            this.maskedTextBoxMatKhau.PasswordChar = '*';
            this.maskedTextBoxMatKhau.Size = new System.Drawing.Size(212, 23);
            this.maskedTextBoxMatKhau.TabIndex = 25;
            this.maskedTextBoxMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // checkBoxHienMatKhau
            // 
            this.checkBoxHienMatKhau.AutoSize = true;
            this.checkBoxHienMatKhau.Location = new System.Drawing.Point(7, 91);
            this.checkBoxHienMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxHienMatKhau.Name = "checkBoxHienMatKhau";
            this.checkBoxHienMatKhau.Size = new System.Drawing.Size(111, 20);
            this.checkBoxHienMatKhau.TabIndex = 24;
            this.checkBoxHienMatKhau.Text = "Hiện mật khẩu";
            this.checkBoxHienMatKhau.UseVisualStyleBackColor = true;
            this.checkBoxHienMatKhau.CheckedChanged += new System.EventHandler(this.checkBoxHienMatKhau_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã";
            // 
            // textBoxMa
            // 
            this.textBoxMa.Location = new System.Drawing.Point(96, 26);
            this.textBoxMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMa.Name = "textBoxMa";
            this.textBoxMa.Size = new System.Drawing.Size(212, 23);
            this.textBoxMa.TabIndex = 20;
            this.textBoxMa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMa_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.buttonDangNhap);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 253);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 80);
            this.panel3.TabIndex = 18;
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Image = global::QuanLiPhongKhamNhaKhoa_New.Properties.Resources.icons8_login_50;
            this.buttonDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDangNhap.Location = new System.Drawing.Point(89, 16);
            this.buttonDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(167, 54);
            this.buttonDangNhap.TabIndex = 23;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 74);
            this.panel2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 333);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonQuenMK;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private CheckBox checkBox1;
        private MaskedTextBox maskedTextBoxMatKhau;
        private CheckBox checkBoxHienMatKhau;
        private System.Windows.Forms.Button buttonDangNhap;
        private Label label2;
        private Label label1;
        private TextBox textBoxMa;
    }
}