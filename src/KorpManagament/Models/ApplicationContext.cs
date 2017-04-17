using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KorpManagament.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }

        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}
