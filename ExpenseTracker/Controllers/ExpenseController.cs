using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpenseTracker.EntityModels;
using ExpenseTracker.Interface;
using ExpenseTracker.ResponseMessage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    [Route("api/Expense")]
    [ApiController]

    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseInterface _expenseInterface;
        public ExpenseController(IExpenseInterface expenseInterface)
        {
            _expenseInterface = expenseInterface ?? throw new ArgumentNullException(nameof(expenseInterface));
        }

        [HttpPost("NewExpense")]
        public ActionResult<Expense> CreateExpense([FromBody] Expense expense)
        {
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(new ApiUnprocessableEntity("Invalid Model")) ;
            }

             var expenseToReturn=_expenseInterface.CreateExpense(expense);
            if (expenseToReturn != null)
            {
                return Ok(new ApiOkResponse("Success"));
            }
            return Conflict("Resource could not be created");

            //return CreatedAtAction("GetExpense", new { expenseId = expense.ExpenseId }, expense);

        }
    }
}