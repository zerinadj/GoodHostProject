using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using GoodHost.EntityFramework;

namespace GoodHost.Migrator
{
    [DependsOn(typeof(GoodHostDataModule))]
    public class GoodHostMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<GoodHostDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}