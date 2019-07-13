using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 101, 102, 100, 100, 110, 109, 109, 108, 109 };
            double[] doubleArray = new double[] { 23, 34, 26, 37, 25, 16, 28 };
            string[] stringArray = new string[] {"z", "y", "x", "w", "v", "u", "t", "s", "r", "q", "p", "o", "n", "m", "l", "k", "j", "i", "h", "g", "f", "e", "d", "c", "b", "a" };
            byte[] byteArray = new byte[20];
            bool[] boolArray = new bool[20];

            Random rand = new Random();

            //Initialization of byteArray
            for(int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] = (byte)rand.Next(0, 256);
            }

            //Initialization of boolArray
            for (int i = 0; i < boolArray.Length; i++)
            {
                if (rand.Next(0, 2) == 0)
                    boolArray[i] = false;
                else
                    boolArray[i] = true;
            }

            BubbleSort<int> intSorter = new BubbleSort<int>(array);
            BubbleSort<string> stringSorter = new BubbleSort<string>(stringArray);
            BubbleSort<byte> byteSorter = new BubbleSort<byte>(byteArray);
            BubbleSort<bool> boolSorter = new BubbleSort<bool>(boolArray);
            BubbleSort<double> doubleSorter = new BubbleSort<double>(doubleArray);

            Console.WriteLine(">> Array for sorting:");

            //For any array defined above
            foreach(var n in doubleArray)
            {
                Console.Write(String.Concat(n.ToString(), ", "));
            }

            Console.WriteLine();

            intSorter.Sort();
            doubleSorter.Sort();
            stringSorter.Sort();
            byteSorter.Sort();
            boolSorter.Sort();

            Console.ReadKey();
        }
    }
}
