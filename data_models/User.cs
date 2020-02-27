using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace data_models
{
    public class User : INotifyPropertyChanged
    {
        static int nextId;

        private string name;
        private DateTime birthday;

        public int Id { get; private set; }

        public string Name {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public DateTime Birthday { 
            get => birthday;
            set
            {
                birthday = value;
                OnPropertyChanged();
            }
        }

        public User()
        {
            Id = Interlocked.Increment(ref nextId);
        }

        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
