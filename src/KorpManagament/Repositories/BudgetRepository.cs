using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KorpManagament.Models;
using KorpManagament.Models.Dto;

namespace KorpManagament.Repositories
{
    public class BudgetRepository : IBudgetRepository
    {
        private readonly ApplicationContext _db;

        public BudgetRepository(ApplicationContext db)
        {
            _db = db;
        }

        public void Create(BudgetDto budget)
        {
            _db.Budgets.Add(new Budget
            {
                Name = budget.Name
            });
        }

        public List<BudgetDto> All()
        {
            return _db.Budgets.Select(x => new BudgetDto
            {
                Name = x.Name,
                Id = x.Id
            }).ToList();
        }
    }
}
