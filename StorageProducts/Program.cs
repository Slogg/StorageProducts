using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageProducts.Concrete;
using StorageProducts.Abstract;

namespace StorageProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задать емкость холодильнику
            Fridge fr = new Fridge(90);
            // Добавить полку для коробок
            fr.AddShelf(new ShelfBox { Id = 1, Volume = 40 });
            // Добавить полку для бутылок
            fr.AddShelf(new ShelfBox { Id = 2, Volume = 20 });
            // Добавить полку для прочих продуктов
            fr.AddShelf(new ShelfOther { Id = 3, Volume = 30 });
            // Получить полки 
            foreach (var item in fr.GetShelves)
            {
                // Вывод полок
            }
            // Добавляем продукт
            Product bottleOne = new ProductBottle
            {
                Id = 1,
                Name = "Буратино",
                ShelfLife = new DateTime(2017, 06, 12),
                Volume = 5
            };
            // Проверяем на каких полках есть место и выводим их
            fr.GetFreeShelves(bottleOne);
            // Отправляем id необходимой свободной полки и продукта для добавления
            fr.AddProduct(1, bottleOne);
            // Вывести все продукты в холодильнике 
            fr.GetAllProducts();
            // Удаляем продукт с полки по id Продукта
            fr.DeleteProduct(1);
            // Удаляем полку по id
            fr.DeleteShelf(2);
        }
    }
}
