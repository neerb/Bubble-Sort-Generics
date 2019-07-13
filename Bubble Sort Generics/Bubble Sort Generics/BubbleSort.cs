using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BubbleSort<T> where T : IComparable<T>
{
    T[] array { get; set; }
    T[] returntoOrginalArray;

    public BubbleSort(T[] arraytoSort)
    {
        array = arraytoSort;
        returntoOrginalArray = arraytoSort;
    }

    int tracker = 0;
    T current;
    int totalExchanges;
    int totalPasses;

    public void Sort()
    {
        while(tracker < array.Length - 1)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                current = array[i];
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    array[i] = array[i + 1];
                    array[i + 1] = current;
                    tracker = 0;
                    totalExchanges++;
                }
                else
                    tracker++;
            }
            totalPasses++;
        }

        Console.WriteLine(">> Sorted Array: ");
        printArray();
    }
    

    private void printArray()
    {
        foreach (T variable in array)
        {
            Console.Write(String.Concat(variable.ToString(), ", "));
        }

        Console.WriteLine();
        Console.WriteLine(">> Total Exchanges: " + totalExchanges.ToString());
        Console.WriteLine(">> Total Passes: " + totalPasses);

        tracker = 0;
        totalExchanges = 0;
        totalPasses = 0;

        array = returntoOrginalArray;

        Console.WriteLine("-");
    }
}

