using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Business.Abstract
{
    public interface IShoppingCart
    {
        void RegisterCustomer(ICustomer customer);
        void AddProduct(IProduct product);
        void ClearProducts();
        List<IProduct> GetProducts();
    }
}
