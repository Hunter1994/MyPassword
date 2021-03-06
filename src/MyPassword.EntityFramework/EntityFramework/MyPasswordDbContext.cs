﻿using System.Data.Common;
using Abp.Zero.EntityFramework;
using MyPassword.Authorization.Roles;
using MyPassword.Authorization.Users;
using MyPassword.MultiTenancy;
using System.Data.Entity;
using MyPassword.Info;
using MyPassword.Core.Product;

namespace MyPassword.EntityFramework
{
    public class MyPasswordDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        public virtual IDbSet<PasswordInfo> PasswordInfos { get; set; }
        public virtual IDbSet<Product> Products { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public MyPasswordDbContext()
            : base("Default")
        {
        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MyPasswordDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MyPasswordDbContext since ABP automatically handles it.
         */
        public MyPasswordDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public MyPasswordDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public MyPasswordDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
