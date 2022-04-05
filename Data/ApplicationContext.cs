using IdentitySample.Data.Domain;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace IdentitySample.Data
{
    public class ApplicationContext : DbContext
    {
        #region [Ctor]
        public ApplicationContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
            
        }

        protected ApplicationContext()
        {
        }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
        #region [Properries]
        public DbSet<Employee> Employees { get; set; }
        #endregion
    }
}
