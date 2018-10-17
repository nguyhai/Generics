using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> firstIntList = new MyList<int>();
            MyList<int> secondIntList = new MyList<int>();
            MyList<int> result = firstIntList + secondIntList;


            firstIntList.Add(1);
            firstIntList.Add(1);
            firstIntList.Add(1);
            firstIntList.Add(1);
            firstIntList.Add(1);

            Console.WriteLine(firstIntList.Capacity);
            Console.WriteLine(firstIntList.Count);

            Console.WriteLine(firstIntList[0]); // You got an indexer added, so now we can get the number. Holy crap that is cool

            

            //// Bascially, generic methods and classes can take multiple types -----------------------------------

            //int[] array = { 1, 4, 23, 5, 25, 315, 235, 235, 23, 52, 1, 412, 3 };
            //string[] stringArray = { "agasjkfs", "bsdfsdafasd", "csdfsafdsa", "dfafds" };

            //string[] sortedStringArray = Sort(stringArray);
            //int[] sortedIntArray = Sort(array);

            //Console.WriteLine(string.Join(", ", sortedIntArray));
            //Console.WriteLine(string.Join(", ", sortedStringArray));
        }

        //public static T[] Sort<T>(T[] array) where T : IComparable<T>
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = 0; j < array.Length; j++)
        //        {
        //            if (array[i].CompareTo(array[j]) > 0 )
        //            {
        //                T temp = array[i];
        //                array[i] = array[j];
        //                array[j] = temp;
        //            }
        //        }
        //    }
        //    return array;
        //}

        //public static bool AreEqual<T>(T num1, T num2) where T:IComparable<T>
        //{
        //    return num1.CompareTo(num2) == 0;
        //}


    }
}
