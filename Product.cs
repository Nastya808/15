using System.ComponentModel;

namespace WpfApp1
{
    public class Product : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        private decimal count;

        public decimal Count
        {
            get => count;
            set
            {
                count = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Count)));
            }
        }

        public string ImageUrl { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
