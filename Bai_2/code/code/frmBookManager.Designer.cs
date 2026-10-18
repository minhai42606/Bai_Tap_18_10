namespace code
{
    partial class frmBookManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookManager));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            mnuOpenCsv = new ToolStripMenuItem();
            mnuSaveCsv = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            mnuAdd = new ToolStripMenuItem();
            mnuDelete = new ToolStripMenuItem();
            mnuSearch = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbOpen = new ToolStripButton();
            tsbSave = new ToolStripButton();
            tsbAdd = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblTotalBooks = new ToolStripStatusLabel();
            lblTotalValue = new ToolStripStatusLabel();
            lblCurrentTime = new ToolStripStatusLabel();
            brpBookInfo = new GroupBox();
            btnLoadCover = new Button();
            picBookCover = new PictureBox();
            nudPrice = new NumericUpDown();
            nudQuantity = new NumericUpDown();
            txtCategory = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            txtBookId = new TextBox();
            lblPrice = new Label();
            lblCategory = new Label();
            lblTitle = new Label();
            lblQuantity = new Label();
            lblAuthor = new Label();
            lblBookId = new Label();
            grbBookList = new GroupBox();
            dgvBooks = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            lblSearch1 = new Label();
            txtSearch = new TextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            brpBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBookCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            grbBookList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1082, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuOpenCsv, mnuSaveCsv, mnuExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // mnuOpenCsv
            // 
            mnuOpenCsv.Name = "mnuOpenCsv";
            mnuOpenCsv.Size = new Size(171, 26);
            mnuOpenCsv.Text = "Mở file CSV";
            // 
            // mnuSaveCsv
            // 
            mnuSaveCsv.Name = "mnuSaveCsv";
            mnuSaveCsv.Size = new Size(171, 26);
            mnuSaveCsv.Text = "Lưu file CSV";
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(171, 26);
            mnuExit.Text = "Thoát";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuAdd, mnuDelete, mnuSearch });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // mnuAdd
            // 
            mnuAdd.Name = "mnuAdd";
            mnuAdd.Size = new Size(224, 26);
            mnuAdd.Text = "Thêm";
            mnuAdd.Click += mnuAdd_Click;
            // 
            // mnuDelete
            // 
            mnuDelete.Name = "mnuDelete";
            mnuDelete.Size = new Size(224, 26);
            mnuDelete.Text = "Xóa";
            mnuDelete.Click += mnuDelete_Click;
            // 
            // mnuSearch
            // 
            mnuSearch.Name = "mnuSearch";
            mnuSearch.Size = new Size(224, 26);
            mnuSearch.Text = "Tìm kiếm";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbOpen, tsbSave, tsbAdd });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1082, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            tsbOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbOpen.Image = (Image)resources.GetObject("tsbOpen.Image");
            tsbOpen.ImageTransparentColor = Color.Magenta;
            tsbOpen.Name = "tsbOpen";
            tsbOpen.Size = new Size(29, 24);
            tsbOpen.Text = "Mở file";
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (Image)resources.GetObject("tsbSave.Image");
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(29, 24);
            tsbSave.Text = "Lưu file";
            // 
            // tsbAdd
            // 
            tsbAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(29, 24);
            tsbAdd.Text = "Thêm mới";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTotalBooks, lblTotalValue, lblCurrentTime });
            statusStrip1.Location = new Point(0, 677);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1082, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTotalBooks
            // 
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(139, 20);
            lblTotalBooks.Text = "Tống số đầu sách: 0";
            // 
            // lblTotalValue
            // 
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(140, 20);
            lblTotalValue.Text = "Tổng giá trị kho: 0Đ";
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(116, 20);
            lblCurrentTime.Text = "Thời gian:--:--:--";
            // 
            // brpBookInfo
            // 
            brpBookInfo.Controls.Add(txtSearch);
            brpBookInfo.Controls.Add(lblSearch1);
            brpBookInfo.Controls.Add(btnLoadCover);
            brpBookInfo.Controls.Add(picBookCover);
            brpBookInfo.Controls.Add(nudPrice);
            brpBookInfo.Controls.Add(nudQuantity);
            brpBookInfo.Controls.Add(txtCategory);
            brpBookInfo.Controls.Add(txtAuthor);
            brpBookInfo.Controls.Add(txtTitle);
            brpBookInfo.Controls.Add(txtBookId);
            brpBookInfo.Controls.Add(lblPrice);
            brpBookInfo.Controls.Add(lblCategory);
            brpBookInfo.Controls.Add(lblTitle);
            brpBookInfo.Controls.Add(lblQuantity);
            brpBookInfo.Controls.Add(lblAuthor);
            brpBookInfo.Controls.Add(lblBookId);
            brpBookInfo.Location = new Point(12, 58);
            brpBookInfo.Name = "brpBookInfo";
            brpBookInfo.Size = new Size(1058, 253);
            brpBookInfo.TabIndex = 3;
            brpBookInfo.TabStop = false;
            brpBookInfo.Text = "Thông tin sách";
            // 
            // btnLoadCover
            // 
            btnLoadCover.Location = new Point(885, 141);
            btnLoadCover.Name = "btnLoadCover";
            btnLoadCover.Size = new Size(106, 48);
            btnLoadCover.TabIndex = 13;
            btnLoadCover.Text = "Tải ảnh bìa";
            btnLoadCover.UseVisualStyleBackColor = true;
            btnLoadCover.Click += btnLoadCover_Click;
            // 
            // picBookCover
            // 
            picBookCover.BorderStyle = BorderStyle.FixedSingle;
            picBookCover.Location = new Point(869, 26);
            picBookCover.Name = "picBookCover";
            picBookCover.Size = new Size(143, 109);
            picBookCover.SizeMode = PictureBoxSizeMode.Zoom;
            picBookCover.TabIndex = 12;
            picBookCover.TabStop = false;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(551, 136);
            nudPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(201, 27);
            nudPrice.TabIndex = 11;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(162, 138);
            nudQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(208, 27);
            nudQuantity.TabIndex = 10;
            // 
            // txtCategory
            // 
            txtCategory.BorderStyle = BorderStyle.FixedSingle;
            txtCategory.Location = new Point(551, 88);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(201, 27);
            txtCategory.TabIndex = 9;
            // 
            // txtAuthor
            // 
            txtAuthor.BorderStyle = BorderStyle.FixedSingle;
            txtAuthor.Location = new Point(162, 91);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(208, 27);
            txtAuthor.TabIndex = 8;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Location = new Point(551, 45);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(201, 27);
            txtTitle.TabIndex = 7;
            // 
            // txtBookId
            // 
            txtBookId.BorderStyle = BorderStyle.FixedSingle;
            txtBookId.Location = new Point(162, 41);
            txtBookId.Name = "txtBookId";
            txtBookId.ReadOnly = true;
            txtBookId.Size = new Size(208, 27);
            txtBookId.TabIndex = 6;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(455, 138);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(62, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Đơn giá";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(455, 91);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(62, 20);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Thể loại";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(455, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(65, 20);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Tên sách";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(72, 138);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(69, 20);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Số lượng";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(72, 91);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(55, 20);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "Tác giả";
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Location = new Point(72, 41);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(63, 20);
            lblBookId.TabIndex = 0;
            lblBookId.Text = "Mã sách";
            // 
            // grbBookList
            // 
            grbBookList.Controls.Add(dgvBooks);
            grbBookList.Location = new Point(12, 352);
            grbBookList.Name = "grbBookList";
            grbBookList.Size = new Size(1058, 322);
            grbBookList.TabIndex = 4;
            grbBookList.TabStop = false;
            grbBookList.Text = "Danh sách sách";
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(27, 44);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(1001, 272);
            dgvBooks.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblSearch1
            // 
            lblSearch1.AutoSize = true;
            lblSearch1.Location = new Point(86, 202);
            lblSearch1.Name = "lblSearch1";
            lblSearch1.Size = new Size(168, 20);
            lblSearch1.TabIndex = 14;
            lblSearch1.Text = "Nhập tên sách tìm kiếm:";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(274, 200);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(196, 27);
            txtSearch.TabIndex = 15;
            // 
            // frmBookManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 703);
            Controls.Add(grbBookList);
            Controls.Add(brpBookInfo);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmBookManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý tài liệu sách";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            brpBookInfo.ResumeLayout(false);
            brpBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBookCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            grbBookList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem mnuOpenCsv;
        private ToolStripMenuItem mnuSaveCsv;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem mnuAdd;
        private ToolStripMenuItem mnuDelete;
        private ToolStripMenuItem mnuSearch;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbOpen;
        private ToolStripButton tsbSave;
        private ToolStripButton tsbAdd;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTotalBooks;
        private ToolStripStatusLabel lblTotalValue;
        private ToolStripStatusLabel lblCurrentTime;
        private GroupBox brpBookInfo;
        private GroupBox grbBookList;
        private Label lblPrice;
        private Label lblCategory;
        private Label lblTitle;
        private Label lblQuantity;
        private Label lblAuthor;
        private Label lblBookId;
        private NumericUpDown nudPrice;
        private NumericUpDown nudQuantity;
        private TextBox txtCategory;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private TextBox txtBookId;
        private PictureBox picBookCover;
        private DataGridView dgvBooks;
        private System.Windows.Forms.Timer timer1;
        private Button btnLoadCover;
        private Label lblSearch1;
        private TextBox txtSearch;
    }
}
