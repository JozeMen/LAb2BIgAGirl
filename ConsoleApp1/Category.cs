using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Category : IComparable<Category>
    {
        // Поля категории
        public string Product { get; }
        public string Type { get; }
        public string Theme { get; }
        public object HashCode { get; private set; }

        // Конструктор класса
        public Category(string product, string type, string theme)
        {
            Product = product;
            Type = type;
            Theme = theme;
        }

        // Переопределение метода Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Category other = (Category)obj;
            return Product == other.Product && Type == other.Type && Theme == other.Theme;
        }

        // Переопределение метода GetHashCode
        public override int GetHashCode()
        {
            return System.HashCode.Combine(Product, Type, Theme);
        }

        // Реализация интерфейса IComparable для упорядочивания категорий
        public int CompareTo(Category other)
        {
            // Сначала сравниваем по продукту
            int productComparison = String.Compare(Product, other.Product, StringComparison.Ordinal);
            if (productComparison != 0)
            {
                return productComparison;
            }

            // Затем по типу
            int typeComparison = String.Compare(Type, other.Type, StringComparison.Ordinal);
            if (typeComparison != 0)
            {
                return typeComparison;
            }

            // Наконец, по теме
            return String.Compare(Theme, other.Theme, StringComparison.Ordinal);
        }

        // Реализация оператора равенства
        public static bool operator ==(Category left, Category right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (left is null || right is null)
            {
                return false;
            }

            return left.Equals(right);
        }

        // Реализация оператора неравенства
        public static bool operator !=(Category left, Category right)
        {
            return !(left == right);
        }

        // Реализация оператора меньше
        public static bool operator <(Category left, Category right)
        {
            return left.CompareTo(right) < 0;
        }

        // Реализация оператора больше
        public static bool operator >(Category left, Category right)
        {
            return left.CompareTo(right) > 0;
        }

        // Реализация оператора меньше или равно
        public static bool operator <=(Category left, Category right)
        {
            return left.CompareTo(right) <= 0;
        }

        // Реализация оператора больше или равно
        public static bool operator >=(Category left, Category right)
        {
            return left.CompareTo(right) >= 0;
        }
    }
}

