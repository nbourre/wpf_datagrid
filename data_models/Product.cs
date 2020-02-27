using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace data_models
{
    public class Product : INotifyPropertyChanged
    {
        private string uPC;
        private string code;
        private string shortDescription;
        private string description;
        private string category;
        private string picturePath;

        public string UPC {
            get => uPC;
            set
            {
                uPC = value;
                OnPropertyChanged();
            }
        }
        public string Code {
            get => code;
            set
            {
                uPC = value;
                OnPropertyChanged();
            }
        }
        public string ShortDescription {
            get => shortDescription;
            set
            {
                shortDescription = value;
                OnPropertyChanged();
            }
        }
        public string Description {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged();
            }
        }

        public string Category {
            get => category;
            set
            {
                category = value;
                OnPropertyChanged();
            }
        }

        public string PicturePath {
            get => picturePath;
            set
            {
                picturePath = value;
                OnPropertyChanged();
            }
        }

        public string Info => ShortDescription;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
