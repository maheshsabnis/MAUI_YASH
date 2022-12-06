using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_MVVM.Models
{
    /// <summary>
    ///  The Model Class with Notification
    /// </summary>
    public class Expenses : INotifyPropertyChanged
    {
        private string _ExpenseDetails = "Grossary";
        private double _ExpenseAmount = 0;
        private string _PaidTo = "Ganesh";

        public event PropertyChangedEventHandler PropertyChanged;

        // Public Read/Write Proeprties
        // These propries will be ready with Notifications

        public string ExpenseDetails
        {
            get=>  _ExpenseDetails;

            set
            {
                if (_ExpenseDetails == value)
                    return;
                _ExpenseDetails = value;
                RaisePropertyChanged();
            }
        }

        public string PaidTo
        {
            get=>  _PaidTo;

            set
            {
                if (_PaidTo == value)
                    return;
                _PaidTo = value;
                RaisePropertyChanged();
            }
        }

        public double ExpenseAmount
        {
            get =>  _ExpenseAmount;

            set
            {
                if (_ExpenseAmount == value)
                    return;
                _ExpenseAmount = value;
                RaisePropertyChanged();
            }
        }


        // The Method that will be raised when the Proeprty Changes
        private void RaisePropertyChanged([CallerMemberName] string pName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pName));
        }
    }
}
