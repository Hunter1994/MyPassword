using System.Linq;
using MyPassword.EntityFramework;
using MyPassword.MultiTenancy;

namespace MyPassword.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly MyPasswordDbContext _context;

        public DefaultTenantCreator(MyPasswordDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
