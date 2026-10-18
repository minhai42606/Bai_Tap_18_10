namespace code
{
    partial class frmGymMemberManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpMemberInfo = new GroupBox();
            dtpStartDate = new DateTimePicker();
            cboPackage = new ComboBox();
            txtFee = new TextBox();
            txtPhone = new TextBox();
            txtFullName = new TextBox();
            txtMemberId = new TextBox();
            lblFee = new Label();
            lblStartDate = new Label();
            lblPackage = new Label();
            lblPhone = new Label();
            lblFullName = new Label();
            lblMemberId = new Label();
            grpFunctions = new GroupBox();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvMembers = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            grpMemberInfo.SuspendLayout();
            grpFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // grpMemberInfo
            // 
            grpMemberInfo.Controls.Add(dtpStartDate);
            grpMemberInfo.Controls.Add(cboPackage);
            grpMemberInfo.Controls.Add(txtFee);
            grpMemberInfo.Controls.Add(txtPhone);
            grpMemberInfo.Controls.Add(txtFullName);
            grpMemberInfo.Controls.Add(txtMemberId);
            grpMemberInfo.Controls.Add(lblFee);
            grpMemberInfo.Controls.Add(lblStartDate);
            grpMemberInfo.Controls.Add(lblPackage);
            grpMemberInfo.Controls.Add(lblPhone);
            grpMemberInfo.Controls.Add(lblFullName);
            grpMemberInfo.Controls.Add(lblMemberId);
            grpMemberInfo.Location = new Point(66, 12);
            grpMemberInfo.Name = "grpMemberInfo";
            grpMemberInfo.Size = new Size(945, 196);
            grpMemberInfo.TabIndex = 0;
            grpMemberInfo.TabStop = false;
            grpMemberInfo.Text = "Thông tin hội viên";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(658, 100);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(228, 27);
            dtpStartDate.TabIndex = 11;
            // 
            // cboPackage
            // 
            cboPackage.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPackage.FormattingEnabled = true;
            cboPackage.Location = new Point(658, 41);
            cboPackage.Name = "cboPackage";
            cboPackage.Size = new Size(228, 28);
            cboPackage.TabIndex = 10;
            // 
            // txtFee
            // 
            txtFee.BorderStyle = BorderStyle.FixedSingle;
            txtFee.Location = new Point(658, 151);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(228, 27);
            txtFee.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(179, 158);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(207, 27);
            txtPhone.TabIndex = 8;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(179, 100);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(207, 27);
            txtFullName.TabIndex = 7;
            // 
            // txtMemberId
            // 
            txtMemberId.BorderStyle = BorderStyle.FixedSingle;
            txtMemberId.Location = new Point(179, 42);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.ReadOnly = true;
            txtMemberId.Size = new Size(207, 27);
            txtMemberId.TabIndex = 6;
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.Location = new Point(537, 155);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(83, 20);
            lblFee.TabIndex = 5;
            lblFee.Text = "Phí dịch vụ:";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(537, 96);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(103, 20);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "Ngày đăng ký:";
            // 
            // lblPackage
            // 
            lblPackage.AutoSize = true;
            lblPackage.Location = new Point(537, 43);
            lblPackage.Name = "lblPackage";
            lblPackage.Size = new Size(61, 20);
            lblPackage.TabIndex = 3;
            lblPackage.Text = "Gói tập:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(61, 155);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 20);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Số điện thoại:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(61, 96);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(76, 20);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Họ và tên:";
            // 
            // lblMemberId
            // 
            lblMemberId.AutoSize = true;
            lblMemberId.Location = new Point(61, 43);
            lblMemberId.Name = "lblMemberId";
            lblMemberId.Size = new Size(89, 20);
            lblMemberId.TabIndex = 0;
            lblMemberId.Text = "Mã hội viên:";
            // 
            // grpFunctions
            // 
            grpFunctions.Controls.Add(btnRefresh);
            grpFunctions.Controls.Add(btnDelete);
            grpFunctions.Controls.Add(btnEdit);
            grpFunctions.Controls.Add(btnAdd);
            grpFunctions.Location = new Point(66, 234);
            grpFunctions.Name = "grpFunctions";
            grpFunctions.Size = new Size(945, 125);
            grpFunctions.TabIndex = 1;
            grpFunctions.TabStop = false;
            grpFunctions.Text = "Chức năng";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(784, 43);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(102, 53);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(549, 43);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 53);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa hội viên";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(293, 43);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(102, 53);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa thông tin";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(61, 43);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 53);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvMembers
            // 
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(66, 376);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.Size = new Size(945, 265);
            dgvMembers.TabIndex = 2;
            dgvMembers.SelectionChanged += dgvMembers_SelectionChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmGymMemberManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 653);
            Controls.Add(dgvMembers);
            Controls.Add(grpFunctions);
            Controls.Add(grpMemberInfo);
            Name = "frmGymMemberManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý hội viên phòng gym";
            grpMemberInfo.ResumeLayout(false);
            grpMemberInfo.PerformLayout();
            grpFunctions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMemberInfo;
        private GroupBox grpFunctions;
        private DataGridView dgvMembers;
        private Label lblFee;
        private Label lblStartDate;
        private Label lblPackage;
        private Label lblPhone;
        private Label lblFullName;
        private Label lblMemberId;
        private TextBox txtFee;
        private TextBox txtPhone;
        private TextBox txtFullName;
        private TextBox txtMemberId;
        private DateTimePicker dtpStartDate;
        private ComboBox cboPackage;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private ErrorProvider errorProvider1;
    }
}
