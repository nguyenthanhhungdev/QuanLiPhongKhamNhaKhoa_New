namespace QuanLiPhongKhamNhaKhoa_New
{
    partial class ThemBenhNhan
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maBNLabel;
            System.Windows.Forms.Label tenBNLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label ngSinhLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label benhLyLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label soPhieuDVLabel;
            this.phongKhamNhaKhoaDataSet = new QuanLiPhongKhamNhaKhoa_New.PhongKhamNhaKhoaDataSet();
            this.bENHNHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bENHNHANTableAdapter = new QuanLiPhongKhamNhaKhoa_New.PhongKhamNhaKhoaDataSetTableAdapters.BENHNHANTableAdapter();
            this.tableAdapterManager = new QuanLiPhongKhamNhaKhoa_New.PhongKhamNhaKhoaDataSetTableAdapters.TableAdapterManager();
            this.maBNTextBox = new System.Windows.Forms.TextBox();
            this.tenBNTextBox = new System.Windows.Forms.TextBox();
            this.cMNDTextBox = new System.Windows.Forms.TextBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.ngSinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.benhLyTextBox = new System.Windows.Forms.TextBox();
            this.gioiTinhRadioButton = new System.Windows.Forms.RadioButton();
            this.soPhieuDVTextBox = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            maBNLabel = new System.Windows.Forms.Label();
            tenBNLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            ngSinhLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            benhLyLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            soPhieuDVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phongKhamNhaKhoaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maBNLabel
            // 
            maBNLabel.AutoSize = true;
            maBNLabel.Location = new System.Drawing.Point(11, 28);
            maBNLabel.Name = "maBNLabel";
            maBNLabel.Size = new System.Drawing.Size(51, 16);
            maBNLabel.TabIndex = 1;
            maBNLabel.Text = "Mã BN:";
            // 
            // tenBNLabel
            // 
            tenBNLabel.AutoSize = true;
            tenBNLabel.Location = new System.Drawing.Point(11, 54);
            tenBNLabel.Name = "tenBNLabel";
            tenBNLabel.Size = new System.Drawing.Size(56, 16);
            tenBNLabel.TabIndex = 3;
            tenBNLabel.Text = "Tên BN:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(11, 79);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(50, 16);
            cMNDLabel.TabIndex = 5;
            cMNDLabel.Text = "CMND:";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(11, 105);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(50, 16);
            diaChiLabel.TabIndex = 7;
            diaChiLabel.Text = "Địa chỉ:";
            // 
            // ngSinhLabel
            // 
            ngSinhLabel.AutoSize = true;
            ngSinhLabel.Location = new System.Drawing.Point(11, 131);
            ngSinhLabel.Name = "ngSinhLabel";
            ngSinhLabel.Size = new System.Drawing.Size(55, 16);
            ngSinhLabel.TabIndex = 9;
            ngSinhLabel.Text = "Ng sinh:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(11, 156);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(38, 16);
            sDTLabel.TabIndex = 11;
            sDTLabel.Text = "SDT:";
            // 
            // benhLyLabel
            // 
            benhLyLabel.AutoSize = true;
            benhLyLabel.Location = new System.Drawing.Point(11, 182);
            benhLyLabel.Name = "benhLyLabel";
            benhLyLabel.Size = new System.Drawing.Size(54, 16);
            benhLyLabel.TabIndex = 13;
            benhLyLabel.Text = "Bệnh lý:";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Location = new System.Drawing.Point(11, 210);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(57, 16);
            gioiTinhLabel.TabIndex = 15;
            gioiTinhLabel.Text = "Giới tính:";
            // 
            // soPhieuDVLabel
            // 
            soPhieuDVLabel.AutoSize = true;
            soPhieuDVLabel.Location = new System.Drawing.Point(11, 233);
            soPhieuDVLabel.Name = "soPhieuDVLabel";
            soPhieuDVLabel.Size = new System.Drawing.Size(85, 16);
            soPhieuDVLabel.TabIndex = 17;
            soPhieuDVLabel.Text = "Số phiếu DV:";
            // 
            // phongKhamNhaKhoaDataSet
            // 
            this.phongKhamNhaKhoaDataSet.DataSetName = "PhongKhamNhaKhoaDataSet";
            this.phongKhamNhaKhoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bENHNHANBindingSource
            // 
            this.bENHNHANBindingSource.DataMember = "BENHNHAN";
            this.bENHNHANBindingSource.DataSource = this.phongKhamNhaKhoaDataSet;
            // 
            // bENHNHANTableAdapter
            // 
            this.bENHNHANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BACSITableAdapter = null;
            this.tableAdapterManager.BENHNHANTableAdapter = this.bENHNHANTableAdapter;
            this.tableAdapterManager.CT_DICHVUTableAdapter = null;
            this.tableAdapterManager.DICHVUTableAdapter = null;
            this.tableAdapterManager.LOAIDICHVUTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDICHVUTableAdapter = null;
            this.tableAdapterManager.PHIEUKETQUATableAdapter = null;
            this.tableAdapterManager.PHONGKHAMTableAdapter = null;
            this.tableAdapterManager.TAIKHAMTableAdapter = null;
            this.tableAdapterManager.TIEPDONBNTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLiPhongKhamNhaKhoa_New.PhongKhamNhaKhoaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maBNTextBox
            // 
            this.maBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "MaBN", true));
            this.maBNTextBox.Location = new System.Drawing.Point(108, 26);
            this.maBNTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maBNTextBox.Name = "maBNTextBox";
            this.maBNTextBox.Size = new System.Drawing.Size(178, 22);
            this.maBNTextBox.TabIndex = 2;
            // 
            // tenBNTextBox
            // 
            this.tenBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "TenBN", true));
            this.tenBNTextBox.Location = new System.Drawing.Point(108, 51);
            this.tenBNTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenBNTextBox.Name = "tenBNTextBox";
            this.tenBNTextBox.Size = new System.Drawing.Size(178, 22);
            this.tenBNTextBox.TabIndex = 4;
            // 
            // cMNDTextBox
            // 
            this.cMNDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "CMND", true));
            this.cMNDTextBox.Location = new System.Drawing.Point(108, 77);
            this.cMNDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cMNDTextBox.Name = "cMNDTextBox";
            this.cMNDTextBox.Size = new System.Drawing.Size(178, 22);
            this.cMNDTextBox.TabIndex = 6;
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "DiaChi", true));
            this.diaChiTextBox.Location = new System.Drawing.Point(108, 102);
            this.diaChiTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(178, 22);
            this.diaChiTextBox.TabIndex = 8;
            // 
            // ngSinhDateTimePicker
            // 
            this.ngSinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bENHNHANBindingSource, "NgSinh", true));
            this.ngSinhDateTimePicker.Location = new System.Drawing.Point(108, 128);
            this.ngSinhDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngSinhDateTimePicker.Name = "ngSinhDateTimePicker";
            this.ngSinhDateTimePicker.Size = new System.Drawing.Size(178, 22);
            this.ngSinhDateTimePicker.TabIndex = 10;
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(108, 154);
            this.sDTTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(178, 22);
            this.sDTTextBox.TabIndex = 12;
            // 
            // benhLyTextBox
            // 
            this.benhLyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "BenhLy", true));
            this.benhLyTextBox.Location = new System.Drawing.Point(108, 179);
            this.benhLyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.benhLyTextBox.Name = "benhLyTextBox";
            this.benhLyTextBox.Size = new System.Drawing.Size(178, 22);
            this.benhLyTextBox.TabIndex = 14;
            // 
            // gioiTinhRadioButton
            // 
            this.gioiTinhRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bENHNHANBindingSource, "GioiTinh", true));
            this.gioiTinhRadioButton.Location = new System.Drawing.Point(108, 205);
            this.gioiTinhRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gioiTinhRadioButton.Name = "gioiTinhRadioButton";
            this.gioiTinhRadioButton.Size = new System.Drawing.Size(178, 19);
            this.gioiTinhRadioButton.TabIndex = 16;
            this.gioiTinhRadioButton.TabStop = true;
            this.gioiTinhRadioButton.Text = "Nam";
            this.gioiTinhRadioButton.UseVisualStyleBackColor = true;
            // 
            // soPhieuDVTextBox
            // 
            this.soPhieuDVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "SoPhieuDV", true));
            this.soPhieuDVTextBox.Location = new System.Drawing.Point(108, 230);
            this.soPhieuDVTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soPhieuDVTextBox.Name = "soPhieuDVTextBox";
            this.soPhieuDVTextBox.Size = new System.Drawing.Size(178, 22);
            this.soPhieuDVTextBox.TabIndex = 18;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(235, 204);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 20);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nữ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ThemBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 360);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(maBNLabel);
            this.Controls.Add(this.maBNTextBox);
            this.Controls.Add(tenBNLabel);
            this.Controls.Add(this.tenBNTextBox);
            this.Controls.Add(cMNDLabel);
            this.Controls.Add(this.cMNDTextBox);
            this.Controls.Add(diaChiLabel);
            this.Controls.Add(this.diaChiTextBox);
            this.Controls.Add(ngSinhLabel);
            this.Controls.Add(this.ngSinhDateTimePicker);
            this.Controls.Add(sDTLabel);
            this.Controls.Add(this.sDTTextBox);
            this.Controls.Add(benhLyLabel);
            this.Controls.Add(this.benhLyTextBox);
            this.Controls.Add(gioiTinhLabel);
            this.Controls.Add(this.gioiTinhRadioButton);
            this.Controls.Add(soPhieuDVLabel);
            this.Controls.Add(this.soPhieuDVTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ThemBenhNhan";
            this.Text = "ThemBenhNhan";
            this.Load += new System.EventHandler(this.ThemBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phongKhamNhaKhoaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhongKhamNhaKhoaDataSet phongKhamNhaKhoaDataSet;
        private System.Windows.Forms.BindingSource bENHNHANBindingSource;
        private PhongKhamNhaKhoaDataSetTableAdapters.BENHNHANTableAdapter bENHNHANTableAdapter;
        private PhongKhamNhaKhoaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox maBNTextBox;
        private System.Windows.Forms.TextBox tenBNTextBox;
        private System.Windows.Forms.TextBox cMNDTextBox;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.DateTimePicker ngSinhDateTimePicker;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.TextBox benhLyTextBox;
        private System.Windows.Forms.RadioButton gioiTinhRadioButton;
        private System.Windows.Forms.TextBox soPhieuDVTextBox;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}