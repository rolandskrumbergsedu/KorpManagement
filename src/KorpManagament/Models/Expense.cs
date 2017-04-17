using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KorpManagament.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ExpenseType Type { get; set; }
    }
}
