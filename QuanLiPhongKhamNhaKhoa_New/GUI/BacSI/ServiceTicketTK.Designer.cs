namespace QuanLiPhongKhamNhaKhoa_New.GUI.BacSI
{
    partial class ServiceTicketTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceTicketTK));
            this.listDVTKChoose = new System.Windows.Forms.DataGridView();
            this.chooseService = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.listDVTKChoose)).BeginInit();
            this.chooseService.SuspendLayout();
            this.SuspendLayout();
            // 
            // listDVTKChoose
            // 
            this.listDVTKChoose.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listDVTKChoose.BackgroundColor = System.Drawing.Color.White;
            this.listDVTKChoose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDVTKChoose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDVTKChoose.Location = new System.Drawing.Point(3, 18);
            this.listDVTKChoose.MultiSelect = false;
            this.listDVTKChoose.Name = "listDVTKChoose";
            this.listDVTKChoose.ReadOnly = true;
            this.listDVTKChoose.RowHeadersWidth = 51;
            this.listDVTKChoose.RowTemplate.Height = 24;
            this.listDVTKChoose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listDVTKChoose.Size = new System.Drawing.Size(990, 520);
            this.listDVTKChoose.TabIndex = 0;
            // 
            // chooseService
            // 
            this.chooseService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chooseService.Controls.Add(this.listDVTKChoose);
            this.chooseService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chooseService.Location = new System.Drawing.Point(0, 0);
            this.chooseService.Name = "chooseService";
            this.chooseService.Size = new System.Drawing.Size(996, 541);
            this.chooseService.TabIndex = 8;
            this.chooseService.TabStop = false;
            this.chooseService.Text = "Dịch Vụ Tái Khám";
            // 
            // ServiceTicketTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(996, 541);
            this.Controls.Add(this.chooseService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServiceTicketTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Tái Khám";
            ((System.ComponentModel.ISupportInitialize)(this.listDVTKChoose)).EndInit();
            this.chooseService.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox chooseService;
        public System.Windows.Forms.DataGridView listDVTKChoose;
    }
}