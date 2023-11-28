#define BASE_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DataContainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if BASE_CHECK
            Random random = new Random();
            Console.WriteLine("Введите размер дерева: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Tree tree = new Tree();
            for (int i = 0; i < n; i++)
            {
                tree.Insert(random.Next(100));
            }
            //tree.Clear();
            tree.Print();
            Stopwatch sw = new Stopwatch();
            try
            {
                sw.Start();
                Console.WriteLine($"Минимальное значение дерева: {tree.MinValue()}");
                sw.Stop();
                sw.Start();
                Console.WriteLine($"Максимальное значение дерева: {tree.MaxValue()}");
                sw.Stop();
                sw.Start(); 
                Console.WriteLine($"Сумма элементов дерева: {tree.Sum()}");
                sw.Stop();
                sw.Start();
                Console.WriteLine($"Количество элеметов дерева: {tree.Count()}");
                sw.Start();
                Console.WriteLine($"Среднее-арифметическое элементов дерева: {tree.Count()}");

                int a = Convert.ToInt32(Console.ReadLine());
                tree.erase(a);
                tree.Print();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            tree.Clear();
            tree.Print();

            Console.WriteLine($"Глубина дерева: {tree.depth()}");

            tree.DepthPrint(2); Console.WriteLine();
            //Console.WriteLine("/--------------------------------------------------------------------------------------------/");
            //Console.WriteLine("Введите размер дерева: ");
            //n = Convert.ToInt32(Console.ReadLine());
            //EniqueTree e_tree = new EniqueTree();
            //for (int i = 0; i < n; i++)
            //{
            //    e_tree.Insert(random.Next(100));
            //}
            //tree.Print();
            //Console.WriteLine($"Минимальное значение дерева: {tree.MinValue()}");
            //Console.WriteLine($"Максимальное значение дерева: {tree.MaxValue()}");
            //Console.WriteLine($"Сумма элементов дерева: {tree.Sum()}");
            //Console.WriteLine($"Количество элеметов дерева: {tree.Count()}");
            //Console.WriteLine($"Среднее-арифметическое элементов дерева: {tree.Count()}"); 
#endif
            //Tree tree = new Tree(50, 25, 75, 16, 32, 64, 80);
            //tree.Print();
            //Console.Write("Введите удаляемое значение: ");
            //int value = Convert.ToInt32(Console.ReadLine());
            //tree.erase(value);
            //tree.Print();

        }
    }
}
