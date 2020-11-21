using System.Data.Common;
using System.Data.Entity;
using Abp.DynamicEntityParameters;
using Abp.Zero.EntityFramework;
using vino.Authorization.Roles;
using vino.Authorization.Users;
using vino.MultiTenancy;
using vino.Products;

namespace vino.EntityFramework
{
    public class vinoDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public virtual IDbSet<Product> Products { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public vinoDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in vinoDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of vinoDbContext since ABP automatically handles it.
         */
        public vinoDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public vinoDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public vinoDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DynamicParameter>().Property(p => p.ParameterName).HasMaxLength(250);
            modelBuilder.Entity<EntityDynamicParameter>().Property(p => p.EntityFullName).HasMaxLength(250);
        }
    }
}
