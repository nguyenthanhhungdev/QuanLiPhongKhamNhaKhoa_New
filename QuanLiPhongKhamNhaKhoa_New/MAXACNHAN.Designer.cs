namespace QuanLiPhongKhamNhaKhoa_New
{
    partial class MAXACNHAN
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxXacNhan = new System.Windows.Forms.TextBox();
            this.textBoxThayDoiMK = new System.Windows.Forms.TextBox();
            this.buttonXacNhan = new System.Windows.Forms.Button();
            this.buttonThayDoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thay Đổi Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã xác nhận:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu Mới:";
            // 
            // textBoxXacNhan
            // 
            this.textBoxXacNhan.Location = new System.Drawing.Point(206, 128);
            this.textBoxXacNhan.Name = "textBoxXacNhan";
            this.textBoxXacNhan.Size = new System.Drawing.Size(194, 22);
            this.textBoxXacNhan.TabIndex = 3;
            this.textBoxXacNhan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaXacNhan_KeyDown);
            // 
            // textBoxThayDoiMK
            // 
            this.textBoxThayDoiMK.Location = new System.Drawing.Point(206, 188);
            this.textBoxThayDoiMK.Name = "textBoxThayDoiMK";
            this.textBoxThayDoiMK.Size = new System.Drawing.Size(194, 22);
            this.textBoxThayDoiMK.TabIndex = 4;
            this.textBoxThayDoiMK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtThayDoiMK_KeyDown);
            // 
            // buttonXacNhan
            // 
            this.buttonXacNhan.Location = new System.Drawing.Point(444, 125);
            this.buttonXacNhan.Name = "buttonXacNhan";
            this.buttonXacNhan.Size = new System.Drawing.Size(85, 28);
            this.buttonXacNhan.TabIndex = 5;
            this.buttonXacNhan.Text = "Xác Nhận";
            this.buttonXacNhan.UseVisualStyleBackColor = true;
            this.buttonXacNhan.Click += new System.EventHandler(this.buttonXacNhan_Click);
            // 
            // buttonThayDoi
            // 
            this.buttonThayDoi.Location = new System.Drawing.Point(444, 188);
            this.buttonThayDoi.Name = "buttonThayDoi";
            this.buttonThayDoi.Size = new System.Drawing.Size(85, 28);
            this.buttonThayDoi.TabIndex = 6;
            this.buttonThayDoi.Text = "Thay Đổi";
            this.buttonThayDoi.UseVisualStyleBackColor = true;
            this.buttonThayDoi.Click += new System.EventHandler(this.buttonThayDoi_Click);
            // 
            // MAXACNHAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 275);
            this.Controls.Add(this.buttonThayDoi);
            this.Controls.Add(this.buttonXacNhan);
            this.Controls.Add(this.textBoxThayDoiMK);
            this.Controls.Add(this.textBoxXacNhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MAXACNHAN";
            this.Text = "MAXACNHAN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxXacNhan;
        private System.Windows.Forms.TextBox textBoxThayDoiMK;
        private System.Windows.Forms.Button buttonXacNhan;
        private System.Windows.Forms.Button buttonThayDoi;
    }
}