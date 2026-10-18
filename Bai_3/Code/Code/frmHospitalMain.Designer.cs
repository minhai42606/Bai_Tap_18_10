namespace Code
{
    partial class frmHospitalMain
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
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            mnuLogout = new ToolStripMenuItem();
            mnuReload = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            mnuPatientProfiles = new ToolStripMenuItem();
            mnuDoctors = new ToolStripMenuItem();
            mnuDepartments = new ToolStripMenuItem();
            mnuDoctorSchedule = new ToolStripMenuItem();
            cửaSổToolStripMenuItem = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            mnuTileHorizontal = new ToolStripMenuItem();
            mnuTileVertical = new ToolStripMenuItem();
            mnuCloseAll = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblDutyDoctor = new ToolStripStatusLabel();
            progressBar = new ToolStripProgressBar();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýToolStripMenuItem, cửaSổToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuLogout, mnuReload, mnuExit });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnuLogout
            // 
            mnuLogout.Name = "mnuLogout";
            mnuLogout.Size = new Size(224, 26);
            mnuLogout.Text = "Đăng xuất";
            mnuLogout.Click += mnuLogout_Click;
            // 
            // mnuReload
            // 
            mnuReload.Name = "mnuReload";
            mnuReload.Size = new Size(224, 26);
            mnuReload.Text = "Nạp lại dữ liệu";
            mnuReload.Click += mnuReload_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(224, 26);
            mnuExit.Text = "Thoát";
            mnuExit.Click += mnuExit_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuPatientProfiles, mnuDoctors, mnuDepartments, mnuDoctorSchedule });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(73, 24);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // mnuPatientProfiles
            // 
            mnuPatientProfiles.Name = "mnuPatientProfiles";
            mnuPatientProfiles.Size = new Size(244, 26);
            mnuPatientProfiles.Text = "Hồ sơ bệnh nhân";
            mnuPatientProfiles.Click += mnuPatientProfiles_Click;
            // 
            // mnuDoctors
            // 
            mnuDoctors.Name = "mnuDoctors";
            mnuDoctors.Size = new Size(244, 26);
            mnuDoctors.Text = "Danh mục bác sĩ";
            // 
            // mnuDepartments
            // 
            mnuDepartments.Name = "mnuDepartments";
            mnuDepartments.Size = new Size(244, 26);
            mnuDepartments.Text = "Danh mục khóa/phòng";
            // 
            // mnuDoctorSchedule
            // 
            mnuDoctorSchedule.Name = "mnuDoctorSchedule";
            mnuDoctorSchedule.Size = new Size(244, 26);
            mnuDoctorSchedule.Text = "Lịch trực bác sĩ";
            mnuDoctorSchedule.Click += mnuDoctorSchedule_Click;
            // 
            // cửaSổToolStripMenuItem
            // 
            cửaSổToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuTileHorizontal, mnuTileVertical, mnuCloseAll });
            cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            cửaSổToolStripMenuItem.Size = new Size(68, 24);
            cửaSổToolStripMenuItem.Text = "Cửa sổ";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(170, 26);
            mnuCascade.Text = "Xếp tầng";
            mnuCascade.Click += mnuCascade_Click;
            // 
            // mnuTileHorizontal
            // 
            mnuTileHorizontal.Name = "mnuTileHorizontal";
            mnuTileHorizontal.Size = new Size(170, 26);
            mnuTileHorizontal.Text = "Ngang";
            mnuTileHorizontal.Click += mnuTileHorizontal_Click;
            // 
            // mnuTileVertical
            // 
            mnuTileVertical.Name = "mnuTileVertical";
            mnuTileVertical.Size = new Size(170, 26);
            mnuTileVertical.Text = "Dọc";
            mnuTileVertical.Click += mnuTileVertical_Click;
            // 
            // mnuCloseAll
            // 
            mnuCloseAll.Name = "mnuCloseAll";
            mnuCloseAll.Size = new Size(170, 26);
            mnuCloseAll.Text = "Đóng tất cả";
            mnuCloseAll.Click += mnuCloseAll_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblDutyDoctor, progressBar });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblDutyDoctor
            // 
            lblDutyDoctor.Name = "lblDutyDoctor";
            lblDutyDoctor.Size = new Size(190, 20);
            lblDutyDoctor.Text = "Bác sĩ trực: chưa phân công";
            // 
            // progressBar
            // 
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(100, 18);
            // 
            // frmHospitalMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmHospitalMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý bệnh viện";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem mnuLogout;
        private ToolStripMenuItem mnuReload;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem mnuPatientProfiles;
        private ToolStripMenuItem mnuDoctors;
        private ToolStripMenuItem mnuDepartments;
        private ToolStripMenuItem mnuDoctorSchedule;
        private ToolStripMenuItem cửaSổToolStripMenuItem;
        private ToolStripMenuItem mnuCascade;
        private ToolStripMenuItem mnuTileHorizontal;
        private ToolStripMenuItem mnuTileVertical;
        private ToolStripMenuItem mnuCloseAll;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblDutyDoctor;
        private ToolStripProgressBar progressBar;
    }
}
