using ExpensesService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpensesService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        static ExpenseDb expenses;

        public ExpensesController()
        {
            expenses = new ExpenseDb();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(expenses);
        }
        [HttpPost]
        public IActionResult Post(Expenses expense)
        {
            expenses.Add(expense);
            return Ok(expenses);
        }
    }
}
