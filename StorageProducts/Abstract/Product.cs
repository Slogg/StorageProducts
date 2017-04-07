using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageProducts.Abstract
{
    abstract class Product
    {
        public int Volume { get; set; }
        public string Name { get; set; }
        public DateTime ShelfLife { get; set; }
        public abstract string GetTypeProduct();
    }
}
