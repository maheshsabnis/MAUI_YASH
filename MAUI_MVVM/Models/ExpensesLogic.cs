using MAUI_MVVM.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_MVVM.Models
{
    public class ExpensesLogic : ILogic<Expenses, string>
    {
        private ExpenseDb expenses;
        public ExpensesLogic()
        {
            expenses= new ExpenseDb();
        }

        public IEnumerable<Expenses> GetAsync()
        {
            return expenses;
        }

        public Expenses GetAsync(string criteria)
        {
            return expenses.Where(e=>e.PaidTo == criteria).FirstOrDefault();
        }

        public IEnumerable<Expenses> Create(Expenses entity)
        {
            expenses.Add(entity);
            return expenses;
        }
    }
 }

