﻿namespace QuanLyHangHoa.GUI
{
    partial class FrmPhongBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhongBan));
            this.btnLamTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaPB = new System.Windows.Forms.Label();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPhongBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgvPhongBanMain = new DevExpress.XtraGrid.GridControl();
            this.label1 = new System.Windows.Forms.Label();
            this.MaPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBanMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLamTrang
            // 
            this.btnLamTrang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnLamTrang.Image = ((System.Drawing.Image)(resources.GetObject("btnLamTrang.Image")));
            this.btnLamTrang.Location = new System.Drawing.Point(1087, 473);
            this.btnLamTrang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamTrang.Name = "btnLamTrang";
            this.btnLamTrang.Size = new System.Drawing.Size(265, 55);
            this.btnLamTrang.TabIndex = 38;
            this.btnLamTrang.Text = "Xóa trắng";
            this.btnLamTrang.Click += new System.EventHandler(this.btnLamTrang_Click);
            // 
            // btnDong
            // 
            this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(813, 598);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(539, 55);
            this.btnDong.TabIndex = 34;
            this.btnDong.Text = "Đóng chức năng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(1087, 535);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(265, 55);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(813, 473);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(265, 55);
            this.btnThem.TabIndex = 35;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(813, 535);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(265, 55);
            this.btnSua.TabIndex = 36;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtMaPB);
            this.groupBox1.Controls.Add(this.txtTenPB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(813, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(539, 192);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng ban";
            // 
            // txtMaPB
            // 
            this.txtMaPB.AutoSize = true;
            this.txtMaPB.Location = new System.Drawing.Point(161, 65);
            this.txtMaPB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(16, 17);
            this.txtMaPB.TabIndex = 16;
            this.txtMaPB.Text = "1";
            // 
            // txtTenPB
            // 
            this.txtTenPB.Location = new System.Drawing.Point(165, 117);
            this.txtTenPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(324, 22);
            this.txtTenPB.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tên phòng ban : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã phòng ban :";
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dgvPhongBan.ColumnPanelRowHeight = 30;
            this.dgvPhongBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaPB,
            this.TenPB});
            this.dgvPhongBan.FixedLineWidth = 1;
            this.dgvPhongBan.GridControl = this.dgvPhongBanMain;
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.OptionsBehavior.Editable = false;
            this.dgvPhongBan.OptionsBehavior.ReadOnly = true;
            this.dgvPhongBan.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvPhongBan.PaintStyleName = "UltraFlat";
            this.dgvPhongBan.RowHeight = 40;
            this.dgvPhongBan.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvPhongBan_FocusedRowChanged);
            // 
            // dgvPhongBanMain
            // 
            // 
            // 
            // 
            this.dgvPhongBanMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhongBanMain.Location = new System.Drawing.Point(27, 53);
            this.dgvPhongBanMain.MainView = this.dgvPhongBan;
            this.dgvPhongBanMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPhongBanMain.Name = "dgvPhongBanMain";
            this.dgvPhongBanMain.Size = new System.Drawing.Size(764, 601);
            this.dgvPhongBanMain.TabIndex = 32;
            this.dgvPhongBanMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvPhongBan});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Danh sách các phòng ban";
            // 
            // MaPB
            // 
            this.MaPB.Caption = "Mã phòng ban";
            this.MaPB.FieldName = "MaPB";
            this.MaPB.Name = "MaPB";
            this.MaPB.Visible = true;
            this.MaPB.VisibleIndex = 0;
            this.MaPB.Width = 164;
            // 
            // TenPB
            // 
            this.TenPB.Caption = "Tên phòng ban";
            this.TenPB.FieldName = "TenPB";
            this.TenPB.Name = "TenPB";
            this.TenPB.Visible = true;
            this.TenPB.VisibleIndex = 1;
            this.TenPB.Width = 535;
            // 
            // FrmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1375, 687);
            this.Controls.Add(this.btnLamTrang);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPhongBanMain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPhongBan";
            this.Text = "FrmPhongBan";
            this.Load += new System.EventHandler(this.FrmPhongBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBanMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLamTrang;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvPhongBan;
        private DevExpress.XtraGrid.GridControl dgvPhongBanMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMaPB;
        private System.Windows.Forms.TextBox txtTenPB;
        private DevExpress.XtraGrid.Columns.GridColumn MaPB;
        private DevExpress.XtraGrid.Columns.GridColumn TenPB;


    }
}