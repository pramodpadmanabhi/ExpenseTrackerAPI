﻿using ExpenseTracker.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Interface
{
    public interface IExpenseInterface
    {
        Expense CreateExpense(Expense expense);
    }
}
