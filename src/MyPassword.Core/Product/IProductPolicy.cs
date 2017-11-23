using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPassword.Core.Product
{
    public interface IProductPolicy
    {
        void CheckDeNumber(Product product,int num);

        void CheckPrice(decimal price);

        void CheckNumber(int number);
    }
}
