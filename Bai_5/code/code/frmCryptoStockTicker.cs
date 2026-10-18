
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace code
{
    public partial class frmCryptoStockTicker : Form
    {
        private Button btnStart;
        private Button btnPause;
        private Label lblBTCPrice;
        private DataGridView dgvHistoryLog;
        private ToolStripStatusLabel lblLastUpdate;
        private ToolStripStatusLabel lblSyncCount;

        private CancellationTokenSource cts;
        private decimal lastPrice = 65000m;
        private int syncCount = 0;
        private readonly Random random = new Random();

        public frmCryptoStockTicker()
        {
            InitializeComponent();
            BuildInterface();
        }

        private void BuildInterface()
        {
            Text = "Giám sát tỷ giá BTC/USD";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(900, 600);
            MinimumSize = new Size(700, 450);
            Font = new Font("Segoe UI", 10);
            BackColor = SystemColors.Control;

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(12),
                ColumnCount = 1,
                RowCount = 4
            };

            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 75));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 110));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            Controls.Add(layout);

            var title = new Label
            {
                Text = "GIÁM SÁT TỶ GIÁ BTC/USD",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };
            layout.Controls.Add(title, 0, 0);

            var groupControl = new GroupBox
            {
                Text = "Điều khiển",
                Dock = DockStyle.Fill
            };
            layout.Controls.Add(groupControl, 0, 1);

            btnStart = new Button
            {
                Text = "Bắt đầu giám sát",
                Location = new Point(15, 27),
                Size = new Size(150, 32)
            };

            btnPause = new Button
            {
                Text = "Tạm dừng",
                Location = new Point(175, 27),
                Size = new Size(120, 32),
                Enabled = false
            };

            groupControl.Controls.Add(btnStart);
            groupControl.Controls.Add(btnPause);

            var groupPrice = new GroupBox
            {
                Text = "Tỷ giá hiện tại",
                Dock = DockStyle.Fill
            };
            layout.Controls.Add(groupPrice, 0, 2);

            lblBTCPrice = new Label
            {
                Name = "lblBTCPrice",
                Text = "BTC/USD: $65,000.00",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 20)
            };
            groupPrice.Controls.Add(lblBTCPrice);

            var groupHistory = new GroupBox
            {
                Text = "Lịch sử biến động giá",
                Dock = DockStyle.Fill
            };
            layout.Controls.Add(groupHistory, 0, 3);

            dgvHistoryLog = new DataGridView
            {
                Name = "dgvHistoryLog",
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                BackgroundColor = SystemColors.Window
            };

            dgvHistoryLog.Columns.Add("Time", "Thời gian");
            dgvHistoryLog.Columns.Add("Price", "Giá BTC/USD");
            dgvHistoryLog.Columns.Add("Change", "Biến động");

            groupHistory.Controls.Add(dgvHistoryLog);

            var status = new StatusStrip();

            lblLastUpdate = new ToolStripStatusLabel(
                "Cập nhật lần cuối: --:--:--");

            lblSyncCount = new ToolStripStatusLabel(
                "Số lượt đồng bộ: 0");

            status.Items.Add(lblLastUpdate);
            status.Items.Add(new ToolStripStatusLabel(" | "));
            status.Items.Add(lblSyncCount);

            Controls.Add(status);
            status.Dock = DockStyle.Bottom;

            btnStart.Click += btnStart_Click;
            btnPause.Click += btnPause_Click;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (cts != null)
                return;

            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            btnStart.Enabled = false;
            btnPause.Enabled = true;

            try
            {
                await Task.Run(async () =>
                {
                    while (true)
                    {
                        token.ThrowIfCancellationRequested();

                        decimal oldPrice = lastPrice;
                        decimal newPrice;

                        lock (random)
                        {
                            decimal change =
                                (decimal)(random.NextDouble() * 0.04 - 0.02);

                            newPrice = Math.Round(
                                oldPrice * (1 + change), 2);
                        }

                        lastPrice = newPrice;

                        int count = Interlocked.Increment(
                            ref syncCount);

                        DateTime now = DateTime.Now;

                        
                        if (IsDisposed || !IsHandleCreated)
                            break;

                        Invoke(new Action(() =>
                        {
                            if (IsDisposed)
                                return;

                            lblBTCPrice.Text =
                                $"BTC/USD: ${newPrice:N2}";

                            lblBTCPrice.ForeColor =
                                newPrice > oldPrice
                                ? Color.Green
                                : newPrice < oldPrice
                                    ? Color.Red
                                    : SystemColors.ControlText;

                            lblLastUpdate.Text =
                                "Cập nhật lần cuối: " +
                                now.ToString("HH:mm:ss");

                            lblSyncCount.Text =
                                "Số lượt đồng bộ: " + count;

                            dgvHistoryLog.Rows.Insert(
                                0,
                                now.ToString("HH:mm:ss"),
                                newPrice.ToString("N2"),
                                (newPrice - oldPrice).ToString(
                                    "+0.00;-0.00;0.00"));

                            
                            if (dgvHistoryLog.Rows.Count > 200)
                            {
                                dgvHistoryLog.Rows.RemoveAt(
                                    dgvHistoryLog.Rows.Count - 1);
                            }
                        }));

                        await Task.Delay(2000, token);
                    }
                }, token);
            }
            catch (OperationCanceledException)
            {
                
            }
            catch (InvalidOperationException)
            {
                
            }
            finally
            {
                cts?.Dispose();
                cts = null;

                if (!IsDisposed)
                {
                    btnStart.Enabled = true;
                    btnPause.Enabled = false;
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
            btnPause.Enabled = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            cts?.Cancel();
            base.OnFormClosing(e);
        }
    }
}
