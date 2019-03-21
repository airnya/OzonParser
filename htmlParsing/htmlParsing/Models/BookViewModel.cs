using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace htmlParsing.Models
{
    public class BookViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Book phone;

        public BookViewModel()
        {
            phone = new Book();
        }

        public string Title
        {
            get { return phone.Title; }
            set
            {
                if (phone.Title != value)
                {
                    phone.Title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        public string bookId
        {
            get { return phone.bookId; }
            set
            {
                if (phone.bookId != value)
                {
                    phone.bookId = value;
                    OnPropertyChanged("bookId");
                }
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}