
using System;
using System.ComponentModel;

namespace code
{
    public class BookModel : INotifyPropertyChanged
    {
        private string bookId = "";
        private string title = "";
        private string author = "";
        private string category = "";
        private int quantity;
        private decimal price;
        private string coverPath = "";

        public string BookId
        {
            get => bookId;
            set { bookId = value; OnPropertyChanged(nameof(BookId)); }
        }

        public string Title
        {
            get => title;
            set { title = value; OnPropertyChanged(nameof(Title)); }
        }

        public string Author
        {
            get => author;
            set { author = value; OnPropertyChanged(nameof(Author)); }
        }

        public string Category
        {
            get => category;
            set { category = value; OnPropertyChanged(nameof(Category)); }
        }

        public int Quantity
        {
            get => quantity;
            set { quantity = value; OnPropertyChanged(nameof(Quantity)); }
        }

        public decimal Price
        {
            get => price;
            set { price = value; OnPropertyChanged(nameof(Price)); }
        }

        public string CoverPath
        {
            get => coverPath;
            set { coverPath = value; OnPropertyChanged(nameof(CoverPath)); }
        }

        public decimal TotalValue => Quantity * Price;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(
                this, new PropertyChangedEventArgs(propertyName));

            if (propertyName == nameof(Quantity) ||
                propertyName == nameof(Price))
            {
                PropertyChanged?.Invoke(
                    this, new PropertyChangedEventArgs(nameof(TotalValue)));
            }
        }
    }
}
