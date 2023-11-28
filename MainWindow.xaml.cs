using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Text;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private List<Product> cartProducts;
        private DataSource dataSource;

        public MainWindow()
        {
            InitializeComponent();
            cartProducts = new List<Product>();
            dataSource = new DataSource();
            this.DataContext = dataSource;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is Product selectedProduct)
            {
                dataSource.TotalSum += selectedProduct.Price;
                dataSource.ProductsCount++;
                selectedProduct.Count--;

                var existingProduct = cartProducts.Find(p => p.Name.Equals(selectedProduct.Name));
                if (existingProduct != null)
                {
                    existingProduct.Count++;
                }
                else
                {
                    cartProducts.Add(new Product
                    {
                        Count = 1,
                        Name = selectedProduct.Name,
                        Price = selectedProduct.Price
                    });
                }
            }
        }
    }
}
