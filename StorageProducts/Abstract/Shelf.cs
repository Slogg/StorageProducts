﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageProducts.Abstract
{
    abstract class Shelf
    {
        public int Volume { get; set; }
        private List<Product> products = new List<Product>();
        public Shelf() { }
        public Shelf(int volume)
        {
            Volume = volume;
        }
        public bool AddProduct(Product product)
        {
            if (Volume - product.Volume >= 0)
            {
                Volume -= product.Volume;
                products.Add(product);
                return true;
            }
            else
            {
                return false;
            }
        }
        // Удаление происходит по номеру продукта в List<Product>
        public void DeleteProduct(int numProductInShelf)
        {
            Volume += products[numProductInShelf].Volume;
            products.RemoveAt(numProductInShelf);
        }

        public IEnumerable<Product> GetProducts
        {
            get { return products; }
        }
        public abstract string GetTypeShelf();
    }
}