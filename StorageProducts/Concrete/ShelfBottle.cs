using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageProducts.Model;
using StorageProducts.Abstract;

namespace StorageProducts.Concrete
{
    class ShelfBottle:Shelf
    {
        public ShelfBottle() { }
        public override string GetTypeShelf()
        {
            return ProductType.Bootle;
        }
    }
}
