using System;

public class MergeSort
{
    private int[] data; 
    private static Random generator = new Random();

    public MergeSort(int size)
    {
        data = new int[size]; 

        // Fill array with random ints in range 10-99
        for (int i = 0; i < size; ++i)
            data[i] = generator.Next(10, 100);
    }

    // Sorts the array using merge sort
    public void Sort()
    {
        SortArray(0, data.Length - 1); // Sort entire array
    }

    // Recursively sorts the array using merge sort
    private void SortArray(int low, int high)
    {
        // Base case: if size of array equals 1
        if ((high - low) >= 1)
        {
            int middle1 = (low + high) / 2; // Calculate middle of array
            int middle2 = middle1 + 1; // Calculate next element over

            // Output split step
            Console.WriteLine("split: " + Subarray(low, high));
            Console.WriteLine(" " + Subarray(low, middle1));
            Console.WriteLine(" " + Subarray(middle2, high));
            Console.WriteLine();

            // Split array in half; sort each half (recursive calls)
            SortArray(low, middle1); // First half of array
            SortArray(middle2, high); // Second half of array

            // Merge two sorted arrays after split calls return
            Merge(low, middle1, middle2, high);
        }
    }

    // Merge two sorted subarrays into one sorted subarray
    private void Merge(int left, int middle1, int middle2, int right)
    {
        int leftIndex = left; // Index into left subarray
        int rightIndex = middle2; // Index into right subarray
        int combinedIndex = left; // Index into temporary working array
        int[] combined = new int[data.Length]; // Working array

        // Output two subarrays before merging
        Console.WriteLine("merge: " + Subarray(left, middle1));
        Console.WriteLine(" " + Subarray(middle2, right));

        // Merge arrays until reaching end of either
        while (leftIndex <= middle1 && rightIndex <= right)
        {
            if (data[leftIndex] <= data[rightIndex])
                combined[combinedIndex++] = data[leftIndex++];
            else
                combined[combinedIndex++] = data[rightIndex++];
        }

        
        if (leftIndex == middle2)
        {
            while (rightIndex <= right)
                combined[combinedIndex++] = data[rightIndex++];
        }
        else 
        {
            while (leftIndex <= middle1)
                combined[combinedIndex++] = data[leftIndex++];
        }
        for (int i = left; i <= right; ++i)
            data[i] = combined[i];

        // Output merged array
        Console.WriteLine(" " + Subarray(left, right));
        Console.WriteLine();
    }

    public string Subarray(int low, int high)
    {
        string temporary = string.Empty;

        for (int i = 0; i < low; ++i)
            temporary += " ";

        for (int i = low; i <= high; ++i)
            temporary += " " + data[i];

        return temporary;
    }
    public override string ToString()
    {
        return Subarray(0, data.Length - 1);
    }
}
