using EmployeeRegister.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeRegister.Infrastructure.Repository
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
          : base(options)
        {
        }

        public virtual DbSet<Employees> Employees { get; set; }
    }
}
