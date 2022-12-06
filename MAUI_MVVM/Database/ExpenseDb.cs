using MAUI_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_MVVM.Database
{
    public class ExpenseDb : List<Expenses>
    {
        public ExpenseDb()
        {
            Add(new Expenses() {ExpenseDetails="Grossary",ExpenseAmount=2000,PaidTo="Ganesh" });
            Add(new Expenses() { ExpenseDetails = "Vegitables", ExpenseAmount = 400, PaidTo = "Ashok" });
        }
    }
}
