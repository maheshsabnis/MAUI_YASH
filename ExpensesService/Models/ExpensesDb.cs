namespace ExpensesService.Models
{
    public class ExpenseDb : List<Expenses>
    {
        public ExpenseDb()
        {
            Add(new Expenses() { ExpensesDetails = "Grossary", ExpensesAmount = 2000, PaidTo = "Ganesh" });
            Add(new Expenses() { ExpensesDetails = "Vegitables", ExpensesAmount = 400, PaidTo = "Ashok" });
        }
    }
}
