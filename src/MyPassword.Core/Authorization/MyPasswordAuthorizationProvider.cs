using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace MyPassword.Authorization
{
    public class MyPasswordAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Info, L("Info"));
            context.CreatePermission(PermissionNames.Pages_Product, L("Product"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, MyPasswordConsts.LocalizationSourceName);
        }
    }
}
