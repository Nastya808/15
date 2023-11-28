using System.Collections.Generic;
using System.ComponentModel;

namespace WpfApp1
{
    public class DataSource : INotifyPropertyChanged
    {
        public IEnumerable<Product> Products { get; set; }
        private decimal totalSum;

        public decimal TotalSum
        {
            get => totalSum;
            set
            {
                totalSum = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(TotalSum)));
            }
        }

        private int productsCount;

        public int ProductsCount
        {
            get => productsCount;
            set
            {
                productsCount = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(ProductsCount)));
            }
        }

        public DataSource()
        {
            Products = new[]
            {
                new Product{ Name = "Apple", Count = 50, Price = 15, ImageUrl = "/Images/apple.png"},
                new Product{ Name = "Orange", Count = 123, Price = 55, ImageUrl = "/Images/orange.png"},
                new Product{ Name = "Cherry", Count = 76, Price = 75, ImageUrl = "/Images/cherry.png"}
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
