namespace Code
{
    public partial class frmHospitalMain : Form
    {
        private void OpenChildForm<T>() where T : Form, new()
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is T)
                {
                    if (child.WindowState == FormWindowState.Minimized)
                        child.WindowState = FormWindowState.Normal;

                    child.Activate();
                    return;
                }
            }

            T form = new T();
            form.MdiParent = this;
            form.Show();
        }
        public frmHospitalMain()
        {
            InitializeComponent();

            lblDutyDoctor.Text = "Bác sĩ trực: Nguyễn Văn A";
            progressBar.Value = 0;
        }

        private void mnuPatientProfiles_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmPatientProfiles>();
        }

        private void mnuDoctorSchedule_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmDoctorSchedule>();
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
        "Bạn có muốn thoát chương trình không?",
        "Xác nhận",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            MessageBox.Show("Bạn đã đăng xuất khỏi hệ thống.");
        }

        private void mnuReload_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;

            progressBar.Value = 50;
            Application.DoEvents();

            progressBar.Value = 100;

            MessageBox.Show("Đã nạp lại dữ liệu.");
            progressBar.Value = 0;
        }
    }
}
