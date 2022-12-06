using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MAUI_RESTClient.Models
{
    public class Expenses : INotifyPropertyChanged
    {
        private string _ExpensesDetails;
        private double _ExpensesAmount;
        private string _PaidTo;

        public event PropertyChangedEventHandler PropertyChanged;

        // Public Read/Write Proeprties
        // These propries will be ready with Notifications

        public string ExpensesDetails
        {
            get => _ExpensesDetails;

            set
            {
                if (_ExpensesDetails == value)
                    return;
                _ExpensesDetails = value;
                RaisePropertyChanged();
            }
        }

        public string PaidTo
        {
            get => _PaidTo;

            set
            {
                if (_PaidTo == value)
                    return;
                _PaidTo = value;
                RaisePropertyChanged();
            }
        }

        public double ExpensesAmount
        {
            get => _ExpensesAmount;

            set
            {
                if (_ExpensesAmount == value)
                    return;
                _ExpensesAmount = value;
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
