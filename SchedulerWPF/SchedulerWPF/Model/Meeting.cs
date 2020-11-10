using System;
using System.ComponentModel;
using System.Windows.Media;

namespace WpfScheduler
{
    public class Meeting : INotifyPropertyChanged
    {
        private string eventName;
        private bool allDay;
        private Brush color;
        private DateTime to;
        private DateTime from;

        public event PropertyChangedEventHandler PropertyChanged;
        public string EventName
        {
            get
            {
                return eventName;
            }

            set
            {
                eventName = value;
                this.RaiseOnPropertyChanged("EventName");
            }
        }
        public DateTime From
        {
            get
            {
                return from;
            }

            set
            {
                from = value;
                this.RaiseOnPropertyChanged("From");
            }
        }
        public DateTime To
        {
            get
            {
                return to;
            }

            set
            {
                to = value;
                this.RaiseOnPropertyChanged("To");
            }
        }
        public Brush Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
                this.RaiseOnPropertyChanged("Color");
            }
        }
        public bool AllDay
        {
            get
            {
                return allDay;
            }

            set
            {
                allDay = value;
                this.RaiseOnPropertyChanged("AllDay");
            }
        }
        private void RaiseOnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
