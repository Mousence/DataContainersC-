using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataContainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Введите размер дерева: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Tree tree = new Tree();
            for (int i = 0; i < n; i++) { 
            tree.Insert(random.Next(100));
            }
            tree.Print();
            Console.WriteLine($"Минимальное значение дерева: {tree.MinValue()}");
            Console.WriteLine($"Максимальное значение дерева: {tree.MaxValue()}");
            Console.WriteLine($"Сумма элементов дерева: {tree.Sum()}");
            Console.WriteLine($"Количество элеметов дерева: {tree.Count()}");
            Console.WriteLine($"Среднее-арифметическое элементов дерева: {tree.Count()}");

            int a = Convert.ToInt32(Console.ReadLine());
            tree.erase(a);
            tree.Print();

            tree.delete();
            tree.Print();

            Console.WriteLine($"Глубина дерева: {tree.depth()}");

            tree.DepthPrint(2);
        }
    }
}
