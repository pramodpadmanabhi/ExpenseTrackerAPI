using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.EntityModels
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }

        [Required]
        public DateTimeOffset ExpenseRecorded { get; set; }
        [Required]
        public double ExpenseAmount { get; set; }
        [Required]
        public string ExpenseDescription { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
