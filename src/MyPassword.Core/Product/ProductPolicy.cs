using Abp;
using Abp.Dependency;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPassword.Core.Product
{
    public class ProductPolicy : IProductPolicy, ITransientDependency
    {
        public void CheckDeNumber(Product product, int num)
        {
            if (product == null) throw new ArgumentException("产品对象不能为空");
            if (product.Number <= 0) throw new UserFriendlyException("产品数量为0");
            if (product.Number - num < 0) throw new UserFriendlyException("产品剩余数量不足");
        }

        public void CheckNumber(int number)
        {
            if (number <= 0) throw new UserFriendlyException("产品数量必须大于0");
        }

        public void CheckPrice(decimal price)
        {
            if (price <= 0) throw new UserFriendlyException("产品单价必须大于0");
        }
    }
}
