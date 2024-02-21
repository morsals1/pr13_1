using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace prak13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList list = new ArrayList();
                list.Add(4.5);
                list.Add(18);
                list.Add(18);
                list.Add(18);
                list.Add(18);
                list.Add(18);
                list.Add(18);
                list.Add(18);
                list.Add(18);
                list.Add(18);
                list.Add(18);
                list.Add(18);
                list.Add(18);
                list.Add(18);
                list.Add(18);
                list.AddRange(new string[] { "Cтудент", "Петров" });

                foreach (object c in list)
                {
                    Console.WriteLine(c);
                }
                list.RemoveAt(0);
                list.Reverse();
                Console.WriteLine(list[1]);
                Console.WriteLine("начало");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
                //1
                ArrayList list1 = new ArrayList();
                list1.Add(15);
                list1.Add(15);
                list1.Add(15.1);
                Console.WriteLine("Введите номер позиции");
                int n1 = int.Parse(Console.ReadLine());
                list.InsertRange(n1, list1);


                Console.WriteLine("Введите сколько элементов удалить");
                int k = int.Parse(Console.ReadLine());
                int n = n1 / 2;
                list1.RemoveRange(n, k);
                foreach (object e in list1)
                {
                    Console.WriteLine(e);
                }
            }
            catch { Console.WriteLine("ошибка"); }
            Console.ReadKey();
        }
    }
}
