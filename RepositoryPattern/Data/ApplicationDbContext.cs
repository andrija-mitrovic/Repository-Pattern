using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<TaxYear> TaxYears { get; set; }
        public DbSet<PaymentRecord> PaymentRecords { get; set; }
    }
}
