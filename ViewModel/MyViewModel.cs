using WpfApp1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;

namespace WpfApp1.ViewModel
{
    class MyViewModel : INotifyPropertyChanged
    {
        private double result; //Результат умножения. Обратите внимание, что все поля приватные
        private bool t1 = false;
        private bool t2 = false;
        public double Result
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

        public bool T1
        {
            get
            {
                return t1;
            }
            set
            {
                t1 = value;
                RaisePropertyChanged("T1");
            }
        }

        public bool T2
        {
            get
            {
                return t2;
            }
            set
            {
                t2 = value;
                RaisePropertyChanged("T2");
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string p)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(p));
            }
        }


        public MyViewModel() //пустой конструктор
        {
        }

        private RelayCommand clickCommandT;
        public RelayCommand ClickCommandT
        {
            get
            {
                return clickCommandT ??
                (clickCommandT = new RelayCommand(obj =>
                {
                    Shape numbers = new Shape();
                    Result = numbers.returnT();
                    T2 = false;
                }));
            }
        }

        private RelayCommand clickCommandS;
        public RelayCommand ClickCommandS
        {
            get
            {
                return clickCommandS ??
                (clickCommandS = new RelayCommand(obj =>
                {
                    Shape numbers = new Shape();
                    Result = numbers.returnS();
                    T1 = false;
                }));
            }
        }
    }
}