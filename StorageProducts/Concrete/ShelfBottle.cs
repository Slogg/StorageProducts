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
        private List<Product> products = new List<Product>();
        public ShelfBottle() { }
        public ShelfBottle(int volume):base(volume)
        {
            Volume = volume;
        }
        public override string GetTypeShelf()
        {
            return ProductType.Bootle;
        }
    }
}
