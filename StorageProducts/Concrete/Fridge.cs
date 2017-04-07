using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageProducts.ConsoleRead;
using StorageProducts.Model;
using StorageProducts.Abstract;

namespace StorageProducts.Concrete
{
    class Fridge
    {
        public int Volume { get; set; }
        private List<Shelf> shelfs = new List<Shelf>();
        public Fridge(int volume)
        {
            Volume = volume;
        }
        // Холодильник имеет емкость. каждая полка отнимает
        // заданое в свойствах полки емкость у холодильника. 
        // Есть возможность поставить полки так, что они будут нерационально расходовать емкость
        public bool AddShelf(Shelf shelf)
        {
            if (Volume - shelf.Volume >= 0)
            {
                Volume -= shelf.Volume;
                shelfs.Add(shelf);
                return true;
            }
            else
            {
                return false;
            }
        }
        // Удаление происходит по номеру полки в List<Shelf>
        public void DeleteProduct(int numShelfInFridge)
        {
            Volume += shelfs[numShelfInFridge].Volume;
            shelfs.RemoveAt(numShelfInFridge);
        }

        public void AddProduct(Product product)
        {
            //foreach (var item in GetShelfs)
            //{
            //    if (product.GetTypeProduct() == item.GetTypeShelf())
            //    {
            //        item.AddProduct(product);
            //    }
            //}
            
        }
        public IEnumerable<Shelf> GetShelfs
        {
            get { return shelfs; }
        }



    }
}
