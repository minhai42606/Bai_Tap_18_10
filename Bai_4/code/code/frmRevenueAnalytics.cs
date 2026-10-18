using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace code
{
    public partial class frmRevenueAnalytics : Form
    {
        private DateTimePicker dtpFromDate;
        private DateTimePicker dtpToDate;
        private ComboBox cboBranch;
        private Button btnStatistics;
        private Button btnCancel;
        private ProgressBar pgbLoading;
        private Label lblProcessingStatus;
        private DataGridView dgvRevenueData;
        private CancellationTokenSource _cts;

        public frmRevenueAnalytics()
        {
            InitializeCustomUI();
            LoadSampleBranches();
        }

        private void InitializeCustomUI()
        {
            Text = "BẢNG ĐIỀU KHIỂN THỐNG KÊ DOANH THU";
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(850, 580);
            Size = new Size(1100, 720);
            BackColor = SystemColors.Control;
            Font = new Font("Segoe UI", 9F);
            AutoScaleMode = AutoScaleMode.Font;

            var root = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                Padding = new Padding(18),
                BackColor = BackColor
            };
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 62));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 190));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 92));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            Controls.Add(root);

            var header = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = SystemColors.Control,
                Padding = new Padding(18, 8, 12, 8)
            };
            var title = new Label
            {
                Text = "THỐNG KÊ DOANH THU",
                Dock = DockStyle.Fill,
                ForeColor = SystemColors.ControlText,
                Font = new Font("Segoe UI", 14F, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleLeft
            };
            header.Controls.Add(title);
            root.Controls.Add(header, 0, 0);

            var criteria = new GroupBox
            {
                Text = "TIÊU CHÍ THỐNG KÊ",
                Dock = DockStyle.Fill,
                Padding = new Padding(14),
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                BackColor = SystemColors.Control
            };
            root.Controls.Add(criteria, 0, 1);

            var grid = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 3,
                Padding = new Padding(8),
                BackColor = SystemColors.Control
            };
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 42));
            grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 42));
            grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            criteria.Controls.Add(grid);

            dtpFromDate = new DateTimePicker
            {
                Name = "dtpFromDate",
                Dock = DockStyle.Fill,
                Format = DateTimePickerFormat.Short,
                Value = DateTime.Today.AddDays(-7),
                Font = new Font("Segoe UI", 10F)
            };
            dtpToDate = new DateTimePicker
            {
                Name = "dtpToDate",
                Dock = DockStyle.Fill,
                Format = DateTimePickerFormat.Short,
                Value = DateTime.Today,
                Font = new Font("Segoe UI", 10F)
            };
            cboBranch = new ComboBox
            {
                Name = "cboBranch",
                Dock = DockStyle.Fill,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10F)
            };

            AddLabel(grid, "Từ ngày:", 0, 0);
            grid.Controls.Add(dtpFromDate, 1, 0);
            AddLabel(grid, "Đến ngày:", 2, 0);
            grid.Controls.Add(dtpToDate, 3, 0);
            AddLabel(grid, "Chi nhánh:", 0, 1);
            grid.Controls.Add(cboBranch, 1, 1);

            var statusGroup = new GroupBox
            {
                Text = "TRẠNG THÁI XỬ LÝ",
                Dock = DockStyle.Fill,
                Padding = new Padding(12),
                BackColor = SystemColors.Control,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            root.Controls.Add(statusGroup, 0, 2);

            var statusLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 2,
                Padding = new Padding(5)
            };
            statusLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 27));
            statusLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            statusGroup.Controls.Add(statusLayout);

            lblProcessingStatus = new Label
            {
                Name = "lblProcessingStatus",
                Text = "Đang chờ thống kê...",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Regular),
                ForeColor = SystemColors.ControlText
            };
            pgbLoading = new ProgressBar
            {
                Name = "pgbLoading",
                Dock = DockStyle.Fill,
                Minimum = 0,
                Maximum = 100,
                Value = 0,
                Style = ProgressBarStyle.Continuous
            };
            statusLayout.Controls.Add(lblProcessingStatus, 0, 0);
            statusLayout.Controls.Add(pgbLoading, 0, 1);

            var resultsGroup = new GroupBox
            {
                Text = "KẾT QUẢ DOANH THU",
                Dock = DockStyle.Fill,
                Padding = new Padding(10),
                BackColor = SystemColors.Control,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            root.Controls.Add(resultsGroup, 0, 3);

            var resultsLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 2,
                Padding = new Padding(4)
            };
            resultsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48));
            resultsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            resultsGroup.Controls.Add(resultsLayout);

            var buttons = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Padding = new Padding(0, 4, 0, 2),
                BackColor = SystemColors.Control
            };
            btnStatistics = new Button
            {
                Name = "btnStatistics",
                Text = "Thống kê doanh thu",
                Size = new Size(190, 36),
                BackColor = SystemColors.Control,
                ForeColor = SystemColors.ControlText,
                FlatStyle = FlatStyle.Standard,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                Cursor = Cursors.Hand
            };
            btnStatistics.UseVisualStyleBackColor = true;
            btnCancel = new Button
            {
                Name = "btnCancel",
                Text = "Hủy thao tác",
                Size = new Size(145, 36),
                BackColor = SystemColors.Control,
                ForeColor = SystemColors.ControlText,
                FlatStyle = FlatStyle.Standard,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                Enabled = false,
                Cursor = Cursors.Hand
            };
            btnCancel.UseVisualStyleBackColor = true;
            buttons.Controls.Add(btnStatistics);
            buttons.Controls.Add(btnCancel);
            resultsLayout.Controls.Add(buttons, 0, 0);

            dgvRevenueData = new DataGridView
            {
                Name = "dgvRevenueData",
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                BackgroundColor = SystemColors.Window,
                BorderStyle = BorderStyle.Fixed3D,
                RowHeadersVisible = false,
                AutoGenerateColumns = true
            };
            dgvRevenueData.EnableHeadersVisualStyles = false;
            dgvRevenueData.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlLight;
            dgvRevenueData.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
            dgvRevenueData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvRevenueData.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvRevenueData.RowTemplate.Height = 29;
            resultsLayout.Controls.Add(dgvRevenueData, 0, 1);

            btnStatistics.Click += btnStatistics_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void AddLabel(TableLayoutPanel panel, string text, int col, int row)
        {
            panel.Controls.Add(new Label
            {
                Text = text,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = SystemColors.ControlText,
                Margin = new Padding(3, 3, 6, 3)
            }, col, row);
        }

        private void LoadSampleBranches()
        {
            cboBranch.Items.Add("Tất cả chi nhánh");
            cboBranch.Items.Add("Chi nhánh Hà Nội");
            cboBranch.Items.Add("Chi nhánh Đà Nẵng");
            cboBranch.Items.Add("Chi nhánh TP.HCM");
            cboBranch.SelectedIndex = 0;
        }

        private async void btnStatistics_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpFromDate.Value.Date;
            DateTime toDate = dtpToDate.Value.Date;
            string selectedBranch = cboBranch.SelectedItem?.ToString() ?? "Tất cả chi nhánh";

            if (fromDate > toDate)
            {
                MessageBox.Show("Từ ngày không được lớn hơn đến ngày!",
                    "Kiểm tra dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_cts != null)
                return;

            _cts = new CancellationTokenSource();
            CancellationTokenSource currentCts = _cts;
            CancellationToken token = currentCts.Token;

            btnStatistics.Enabled = false;
            btnCancel.Enabled = true;
            dtpFromDate.Enabled = false;
            dtpToDate.Enabled = false;
            cboBranch.Enabled = false;
            pgbLoading.Value = 0;
            lblProcessingStatus.Text = "Đang bắt đầu thống kê...";

            try
            {
                IProgress<int> progress = new Progress<int>(value =>
                {
                    pgbLoading.Value = Math.Max(0, Math.Min(100, value));
                    lblProcessingStatus.Text = $"Đang tổng hợp dữ liệu... {value}%";
                });

                DataTable result = await Task.Run(async () =>
                {
                    for (int i = 0; i <= 100; i++)
                    {
                        token.ThrowIfCancellationRequested();
                        await Task.Delay(50, token);
                        progress.Report(i);
                    }

                    token.ThrowIfCancellationRequested();
                    return CreateSampleRevenueData(fromDate, toDate, selectedBranch, token);
                }, token);

                dgvRevenueData.DataSource = result;
                if (dgvRevenueData.Columns["SoTien"] != null)
                    dgvRevenueData.Columns["SoTien"].DefaultCellStyle.Format = "N0";

                lblProcessingStatus.Text = $"Hoàn tất! Đã tạo {result.Rows.Count} giao dịch mẫu.";
                pgbLoading.Value = 100;
            }
            catch (OperationCanceledException)
            {
                pgbLoading.Value = 0;
                lblProcessingStatus.Text = "Đã hủy thao tác!";
                MessageBox.Show("Đã hủy thao tác!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                pgbLoading.Value = 0;
                lblProcessingStatus.Text = "Có lỗi xảy ra.";
                MessageBox.Show("Lỗi thống kê: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnStatistics.Enabled = true;
                btnCancel.Enabled = false;
                dtpFromDate.Enabled = true;
                dtpToDate.Enabled = true;
                cboBranch.Enabled = true;

                currentCts.Dispose();
                if (ReferenceEquals(_cts, currentCts))
                    _cts = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_cts != null)
            {
                btnCancel.Enabled = false;
                lblProcessingStatus.Text = "Đang yêu cầu hủy thao tác...";
                _cts.Cancel();
            }
        }

        private DataTable CreateSampleRevenueData(
            DateTime fromDate,
            DateTime toDate,
            string selectedBranch,
            CancellationToken token)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaGiaoDich", typeof(string));
            table.Columns.Add("NgayGiaoDich", typeof(DateTime));
            table.Columns.Add("ChiNhanh", typeof(string));
            table.Columns.Add("NoiDung", typeof(string));
            table.Columns.Add("SoTien", typeof(decimal));

            string[] branches =
            {
                "Chi nhánh Hà Nội",
                "Chi nhánh Đà Nẵng",
                "Chi nhánh TP.HCM"
            };

            Random random = new Random();
            int days = (toDate - fromDate).Days;

            for (int i = 1; i <= 30; i++)
            {
                token.ThrowIfCancellationRequested();
                string branch = branches[random.Next(branches.Length)];

                if (selectedBranch != "Tất cả chi nhánh" &&
                    branch != selectedBranch)
                    continue;

                DateTime transactionDate = fromDate.AddDays(random.Next(days + 1));
                table.Rows.Add(
                    "GD" + i.ToString("D3"),
                    transactionDate,
                    branch,
                    "Thanh toán dịch vụ",
                    random.Next(100, 5001) * 1000m);
            }

            return table;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_cts != null)
                _cts.Cancel();

            base.OnFormClosing(e);
        }
    }
}
