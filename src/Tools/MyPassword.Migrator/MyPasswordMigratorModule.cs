using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MyPassword.EntityFramework;

namespace MyPassword.Migrator
{
    [DependsOn(typeof(MyPasswordDataModule))]
    public class MyPasswordMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MyPasswordDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}