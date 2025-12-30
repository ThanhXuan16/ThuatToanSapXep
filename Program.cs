using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToan_SapXep
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mang ban dau: " + string.Join(" ", a));

           

            // Chạy và in kết quả nhanh
            Test("Bubble", (int[])a.Clone(), sapXepNoiBot.BubbleSort);
            //Test("Selection", (int[])a.Clone(), sapXepChon.SelectionSort);
            //Test("Insertion", (int[])a.Clone(), sapXepChen.InsertionSort);

            Console.ReadKey();
        }

        static void Test(string name, int[] a, Action<int[]> method)
        {
            method(a);
            Console.WriteLine($"Mang sau sap xep {name}: {string.Join(" ", a)}");
        }
    }
}
