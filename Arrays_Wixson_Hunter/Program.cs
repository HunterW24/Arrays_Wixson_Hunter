using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements to be stored in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        // Input values for array elements
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter value for element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Find the sum of all elements in the array
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        Console.WriteLine($"Sum of all elements in the array: {sum}");

        // Sort the elements of the array in ascending order
        Array.Sort(arr);

        // Print the sorted array
        Console.WriteLine("Sorted array:");
        foreach (int num in arr)
        {
            Console.Write($"{num} ");
        }
    }
}

