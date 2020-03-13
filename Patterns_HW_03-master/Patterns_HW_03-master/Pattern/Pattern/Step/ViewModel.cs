using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace Pattern.Step
{

    public class ViewModel : INotifyPropertyChanged
    {
        private readonly Model model;
        public ViewModel(Model model, ICommand saveCommand, ICommand eraseCommand)
        {
            this.model = model;
            this.EraseCommand = eraseCommand;
            this.SaveCommand = saveCommand;
        }
        public string Name
        {
            get
            {
                return model.Name;
            }
            set
            {
                if (model.Name != value)
                {
                    model.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Address
        {
            get
            {
                return model.Address;
            }
            set
            {
                if (model.Address != value)
                {
                    model.Address = value;
                    OnPropertyChanged("Address");
                }
            }
        }
        
        public bool IsMale
        {
            get
            {
                return model.IsMale;
            }
            set
            {
                if (model.IsMale != value)
                {
                    model.IsMale = value;
                    OnPropertyChanged("IsMale");
                }
            }
        }

        public int Day
        {
            get
            {
                return model.BirthDate.Day;
            }
            set
            {
                if (model.BirthDate.Day != value)
                {
                    model.BirthDate = new DateTime(model.BirthDate.Year, model.BirthDate.Month, value);
                    OnPropertyChanged("Day");
                }
            }
        }

        public int Month
        {
            get
            {
                return model.BirthDate.Month;
            }
            set
            {
                if (model.BirthDate.Month != value)
                {
                    model.BirthDate = new DateTime(model.BirthDate.Year, value, model.BirthDate.Day);
                    OnPropertyChanged("Month");
                }
            }
        }

        public int Year
        {
            get
            {
                return model.BirthDate.Year;
            }
            set
            {
                if (model.BirthDate.Year != value)
                {
                    model.BirthDate = new DateTime(value, model.BirthDate.Month, model.BirthDate.Day);
                    OnPropertyChanged("Year");
                }
            }
        }

        public string Email
        {
            get
            {
                return model.Email;
            }
            set
            {
                if (model.Email != value)
                {
                    model.Email = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        public string PhoneNumber
        {
            get
            {
                return model.Phone;
            }
            set
            {
                if (model.Phone != value)
                {
                    model.Phone = value;
                    OnPropertyChanged("Phone");
                }
            }
        }


        public ICommand SaveCommand { get; private set; }

        public ICommand EraseCommand { get; private set; }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
