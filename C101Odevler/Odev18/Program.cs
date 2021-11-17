using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Array Lİst";
            ArrayList arrayList= new ArrayList();
            arrayList.Add("Derya");
            arrayList.Add("Ünver");
            arrayList.Add(25);
            arrayList.Add(true);
            arrayList.Add('D');
            Console.WriteLine("-----------Add-----------");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);   
            }

            Console.WriteLine("-----------AddRange-----------");

            List<string> list = new List<string>
            {
                "duygu","ünver"
            };

            arrayList.AddRange(list);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------Sort--------------");
            ArrayList array2= new ArrayList();
            array2.Add(13);
            array2.Add(2);
            array2.Add(31);
            array2.Add(4);
            array2.Add(5);
            array2.Sort();
            foreach (var i in array2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------Reverse--------------");
            array2.Reverse();
            foreach (var i in array2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------BinarySearch--------------");
            Console.WriteLine(array2.BinarySearch(5));
            Console.WriteLine("-------------Clear--------------");
            array2.Clear();
            foreach (var i in array2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
