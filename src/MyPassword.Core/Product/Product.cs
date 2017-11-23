using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;

namespace MyPassword.Core.Product
{
    public class Product:FullAuditedEntity,IMustHaveTenant
    {
        public virtual string Name { get; private set; }
        public virtual decimal Price { get; private set; }
       
        public virtual int Number { get; private set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public int TenantId { get; set; }

        public Product() { }


        public void Create(string name, decimal price, int number)
        {
            this.Name = name;
            this.Price = price;
            this.Number = number;
        }

        public void UpdateName(string name) {
            this.Name = name;
        }

        public void UpdatePrice(decimal price, IProductPolicy policy)
        {
            policy.CheckPrice(price);
            this.Price = price;
        }
        public void UpdateNumber(int number, IProductPolicy policy)
        { 
            policy.CheckNumber(number);
            this.Number = number;
        }
        public void InNumber(int num)
        {
            this.Number += num;
        }

        public void DeNumber(int num, IProductPolicy policy)
        {
            policy.CheckDeNumber(this, num);
            this.Number = num;
        }


    }
}
