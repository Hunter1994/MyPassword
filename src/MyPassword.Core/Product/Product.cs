using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;

namespace MyPassword.Product
{
    public class Product:FullAuditedEntity
    {
        public const int MaxName = 100;

        public Product() { }

        public virtual string Name { get; private set; }
        public virtual decimal Price { get; private set; }
        [Timestamp]
        public virtual int Number { get; private set; }

        public void Create(string name, decimal price, int number)
        {
            this.Name = name;
            this.Price = price;
            this.Number = number;
        }

        public void UpdateName(string name) {
            this.Name = name;
        }

        public void UpdatePrice(decimal price)
        {
            this.Price = price;
        }

        public void InNumber(int num)
        {
            this.Number += num;
        }

        public void DeNumber(int num,IProductPolicy policy)
        {
            policy.CheckDeNumber(this, num);
            this.Number = num;
        }


    }
}
