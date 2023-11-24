namespace QuanLiPhongKhamNhaKhoa_New
{
    partial class XacNhanPay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblForPhieu = new System.Windows.Forms.Label();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDebt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPay = new System.Windows.Forms.Panel();
            this.txtGive = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXnPay = new System.Windows.Forms.Button();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.panelPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(162, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xác Nhận Thanh Toán";
            // 
            // txtMoney
            // 
            this.txtMoney.Enabled = false;
            this.txtMoney.Location = new System.Drawing.Point(163, 19);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(230, 22);
            this.txtMoney.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiền Cần Trả:";
            // 
            // lblForPhieu
            // 
            this.lblForPhieu.AutoSize = true;
            this.lblForPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForPhieu.ForeColor = System.Drawing.Color.Cyan;
            this.lblForPhieu.Location = new System.Drawing.Point(193, 76);
            this.lblForPhieu.Name = "lblForPhieu";
            this.lblForPhieu.Size = new System.Drawing.Size(91, 20);
            this.lblForPhieu.TabIndex = 2;
            this.lblForPhieu.Text = "Cho Phiếu ";
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(163, 60);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(230, 22);
            this.txtReceive.TabIndex = 3;
            this.txtReceive.TextChanged += new System.EventHandler(this.txtGive_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bệnh Nhân Đưa:";
            // 
            // txtDebt
            // 
            this.txtDebt.Enabled = false;
            this.txtDebt.Location = new System.Drawing.Point(163, 104);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.Size = new System.Drawing.Size(230, 22);
            this.txtDebt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tiền Nợ:";
            // 
            // panelPay
            // 
            this.panelPay.Controls.Add(this.txtGive);
            this.panelPay.Controls.Add(this.label5);
            this.panelPay.Controls.Add(this.txtDebt);
            this.panelPay.Controls.Add(this.label4);
            this.panelPay.Controls.Add(this.txtReceive);
            this.panelPay.Controls.Add(this.label3);
            this.panelPay.Controls.Add(this.txtMoney);
            this.panelPay.Controls.Add(this.label2);
            this.panelPay.Location = new System.Drawing.Point(15, 122);
            this.panelPay.Name = "panelPay";
            this.panelPay.Size = new System.Drawing.Size(538, 192);
            this.panelPay.TabIndex = 3;
            // 
            // txtGive
            // 
            this.txtGive.Enabled = false;
            this.txtGive.Location = new System.Drawing.Point(163, 150);
            this.txtGive.Name = "txtGive";
            this.txtGive.Size = new System.Drawing.Size(230, 22);
            this.txtGive.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tiền Thối:";
            // 
            // btnXnPay
            // 
            this.btnXnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXnPay.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnXnPay.Image = global::QuanLiPhongKhamNhaKhoa_New.Properties.Resources.icons8_pay_64;
            this.btnXnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXnPay.Location = new System.Drawing.Point(178, 329);
            this.btnXnPay.Name = "btnXnPay";
            this.btnXnPay.Size = new System.Drawing.Size(230, 65);
            this.btnXnPay.TabIndex = 4;
            this.btnXnPay.Text = "Xác Nhận";
            this.btnXnPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXnPay.UseVisualStyleBackColor = true;
            this.btnXnPay.Click += new System.EventHandler(this.btnXnPay_Click);
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhieu.ForeColor = System.Drawing.Color.Cyan;
            this.lblSoPhieu.Location = new System.Drawing.Point(279, 76);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(0, 20);
            this.lblSoPhieu.TabIndex = 5;
            // 
            // XacNhanPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblSoPhieu);
            this.Controls.Add(this.btnXnPay);
            this.Controls.Add(this.lblForPhieu);
            this.Controls.Add(this.panelPay);
            this.Controls.Add(this.label1);
            this.Name = "XacNhanPay";
            this.Size = new System.Drawing.Size(570, 408);
            this.panelPay.ResumeLayout(false);
            this.panelPay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMoney;
        public System.Windows.Forms.Label lblForPhieu;
        public System.Windows.Forms.TextBox txtDebt;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelPay;
        private System.Windows.Forms.Button btnXnPay;
        public System.Windows.Forms.TextBox txtGive;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblSoPhieu;
    }
}
