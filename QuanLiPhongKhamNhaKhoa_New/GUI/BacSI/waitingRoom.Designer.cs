namespace QuanLiPhongKhamNhaKhoa_New
{
    partial class waitingRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(waitingRoom));
            this.PhongKhamlbl = new System.Windows.Forms.Label();
            this.numberRoom = new System.Windows.Forms.Label();
            this.listWaiting = new System.Windows.Forms.DataGridView();
            this.labelTT = new System.Windows.Forms.Label();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoChuakham = new System.Windows.Forms.RadioButton();
            this.rdoTaiKham = new System.Windows.Forms.RadioButton();
            this.grpboxListWaiting = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listWaiting)).BeginInit();
            this.grpboxListWaiting.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhongKhamlbl
            // 
            this.PhongKhamlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhongKhamlbl.AutoSize = true;
            this.PhongKhamlbl.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhongKhamlbl.ForeColor = System.Drawing.Color.Cyan;
            this.PhongKhamlbl.Location = new System.Drawing.Point(228, 9);
            this.PhongKhamlbl.Name = "PhongKhamlbl";
            this.PhongKhamlbl.Size = new System.Drawing.Size(279, 43);
            this.PhongKhamlbl.TabIndex = 0;
            this.PhongKhamlbl.Text = "Phòng Chờ Khám";
            // 
            // numberRoom
            // 
            this.numberRoom.AutoSize = true;
            this.numberRoom.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberRoom.ForeColor = System.Drawing.Color.Cyan;
            this.numberRoom.Location = new System.Drawing.Point(445, 9);
            this.numberRoom.Name = "numberRoom";
            this.numberRoom.Size = new System.Drawing.Size(0, 43);
            this.numberRoom.TabIndex = 1;
            // 
            // listWaiting
            // 
            this.listWaiting.BackgroundColor = System.Drawing.Color.White;
            this.listWaiting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listWaiting.DefaultCellStyle = dataGridViewCellStyle1;
            this.listWaiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listWaiting.GridColor = System.Drawing.Color.Silver;
            this.listWaiting.Location = new System.Drawing.Point(3, 20);
            this.listWaiting.Name = "listWaiting";
            this.listWaiting.ReadOnly = true;
            this.listWaiting.RowHeadersWidth = 51;
            this.listWaiting.RowTemplate.Height = 24;
            this.listWaiting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listWaiting.Size = new System.Drawing.Size(847, 409);
            this.listWaiting.TabIndex = 2;
            this.listWaiting.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listWaiting_CellContentClick_1);
            // 
            // labelTT
            // 
            this.labelTT.AutoSize = true;
            this.labelTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTT.Location = new System.Drawing.Point(12, 91);
            this.labelTT.Name = "labelTT";
            this.labelTT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTT.Size = new System.Drawing.Size(94, 20);
            this.labelTT.TabIndex = 4;
            this.labelTT.Text = "Tình Trạng:";
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAll.Location = new System.Drawing.Point(125, 90);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(80, 24);
            this.rdoAll.TabIndex = 5;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "Tất Cả";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.rdoAll_CheckedChanged);
            // 
            // rdoChuakham
            // 
            this.rdoChuakham.AutoSize = true;
            this.rdoChuakham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChuakham.Location = new System.Drawing.Point(221, 90);
            this.rdoChuakham.Name = "rdoChuakham";
            this.rdoChuakham.Size = new System.Drawing.Size(117, 24);
            this.rdoChuakham.TabIndex = 6;
            this.rdoChuakham.TabStop = true;
            this.rdoChuakham.Text = "Chưa Khám";
            this.rdoChuakham.UseVisualStyleBackColor = true;
            this.rdoChuakham.CheckedChanged += new System.EventHandler(this.rdoChuakham_CheckedChanged);
            // 
            // rdoTaiKham
            // 
            this.rdoTaiKham.AutoSize = true;
            this.rdoTaiKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTaiKham.Location = new System.Drawing.Point(356, 89);
            this.rdoTaiKham.Name = "rdoTaiKham";
            this.rdoTaiKham.Size = new System.Drawing.Size(101, 24);
            this.rdoTaiKham.TabIndex = 7;
            this.rdoTaiKham.TabStop = true;
            this.rdoTaiKham.Text = "Tái Khám";
            this.rdoTaiKham.UseVisualStyleBackColor = true;
            this.rdoTaiKham.CheckedChanged += new System.EventHandler(this.rdoTaiKham_CheckedChanged);
            // 
            // grpboxListWaiting
            // 
            this.grpboxListWaiting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpboxListWaiting.Controls.Add(this.listWaiting);
            this.grpboxListWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxListWaiting.Location = new System.Drawing.Point(12, 120);
            this.grpboxListWaiting.Name = "grpboxListWaiting";
            this.grpboxListWaiting.Size = new System.Drawing.Size(853, 432);
            this.grpboxListWaiting.TabIndex = 8;
            this.grpboxListWaiting.TabStop = false;
            this.grpboxListWaiting.Text = "Danh Sách Chờ Khám";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::QuanLiPhongKhamNhaKhoa_New.Properties.Resources.icons8_exit_button_50;
            this.btnExit.Location = new System.Drawing.Point(806, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 56);
            this.btnExit.TabIndex = 9;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // waitingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(877, 564);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpboxListWaiting);
            this.Controls.Add(this.rdoTaiKham);
            this.Controls.Add(this.rdoChuakham);
            this.Controls.Add(this.rdoAll);
            this.Controls.Add(this.labelTT);
            this.Controls.Add(this.numberRoom);
            this.Controls.Add(this.PhongKhamlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "waitingRoom";
            this.Load += new System.EventHandler(this.waitingRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listWaiting)).EndInit();
            this.grpboxListWaiting.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PhongKhamlbl;
        private System.Windows.Forms.Label numberRoom;
        private System.Windows.Forms.DataGridView listWaiting;
        private System.Windows.Forms.Label labelTT;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoChuakham;
        private System.Windows.Forms.RadioButton rdoTaiKham;
        private System.Windows.Forms.GroupBox grpboxListWaiting;
        private System.Windows.Forms.Button btnExit;
    }
}