using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageProducts.Model;
using StorageProducts.Abstract;

namespace StorageProducts.Concrete
{
    class ShelfBox : Shelf
    {
        public ShelfBox() { }
        public override string GetTypeShelf()
        {
            return ProductType.Box;
        }
    }
}
