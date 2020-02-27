using data_models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace datagrid_simple
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ObservableCollection<Product> products;

        public ObservableCollection<Product> Products { 
            get => products;
            set
            {
                products = value;
                OnPropertyChanged();
            }
        }

        private void InitValues()
        {
            Products = new ObservableCollection<Product>() {
                new Product() {UPC = "523438", Code = "TUE354", ShortDescription = "cubilia Curae; Donec tincidunt.", Description = "pede, nonummy ut, molestie in, tempus eu, ligula. Aenean",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "536976", Code = "CWQ999", ShortDescription = "enim. Nunc", Description = "malesuada malesuada. Integer id magna et ipsum cursus vestibulum. Mauris",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "762723", Code = "XVA415", ShortDescription = "nisi a", Description = "cursus et, magna. Praesent interdum ligula eu enim. Etiam",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "146509", Code = "YWC365", ShortDescription = "Quisque ornare tortor", Description = "vel, venenatis vel, faucibus id, libero. Donec consectetuer mauris",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "911706", Code = "LSF234", ShortDescription = "luctus vulputate, nisi", Description = "et ultrices posuere cubilia Curae;",Category = "Clothing", PicturePath = "images/product.png"},
            };
        }

        public MainWindow()
        {
            InitializeComponent();
            InitValues();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }
}
