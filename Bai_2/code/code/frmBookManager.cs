using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace code
{
    public partial class frmBookManager : Form
    {

        private BindingList<BookModel> books = new BindingList<BookModel>();

        private BindingSource bookSource = new BindingSource();

        private string currentCoverPath = "";
        private bool isLoading = false;
        public frmBookManager()
        {
            InitializeComponent();

            ConfigureGrid();
            BindData();
            UpdateStatus();
            UpdateCurrentTime();

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void ConfigureGrid()
        {
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.Columns.Clear();

            dgvBooks.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.MultiSelect = false;
            dgvBooks.ReadOnly = true;
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colBookId",
                HeaderText = "Mã sách",
                DataPropertyName = "BookId"
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTitle",
                HeaderText = "Tên sách",
                DataPropertyName = "Title",
                FillWeight = 160
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAuthor",
                HeaderText = "Tác giả",
                DataPropertyName = "Author"
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategory",
                HeaderText = "Thể loại",
                DataPropertyName = "Category"
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colQuantity",
                HeaderText = "Số lượng",
                DataPropertyName = "Quantity"
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrice",
                HeaderText = "Đơn giá",
                DataPropertyName = "Price",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0"
                }
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCoverPath",
                HeaderText = "Tên file ảnh",
                DataPropertyName = "CoverPath",
                FillWeight = 100
            });
        }
        private void BindData()
        {
            bookSource.DataSource = books;
            dgvBooks.DataSource = bookSource;
        }
        private string GenerateBookId()
        {
            int maxId = 0;

            foreach (BookModel b in books)
            {
                if (b.BookId.StartsWith("S") &&
                    int.TryParse(b.BookId.Substring(1), out int n))
                {
                    maxId = Math.Max(maxId, n);
                }
            }

            return "S" + (maxId + 1).ToString("D3");
        }
        private void UpdateStatus()
        {
            lblTotalBooks.Text =
                "Tổng số đầu sách: " + books.Count;

            decimal total = books.Sum(b => b.TotalValue);

            lblTotalValue.Text =
                "Tổng giá trị kho: " +
                total.ToString("N0") + " đ";
        }

        private void UpdateCurrentTime()
        {
            lblCurrentTime.Text =
                "Thời gian: " + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateCurrentTime();
        }



        private void btnLoadCover_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Chọn ảnh bìa sách";
                dlg.Filter =
                    "Ảnh sách (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
                dlg.Multiselect = false;

                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    // Đọc ảnh vào bộ nhớ để không khóa file gốc.
                    using (var fs = new FileStream(
                        dlg.FileName, FileMode.Open, FileAccess.Read))
                    using (var ms = new MemoryStream())
                    {
                        fs.CopyTo(ms);
                        ms.Position = 0;

                        using (var temp = Image.FromStream(ms))
                        {
                            var newImage = new Bitmap(temp);

                            var oldImage = picBookCover.Image;
                            picBookCover.Image = newImage;
                            oldImage?.Dispose();
                        }
                    }

                    currentCoverPath = dlg.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Không thể tải ảnh: " + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private void ResetForm()
        {
            isLoading = true;

            txtBookId.Text = GenerateBookId();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtCategory.Clear();

            nudQuantity.Value = 0;
            nudPrice.Value = 0;

            currentCoverPath = "";

            var oldImage = picBookCover.Image;
            picBookCover.Image = null;
            oldImage?.Dispose();

            isLoading = false;
        }

        private void AddBook()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sách.");
                txtTitle.Focus();
                return;
            }

            BookModel b = new BookModel
            {
                BookId = GenerateBookId(),
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                Category = txtCategory.Text.Trim(),
                Quantity = (int)nudQuantity.Value,
                Price = nudPrice.Value,
                CoverPath = currentCoverPath
            };

            books.Add(b);

            UpdateStatus();
            ResetForm();
        }
        private void mnuAdd_Click(object sender, EventArgs e)
        {
            AddBook();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddBook();
        }


        private void DeleteBook()
        {
            if (dgvBooks.CurrentRow?.DataBoundItem is not BookModel b)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sách \"" + b.Title + "\"?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            books.Remove(b);

            UpdateStatus();
            ResetForm();
        }
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            DeleteBook();
        }

        private string CsvEscape(string value)
        {
            value = value ?? "";

            if (value.Contains(",") ||
                value.Contains("\"") ||
                value.Contains("\r") ||
                value.Contains("\n"))
            {
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            }

            return value;
        }

        private void SaveCsv()
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Lưu danh sách sách";
                dlg.Filter = "CSV files (*.csv)|*.csv";
                dlg.DefaultExt = "csv";
                dlg.AddExtension = true;
                dlg.FileName = "DanhSachSach.csv";

                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (StreamWriter sw = new StreamWriter(
                        dlg.FileName, false, new UTF8Encoding(true)))
                    {
                        sw.WriteLine(
                            "BookId,Title,Author,Category,Quantity,Price,CoverPath");

                        foreach (BookModel b in books)
                        {
                            string[] fields =
                            {
                        b.BookId,
                        b.Title,
                        b.Author,
                        b.Category,
                        b.Quantity.ToString(CultureInfo.InvariantCulture),
                        b.Price.ToString(CultureInfo.InvariantCulture),
                        b.CoverPath
                    };

                            sw.WriteLine(string.Join(
                                ",", fields.Select(CsvEscape)));
                        }
                    }

                    MessageBox.Show("Lưu file CSV thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu CSV: " + ex.Message);
                }
            }
        }

        private void mnuSaveCsv_Click(object sender, EventArgs e)
        {
            SaveCsv();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveCsv();
        }


        private string[] ParseCsvLine(string line)
        {
            var fields = new System.Collections.Generic.List<string>();
            var current = new StringBuilder();
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (c == '"')
                {
                    if (inQuotes && i + 1 < line.Length &&
                        line[i + 1] == '"')
                    {
                        current.Append('"');
                        i++;
                    }
                    else
                    {
                        inQuotes = !inQuotes;
                    }
                }
                else if (c == ',' && !inQuotes)
                {
                    fields.Add(current.ToString());
                    current.Clear();
                }
                else
                {
                    current.Append(c);
                }
            }

            if (inQuotes)
                throw new FormatException("Dòng CSV có dấu ngoặc kép không hợp lệ.");

            fields.Add(current.ToString());
            return fields.ToArray();
        }

        private void OpenCsv()
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Mở danh sách sách";
                dlg.Filter = "CSV files (*.csv)|*.csv";
                dlg.Multiselect = false;

                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    var imported = new System.Collections.Generic.List<BookModel>();

                    using (StreamReader sr = new StreamReader(
                        dlg.FileName, Encoding.UTF8, true))
                    {
                        string header = sr.ReadLine();

                        if (header == null)
                            throw new FormatException("File CSV trống.");

                        string line;
                        int lineNumber = 1;

                        while ((line = sr.ReadLine()) != null)
                        {
                            lineNumber++;

                            if (string.IsNullOrWhiteSpace(line))
                                continue;

                            string[] f = ParseCsvLine(line);

                            if (f.Length != 7)
                            {
                                throw new FormatException(
                                    "Dòng " + lineNumber +
                                    " không có đủ 7 trường.");
                            }

                            if (!int.TryParse(
                                f[4], NumberStyles.Integer,
                                CultureInfo.InvariantCulture, out int quantity)
                                || quantity < 0)
                            {
                                throw new FormatException(
                                    "Số lượng không hợp lệ ở dòng " + lineNumber);
                            }

                            if (!decimal.TryParse(
                                f[5], NumberStyles.Number,
                                CultureInfo.InvariantCulture, out decimal price)
                                || price < 0)
                            {
                                throw new FormatException(
                                    "Đơn giá không hợp lệ ở dòng " + lineNumber);
                            }

                            imported.Add(new BookModel
                            {
                                BookId = f[0],
                                Title = f[1],
                                Author = f[2],
                                Category = f[3],
                                Quantity = quantity,
                                Price = price,
                                CoverPath = f[6]
                            });
                        }
                    }

                    // Chỉ thay danh sách hiện tại sau khi đọc thành công.
                    books.RaiseListChangedEvents = false;
                    try
                    {
                        books.Clear();

                        foreach (BookModel b in imported)
                            books.Add(b);
                    }
                    finally
                    {
                        books.RaiseListChangedEvents = true;
                        bookSource.ResetBindings(false);
                    }

                    UpdateStatus();
                    ResetForm();

                    MessageBox.Show("Đã nhập " + imported.Count +
                        " đầu sách từ file CSV.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Không thể nhập file CSV: " + ex.Message,
                        "Lỗi nhập dữ liệu",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private void mnuOpenCsv_Click(object sender, EventArgs e)
        {
            OpenCsv();
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            OpenCsv();
        }


        private void SearchBooks()
        {
            string keyword = txtSearch.Text.Trim();

            var result = books
                .Where(b =>
                    b.Title.IndexOf(
                        keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    b.Author.IndexOf(
                        keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            bookSource.DataSource = new BindingList<BookModel>(result);
            dgvBooks.DataSource = bookSource;

            lblTotalBooks.Text = "Số kết quả: " + result.Count;
        }

        private void mnuSearch_Click(object sender, EventArgs e)
        {
            SearchBooks();
        }

        private void ShowAllBooks()
        {
            bookSource.DataSource = books;
            dgvBooks.DataSource = bookSource;
            UpdateStatus();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
