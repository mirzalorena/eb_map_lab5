using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mirza_Lorena_Lab5.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options)
        : base(options)
        {
        }
        public DbSet<ExpenseDTO> Expense { get; set; }

    }

}
