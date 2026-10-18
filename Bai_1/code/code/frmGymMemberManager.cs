using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace code
{
    public partial class frmGymMemberManager : Form
    {
        private BindingList<MemberModel> members = new BindingList<MemberModel>();

        private BindingSource memberSource = new BindingSource();

        private bool isLoading = false;
        public frmGymMemberManager()
        {
            InitializeComponent();
            LoadPackages();
            ConfigureGrid();
            BindData();
            ResetForm();
        }

        private void LoadPackages()
        {
            cboPackage.Items.Clear();
            cboPackage.Items.AddRange(new object[]
            {
        "Theo tháng",
        "6 tháng",
        "1 năm"
            });

            cboPackage.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ConfigureGrid()
        {
            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.Columns.Clear();

            dgvMembers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvMembers.MultiSelect = false;
            dgvMembers.ReadOnly = true;
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMemberId",
                HeaderText = "Mã HV",
                DataPropertyName = "MemberId",
                FillWeight = 70
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFullName",
                HeaderText = "Tên hội viên",
                DataPropertyName = "FullName",
                FillWeight = 150
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPhone",
                HeaderText = "SĐT",
                DataPropertyName = "Phone",
                FillWeight = 100
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPackage",
                HeaderText = "Gói tập",
                DataPropertyName = "Package",
                FillWeight = 90
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStartDate",
                HeaderText = "Ngày ĐK",
                DataPropertyName = "StartDate",
                FillWeight = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy"
                }
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFee",
                HeaderText = "Phí dịch vụ",
                DataPropertyName = "Fee",
                FillWeight = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
        }

        private void BindData()
        {
            memberSource.DataSource = members;
            dgvMembers.DataSource = memberSource;
        }

        private void dgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null ||
        dgvMembers.CurrentRow.DataBoundItem == null)
                return;

            MemberModel m =
                dgvMembers.CurrentRow.DataBoundItem as MemberModel;

            if (m == null) return;

            isLoading = true;

            txtMemberId.Text = m.MemberId;
            txtFullName.Text = m.FullName;
            txtPhone.Text = m.Phone;
            cboPackage.SelectedItem = m.Package;
            dtpStartDate.Value = m.StartDate;
            txtFee.Text = m.Fee.ToString("0", CultureInfo.InvariantCulture);

            isLoading = false;
        }


        private bool ValidateInput()
        {
            errorProvider1.Clear();
            bool valid = true;

            string name = txtFullName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string feeText = txtFee.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) ||
                !Regex.IsMatch(name, @"^[\p{L}\s]+$"))
            {
                errorProvider1.SetError(
                    txtFullName,
                    "Họ tên không được trống hoặc chứa ký tự đặc biệt.");
                valid = false;
            }

            if (!Regex.IsMatch(phone, @"^\d{10}$"))
            {
                errorProvider1.SetError(
                    txtPhone,
                    "Số điện thoại phải gồm đúng 10 chữ số.");
                valid = false;
            }

            decimal fee;
            if (!decimal.TryParse(
                    feeText,
                    NumberStyles.None,
                    CultureInfo.InvariantCulture,
                    out fee) || fee <= 0 ||
                fee != decimal.Truncate(fee))
            {
                errorProvider1.SetError(
                    txtFee,
                    "Phí dịch vụ phải là số nguyên dương.");
                valid = false;
            }

            if (cboPackage.SelectedIndex < 0)
            {
                errorProvider1.SetError(
                    cboPackage, "Vui lòng chọn gói tập.");
                valid = false;
            }

            return valid;
        }
        private string GenerateMemberId()
        {
            int maxId = 0;

            foreach (MemberModel m in members)
            {
                if (m.MemberId != null &&
                    m.MemberId.StartsWith("HV") &&
                    int.TryParse(m.MemberId.Substring(2), out int n))
                {
                    if (n > maxId)
                        maxId = n;
                }
            }

            return "HV" + (maxId + 1).ToString("D3");
        }
        private void ResetForm()
        {
            isLoading = true;

            txtMemberId.Text = GenerateMemberId();
            txtFullName.Clear();
            txtPhone.Clear();
            cboPackage.SelectedIndex = -1;
            dtpStartDate.Value = DateTime.Today;
            txtFee.Clear();

            errorProvider1.Clear();
            dgvMembers.ClearSelection();

            isLoading = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            decimal fee = decimal.Parse(
                txtFee.Text.Trim(),
                CultureInfo.InvariantCulture);

            MemberModel m = new MemberModel
            {
                MemberId = GenerateMemberId(),
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Package = cboPackage.SelectedItem.ToString(),
                StartDate = dtpStartDate.Value.Date,
                Fee = fee
            };

            members.Add(m);

            memberSource.ResetBindings(false);
            ResetForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null ||
        dgvMembers.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Vui lòng chọn hội viên cần sửa.");
                return;
            }

            if (!ValidateInput())
                return;

            MemberModel m =
                (MemberModel)dgvMembers.CurrentRow.DataBoundItem;

            m.FullName = txtFullName.Text.Trim();
            m.Phone = txtPhone.Text.Trim();
            m.Package = cboPackage.SelectedItem.ToString();
            m.StartDate = dtpStartDate.Value.Date;
            m.Fee = decimal.Parse(
                txtFee.Text.Trim(),
                CultureInfo.InvariantCulture);

            memberSource.ResetBindings(false);

            MessageBox.Show("Cập nhật thông tin thành công!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null ||
        dgvMembers.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Vui lòng chọn hội viên cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hội viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            MemberModel m =
                (MemberModel)dgvMembers.CurrentRow.DataBoundItem;

            members.Remove(m);

            memberSource.ResetBindings(false);
            ResetForm();

            MessageBox.Show("Đã xóa hội viên.");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
