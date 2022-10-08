// Group 4 Author: Marta Group Members: Aman, Himanshu, Srivani, Meet, Robin
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PresentValue
{
    internal class VM : INotifyPropertyChanged
    {
        const decimal FUTURE_VALUE = 10000m;
        const double YEARS = 10d;

        private decimal interest = 0;

        public decimal Interest
        {
            get { return interest; }
            set { interest = value; notifyChange(); UpdatePresentValue(); }
        }

        private double years = YEARS;

        public double Years
        {
            get { return years; }
            set { years = value; notifyChange(); UpdatePresentValue(); }
        }

        private decimal presentValue = 0;
        public decimal PresentValue
        {
            get { return presentValue; }
            set { presentValue = value; notifyChange(); }
        }

        private decimal futureValue = FUTURE_VALUE;
        public decimal FutureValue
        {
            get { return futureValue; }
            set { futureValue = value; notifyChange(); UpdatePresentValue(); }
        }

        public void UpdatePresentValue()
        {
            PresentValue = CalcPresentValue(futureValue, interest, years);
            //alternative: PresentValue = future / Math.Pow(1 + interestRate, numYears);
        }

        static public decimal CalcPresentValue(decimal future, decimal interestRate, double numYears)
        {
            return future / (decimal)Math.Pow((double)(1 + interestRate), numYears);
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        private void notifyChange([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
