using IdentitySample.Data.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace IdentitySample.Data
{
    public class ApplicationContext : IdentityDbContext
    {
        #region [Ctor]
        public ApplicationContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
            
        }

        protected ApplicationContext()
        {
        }
        #endregion

        #region [Properries]
        public DbSet<Employee> Employees { get; set; }
        #endregion
    }
}
