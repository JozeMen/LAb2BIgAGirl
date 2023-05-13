using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем несколько категорий для тестирования
            Category category1 = new Category("Продукт1", "Тип1", "Тема1");
            Category category2 = new Category("Продукт2", "Тип1", "Тема2");
            Category category3 = new Category("Продукт1", "Тип2", "Тема3");
            Category category4 = new Category("Продукт2", "Тип2", "Тема1");
            Category category5 = new Category("Продукт1", "Тип1", "Тема1");

            // Добавляем категории в список
            List<Category> categories = new List<Category>();
            categories.Add(category1);
            categories.Add(category2);
            categories.Add(category3);
            categories.Add(category4);
            categories.Add(category5);

            // Сортируем список категорий по возрастанию
            categories.Sort();

            // Выводим отсортированные категории на экран
            foreach (Category category in categories)
            {
                Console.WriteLine(category.ToString());
            }

            // Сравниваем категории с помощью операторов сравнения
            if (category1 == category5)
            {
                Console.WriteLine("Категории 1 и 5 эквивалентны.");
            }

            if (category2 != category3)
            {
                Console.WriteLine("Категории 2 и 3 не эквивалентны.");
            }

            // Задерживаем консоль
            Console.ReadKey();
        }
    }
}
