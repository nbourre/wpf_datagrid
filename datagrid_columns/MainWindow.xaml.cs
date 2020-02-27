using data_models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace datagrid_columns
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        ObservableCollection<User> users;

        public ObservableCollection<User> Users { 
            get => users;
            set
            {
                users = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindow()
        {
            InitializeComponent();
            InitValues();
        }


        private void InitValues()
        {
            Users = new ObservableCollection<User>();

            Users.Add(new User() {Name = "John Doe", Birthday = new DateTime(1971, 7, 23) });
            Users.Add(new User() {Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17) });
            Users.Add(new User() {Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2) });
        }
    }
}
