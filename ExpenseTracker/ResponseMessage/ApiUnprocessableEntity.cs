using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.ResponseMessage
{
    public class ApiUnprocessableEntity:ApiResponse
    {
        public object Result { get; }

        public ApiUnprocessableEntity(object result)
            : base(422)
        {
            Result = result;
        }
    }
}
