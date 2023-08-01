
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            
            
            using(MyDatabaseContext db = new MyDatabaseContext())
            {
                //db.Products.Add(new Product("Гитара", 1934.34, "Супер крутая гитара", 12));
                //db.Products.Add(new Product("Смартфон", 12000.50, "Популярный смартфон с продвинутыми функциями", 6));
                //db.Products.Add(new Product("Ноутбук", 27000.25, "Мощный ноутбук для работы и развлечений", 8));
                //db.Products.Add(new Product("Фотоаппарат", 15000.15, "Профессиональный фотоаппарат с высоким разрешением", 4));
                //db.Products.Add(new Product("Наушники", 2000.60, "Качественные наушники с хорошим звуком", 10));
                //db.Products.Add(new Product("Кофемашина", 5000.12, "Автоматическая кофемашина для приготовления вкусного кофе", 2));
                //db.Products.Add(new Product("Умные часы", 8000.20, "Стильные умные часы с множеством функций", 5));
                //db.Products.Add(new Product("Телевизор", 18000.30, "Широкоформатный телевизор с отличным качеством изображения", 3));
                //db.Products.Add(new Product("Планшет", 6000.18, "Легкий и компактный планшет для работы и развлечений", 7));
                //db.Products.Add(new Product("Смарт-часы", 3500.45, "Современные смарт-часы с поддержкой умных функций", 9));


                //db.SaveChanges();


                var res = db.Products.ToList().Where(x => x.Name == "Гитара" 
                || x.Name == "Наушники"
                || x.Name == "Смартфон"
                || x.Name == "Умные часы");



                foreach (var item in res)
                {
                    Console.WriteLine($"{item.Name} - {item.Quantity} - {item.Cost} - {item.Description}");
                }


            }


            Console.ReadKey();

        }
    }
}
