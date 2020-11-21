using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using vino.EntityFramework;

namespace vino.Migrator
{
    [DependsOn(typeof(vinoDataModule))]
    public class vinoMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<vinoDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}