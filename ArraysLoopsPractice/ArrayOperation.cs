namespace ArraysLoopsPractice;

internal class ArrayOperation
{
    public static int[] CreateArrayOfRandomNumbers(int length)
    {
        var random = new Random();
        var array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next();
        }
        return array;
    }

    public static int[] CreateArrayOfEvenNumbers(int[] array)
    {
        var list = new List<int>();
        
        for(var i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
                list.Add(array[i]);
        }
        return list.ToArray();
    }

    public static int[] ChangeElementsWithOddIndex(int[] array)
    {
        var result = new int[array.Length];
        for (var i = 0; i < array.Length; i++)
        {
            result[i] = i % 2 == 0? array[i] : 0;
        }
        return result;
    }

    public static void SelectionSort(string[] array)
    {
        for (var i = 0; i < array.Length - 1; i++)
        {
            var minIndex = i;
            for (var j = i + 1; j < array.Length; j++)
            {
                if (string.Compare(array[j], array[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                var temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }

    public static void BubbleSort(int[] array)
    {
        for(var i = array.Length - 1; i > 0; i--)
        {
            for(int j = 1; j <= i; j++)
            {
                if (array[j - 1] > array[j])
                {
                    var temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;
                }
            }
        }
    }

    public static void PrintArray<T>(T[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

