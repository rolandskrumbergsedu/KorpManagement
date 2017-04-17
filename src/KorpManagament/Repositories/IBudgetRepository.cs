using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KorpManagament.Models;
using KorpManagament.Models.Dto;

namespace KorpManagament.Repositories
{
    public interface IBudgetRepository
    {
        void Create(BudgetDto budget);
    }
}
