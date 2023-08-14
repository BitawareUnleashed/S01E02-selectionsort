using System;



int[] arr = { 64, 25, 12, 22, 11 };
Console.WriteLine("Array prima dell'ordinamento:");
PrintArray(arr);

SelectionSortAlgorithm(arr);

Console.WriteLine("\nArray dopo l'ordinamento:");
PrintArray(arr);


Console.ReadLine();


static void SelectionSortAlgorithm(int[] arr)
{
    int n = arr.Length;

    for (int i = 0; i < n - 1; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (arr[j] < arr[minIndex])
            {
                minIndex = j;
            }
        }

        // Scambio gli elementi
        int temp = arr[minIndex];
        arr[minIndex] = arr[i];
        arr[i] = temp;
    }
}

static void PrintArray(int[] arr)
{
    foreach (int num in arr)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}
