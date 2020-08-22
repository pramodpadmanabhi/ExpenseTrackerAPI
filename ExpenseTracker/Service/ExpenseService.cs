using ExpenseTracker.Context;
using ExpenseTracker.EntityModels;
using ExpenseTracker.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Service
{
    public class ExpenseService:IExpenseInterface
    {
        private readonly ExpenseContext _expenseContext;
        public ExpenseService(ExpenseContext expenseContext)
        {
            _expenseContext = expenseContext ?? throw new ArgumentNullException(nameof(ExpenseContext));
        }
        public Expense CreateExpense(Expense expense)
        {
             _expenseContext.Add(expense);
            if (_expenseContext.SaveChanges() > 0)
            {
                return expense;
            }
            return null;


        }
    }
}
