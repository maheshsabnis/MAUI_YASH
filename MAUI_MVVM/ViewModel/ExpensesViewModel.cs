using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUI_MVVM.ViewModel
{
    /// <summary>
    /// Presenter class
    /// </summary>
    public partial class ExpensesViewModel : ObservableObject
    {
        [ObservableProperty]
        private Expenses expensesObject;
        [ObservableProperty]
        private ObservableCollection<Expenses> allExpenses;
         
        ExpensesLogic logic;
        /// <summary>
        /// Injection
        /// </summary>
        /// <param name="logic"></param>
        public ExpensesViewModel(ExpensesLogic logic)
        {
            this.logic = logic;
            ExpensesObject= new Expenses(); 
            AllExpenses= new ObservableCollection<Expenses>();
        }

        // logic method those are responsible for interacting with model

        [RelayCommand]
        void GetExpenses()
        {
            AllExpenses.Clear();
            foreach (var expenses in logic.GetAsync())
            {
                AllExpenses.Add(expenses);
            }
        }
        [RelayCommand]
        void RecordNewExpense()
        {
            
            var result = logic.Create(ExpensesObject);
            foreach (var expenses in result)
            {
                AllExpenses.Add(expenses);
            }
        }
    }
}
