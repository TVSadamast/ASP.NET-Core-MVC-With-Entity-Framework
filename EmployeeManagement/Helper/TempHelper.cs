using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Helper
{
    public class TempHelper : DbContext
    {
        public TempHelper(DbContextOptions<TempHelper> options) : base(options)
        {
        }

        public DbSet<EmployeeModel> EmployeeInfo { get; set; }
        public DbSet<DepartmentModel> DepartmentInfo { get; set; }
    }
}
