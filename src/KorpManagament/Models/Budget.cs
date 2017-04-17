using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KorpManagament.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Expense> PlannedExpenses { get; set; }
        public virtual List<Expense> ActualExpenses { get; set; }
    }
}
