using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using MyPassword.EntityFramework;

namespace MyPassword
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(MyPasswordCoreModule))]
    public class MyPasswordDataModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
