using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev15
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CompareTo
            //string value1 = "Merhaba";
            //string value2 = "Dünya";

            //var result = value1.CompareTo(value2);
            //Console.WriteLine(result);
            //Console.ReadLine(); 
            #endregion
            #region Compare
            //var valueA = "A";
            //var valueB = "B";
            //var valueC = "C";
            //var valueD = "C";

            //var resultA = string.Compare(valueA, valueB);
            //Console.WriteLine(resultA);
            //var resultB = string.Compare(valueC, valueD);
            //Console.WriteLine(resultB);
            //var resultC = string.Compare(valueC, valueA);
            //Console.WriteLine(resultC);

            //Console.ReadLine(); 
            #endregion
            #region Contains
            //string value1 = "Merhaba";
            //char value2 = 'b';
            //char value3 = 'y';

            //bool result1 = value1.Contains(value2);
            //Console.WriteLine(result1);

            //bool result2 = value1.Contains(value3);
            //Console.WriteLine(result2);

            //Console.ReadLine(); 
            #endregion
            #region StartsEndsWith
            //string value1 = "Merhaba Dünya";
            //string value2 = "nya";
            //string value3 = "Uzay";
            //Console.WriteLine(value1.EndsWith(value2));
            //Console.WriteLine(value1.EndsWith(value3));

            //Console.ReadLine(); 
            #endregion
            #region indexOf
            //string value = "Merhaba Dünya";
            //Console.WriteLine(value.IndexOf('a'));

            //Console.ReadLine(); 
            #endregion
            #region İnsert
            //string value = "Merhaba Dünya";
            //Console.WriteLine(value.Insert(7, ","));

            //Console.ReadLine(); 
            #endregion
            #region LastIndexOf
            //string value = "Merhaba Dünya";
            //int index1 = value.LastIndexOf('h');
            //Console.WriteLine(index1);

            //int index2 = value.LastIndexOf('p');
            //Console.WriteLine(index2);

            //Console.ReadLine(); 
            #endregion
            #region PadLeft
            //PadRiht sağa boşluk atar. 
            //string value1 = "Merhaba Dünya";
            //string value2 = value1.PadLeft(16);
            //Console.WriteLine(value2);

            //Console.ReadLine(); 
            #endregion
            #region Remove
            //string value1 = "Merhaba Dünya";
            //string value2 = value1.Remove(5);
            //Console.WriteLine(value2);

            //Console.ReadLine(); 
            #endregion
            #region Split
            //string value1 =
            //    "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. ";
            //string[] value2 = value1.Split(' ');
            //foreach (string item in value2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadLine(); 
            #endregion
            #region SubString
            //string value = "Merhaba Dünya";
            //Console.WriteLine(value.Substring(4));

            //Console.ReadLine(); 
            #endregion
            #region Trim
            //string value = " Merhaba Dünya ";
            //Console.WriteLine(value.Trim());

            //Console.ReadLine(); 
            #endregion
            #region IsNullOrEmpty
            //string value1 = "Merhaba Dünya";
            //string value2 = "";
            //string value3 = null;

            //Console.WriteLine("String s1 {0}.", string.IsNullOrEmpty(value1));
            //Console.WriteLine("String s2 {0}.", string.IsNullOrEmpty(value2));
            //Console.WriteLine("String s3 {0}.", string.IsNullOrEmpty(value3));

            //Console.ReadLine(); 
            #endregion
            #region IsNullOrWhiteSpace
            //string value1 = "Merhaba Dünya";
            //string value2 = "";
            //string value3 = " ";
            //string value4 = null;

            //Console.WriteLine(string.IsNullOrWhiteSpace(value1));
            //Console.WriteLine(string.IsNullOrWhiteSpace(value2));
            //Console.WriteLine(string.IsNullOrWhiteSpace(value3));
            //Console.WriteLine(string.IsNullOrWhiteSpace(value4));

            //Console.ReadLine(); 
            #endregion
            #region Join
            //string[] values = { "1", "2", "3", "4", "5" };
            //string result = string.Join("", values);
            //Console.WriteLine(result);

            //Console.ReadLine(); 
            #endregion
        }
    }
}
