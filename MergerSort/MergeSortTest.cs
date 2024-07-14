using System;

public class MergeSortTest
{
    public static void Main(string[] args)
    {
        MergeSort sortArray = new MergeSort(10);

        Console.WriteLine("Unsorted: {0}\n\n", sortArray);

        sortArray.Sort(); 

        Console.WriteLine("Sorted: {0}", sortArray);
    }
}
