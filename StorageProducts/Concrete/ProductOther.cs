using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageProducts.Abstract;
using StorageProducts.Model;

namespace StorageProducts.Concrete
{
    class ProductOther:Product
    {
        public override string GetTypeProduct()
        {
            return ProductType.Other;
        }
    }
}
