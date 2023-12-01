using System;
using System.Windows.Forms;

namespace QuanLiPhongKhamNhaKhoa_New
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
            this.textBoxThayDoiMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonThayDoiMK = new System.Windows.Forms.Button();
            this.txtTenDn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtconfirmMk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmkNow = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 86);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(193, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thay đổi mật khẩu";
            // 
            // textBoxThayDoiMK
            // 
            this.textBoxThayDoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxThayDoiMK.Location = new System.Drawing.Point(224, 230);
            this.textBoxThayDoiMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxThayDoiMK.Name = "textBoxThayDoiMK";
            this.textBoxThayDoiMK.Size = new System.Drawing.Size(264, 27);
            this.textBoxThayDoiMK.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật Khẩu Mới:";
            // 
            // buttonThayDoiMK
            // 
            this.buttonThayDoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThayDoiMK.Image = global::QuanLiPhongKhamNhaKhoa_New.Properties.Resources.icons8_confirm_30;
            this.buttonThayDoiMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThayDoiMK.Location = new System.Drawing.Point(213, 333);
            this.buttonThayDoiMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThayDoiMK.Name = "buttonThayDoiMK";
            this.buttonThayDoiMK.Size = new System.Drawing.Size(239, 45);
            this.buttonThayDoiMK.TabIndex = 6;
            this.buttonThayDoiMK.Text = "Xác Nhận Thay Đổi";
            this.buttonThayDoiMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThayDoiMK.UseVisualStyleBackColor = true;
            this.buttonThayDoiMK.Click += new System.EventHandler(this.buttonThayDoi_Click);
            // 
            // txtTenDn
            // 
            this.txtTenDn.Enabled = false;
            this.txtTenDn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDn.Location = new System.Drawing.Point(224, 133);
            this.txtTenDn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDn.Name = "txtTenDn";
            this.txtTenDn.Size = new System.Drawing.Size(264, 27);
            this.txtTenDn.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên Đăng Nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Xác Nhận Mật Khẩu:";
            // 
            // txtconfirmMk
            // 
            this.txtconfirmMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmMk.Location = new System.Drawing.Point(224, 272);
            this.txtconfirmMk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtconfirmMk.Name = "txtconfirmMk";
            this.txtconfirmMk.Size = new System.Drawing.Size(264, 27);
            this.txtconfirmMk.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mật Khẩu Hiện Tại:";
            // 
            // txtmkNow
            // 
            this.txtmkNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkNow.Location = new System.Drawing.Point(224, 181);
            this.txtmkNow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmkNow.Name = "txtmkNow";
            this.txtmkNow.Size = new System.Drawing.Size(264, 27);
            this.txtmkNow.TabIndex = 13;
            // 
            // ThayDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 421);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmkNow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtconfirmMk);
            this.Controls.Add(this.txtTenDn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonThayDoiMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxThayDoiMK);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox textBoxThayDoiMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonThayDoiMK;
        private TextBox txtTenDn;
        private Label label4;
        private Label label6;
        private TextBox txtconfirmMk;
        private Label label2;
        private TextBox txtmkNow;
    }
}