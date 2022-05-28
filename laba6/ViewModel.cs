using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Data;
using System.ComponentModel;

namespace laba6
{
    class ViewModel : INotifyPropertyChanged
    {
        public string vibMounth;
        public string[] mounthArr = {"январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };
        public event PropertyChangedEventHandler PropertyChanged;
        private RelayCommand clickCommand;
        private int result;
        protected void RaisePropertyChanged(string p)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(p));
            }
        }
        public ViewModel()
        {

        }

        public string Mounth2
        {
            get
            {
                return vibMounth;
            }
            set
            {
                vibMounth = value;
                RaisePropertyChanged("Mounth2");
            }
        }
        public string[] getMounth
        {
             get {
                return mounthArr;
             }
        }
        

        public int Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
                RaisePropertyChanged("Result");
            }
        }

        public RelayCommand ClickCommand
        {
            get
            {
                return clickCommand ?? (clickCommand = new RelayCommand(obj =>
                {
                    Model mounth = new Model();
                    Result = mounth.calculateMounth( vibMounth, mounthArr);
                }));
            }
        }
    }
}
