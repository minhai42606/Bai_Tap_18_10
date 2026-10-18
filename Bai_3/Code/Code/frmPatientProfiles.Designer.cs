namespace Code
{
    partial class frmPatientProfiles
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
            grpThongTinBenhNhan = new GroupBox();
            brpChucNang = new GroupBox();
            dgvPatients = new DataGridView();
            lblPatientId = new Label();
            lblPatientName = new Label();
            lblBirthDate = new Label();
            lblAddress = new Label();
            lblGender = new Label();
            txtPatientId = new TextBox();
            txtPatientName = new TextBox();
            dtpBirthDate = new DateTimePicker();
            cboGender = new ComboBox();
            textBox3 = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnRefresh = new Button();
            grpThongTinBenhNhan.SuspendLayout();
            brpChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // grpThongTinBenhNhan
            // 
            grpThongTinBenhNhan.Controls.Add(textBox3);
            grpThongTinBenhNhan.Controls.Add(cboGender);
            grpThongTinBenhNhan.Controls.Add(dtpBirthDate);
            grpThongTinBenhNhan.Controls.Add(txtPatientName);
            grpThongTinBenhNhan.Controls.Add(txtPatientId);
            grpThongTinBenhNhan.Controls.Add(lblGender);
            grpThongTinBenhNhan.Controls.Add(lblAddress);
            grpThongTinBenhNhan.Controls.Add(lblBirthDate);
            grpThongTinBenhNhan.Controls.Add(lblPatientName);
            grpThongTinBenhNhan.Controls.Add(lblPatientId);
            grpThongTinBenhNhan.Location = new Point(34, 12);
            grpThongTinBenhNhan.Name = "grpThongTinBenhNhan";
            grpThongTinBenhNhan.Size = new Size(729, 177);
            grpThongTinBenhNhan.TabIndex = 0;
            grpThongTinBenhNhan.TabStop = false;
            grpThongTinBenhNhan.Text = "Thông tin bệnh nhân";
            // 
            // brpChucNang
            // 
            brpChucNang.Controls.Add(btnRefresh);
            brpChucNang.Controls.Add(btnEdit);
            brpChucNang.Controls.Add(btnDelete);
            brpChucNang.Controls.Add(btnAdd);
            brpChucNang.Location = new Point(34, 186);
            brpChucNang.Name = "brpChucNang";
            brpChucNang.Size = new Size(729, 51);
            brpChucNang.TabIndex = 1;
            brpChucNang.TabStop = false;
            brpChucNang.Text = "Chức năng";
            // 
            // dgvPatients
            // 
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Dock = DockStyle.Bottom;
            dgvPatients.Location = new Point(0, 272);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.Size = new Size(800, 178);
            dgvPatients.TabIndex = 2;
            // 
            // lblPatientId
            // 
            lblPatientId.AutoSize = true;
            lblPatientId.Location = new Point(34, 38);
            lblPatientId.Name = "lblPatientId";
            lblPatientId.Size = new Size(103, 20);
            lblPatientId.TabIndex = 0;
            lblPatientId.Text = "Mã bệnh nhân";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new Point(440, 38);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(54, 20);
            lblPatientName.TabIndex = 1;
            lblPatientName.Text = "Họ tên";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(34, 92);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(74, 20);
            lblBirthDate.TabIndex = 2;
            lblBirthDate.Text = "Ngày sinh";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(34, 132);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(55, 20);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Địa chỉ";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(440, 92);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(65, 20);
            lblGender.TabIndex = 4;
            lblGender.Text = "Giới tính";
            // 
            // txtPatientId
            // 
            txtPatientId.BorderStyle = BorderStyle.FixedSingle;
            txtPatientId.Location = new Point(161, 38);
            txtPatientId.Name = "txtPatientId";
            txtPatientId.Size = new Size(211, 27);
            txtPatientId.TabIndex = 5;
            // 
            // txtPatientName
            // 
            txtPatientName.BorderStyle = BorderStyle.FixedSingle;
            txtPatientName.Location = new Point(511, 38);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(212, 27);
            txtPatientName.TabIndex = 6;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(161, 89);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(211, 27);
            dtpBirthDate.TabIndex = 7;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(511, 84);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(212, 28);
            cboGender.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(161, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 27);
            textBox3.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(121, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(277, 18);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(451, 18);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(611, 18);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // frmPatientProfiles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPatients);
            Controls.Add(brpChucNang);
            Controls.Add(grpThongTinBenhNhan);
            Name = "frmPatientProfiles";
            Text = "Hồ sơ bệnh nhân";
            grpThongTinBenhNhan.ResumeLayout(false);
            grpThongTinBenhNhan.PerformLayout();
            brpChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTinBenhNhan;
        private GroupBox brpChucNang;
        private DataGridView dgvPatients;
        private Label lblGender;
        private Label lblAddress;
        private Label lblBirthDate;
        private Label lblPatientName;
        private Label lblPatientId;
        private TextBox txtPatientName;
        private TextBox txtPatientId;
        private DateTimePicker dtpBirthDate;
        private ComboBox cboGender;
        private TextBox textBox3;
        private Button btnRefresh;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
    }
}