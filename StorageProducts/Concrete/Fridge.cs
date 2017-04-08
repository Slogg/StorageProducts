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
        private List<Shelf> shelves = new List<Shelf>();
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
                shelves.Add(shelf);
                return true;
            }
            else
            {
                return false;
            }
        }
        // Удаление происходит по номеру полки в List<Shelf>
        public void DeleteShelf(int id)
        {
            Shelf sh = shelves.First(i => i.Id == id);
            Volume += sh.Volume;
            shelves.RemoveAll(i => i.Id == id);
        }

        public void AddProduct(int id, Product product)
        {
            foreach (var sh in GetShelves)
            {
                if (sh.Id == id)
                {
                    sh.AddProduct(product);
                }
            }
        }
        public void DeleteProduct(int id)
        {
            foreach (var sh in GetShelves)
            {
                foreach (var prod in sh.GetProducts)
                {
                    if (prod.Id == id)
                    {
                        sh.DeleteProduct(id);
                    }
                }
            }
        }
        public List<Shelf> GetFreeShelves(Product product)
        {
            List<Shelf> freeShelves = new List<Shelf>();
            foreach (var shelves in GetShelves)
            {
                if (product.GetTypeProduct() == shelves.GetTypeShelf() && shelves.Volume >= product.Volume)
                {
                    freeShelves.Add(shelves);
                }
                else if (shelves.GetTypeShelf() == ProductType.Other && shelves.Volume >= product.Volume)
                {
                    freeShelves.Add(shelves);
                }
            }
            return freeShelves;
        }
        public IEnumerable<Shelf> GetShelves
        {
            get { return shelves; }
        }



    }
}
