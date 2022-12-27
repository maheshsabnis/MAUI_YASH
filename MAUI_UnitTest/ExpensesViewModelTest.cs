
using Moq;

namespace MAUI_UnitTest
{
    public class ExpensesViewModelTest
    {
        /// <summary>
        /// Test Method
        /// </summary>
        [Fact]
        public void GetExpensesTest()
        {
            // Arrange: Collect all the necessray Depednencies
            var fakeObject = new Mock<ExpensesLogic>().Object;
            var viewModel = new ExpensesViewModel(fakeObject);
            var expectedRecordCount = viewModel.AllExpenses.Count;
            // Act: Invoke the Actual method
            viewModel.GetExpensesCommand.Execute(new object());
            // Assert: Verify the Result
            Assert.Equal(viewModel.AllExpenses.Count, new ExpenseDb().Count);
        }
    }
}