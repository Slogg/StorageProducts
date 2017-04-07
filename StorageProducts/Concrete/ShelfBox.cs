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
        private List<Product> products = new List<Product>();
        public ShelfBox() { }
        public ShelfBox(int volume):base(volume)
        {
            Volume = volume;
        }
        public override string GetTypeShelf()
        {
            return ProductType.Box;
        }
    }
}
