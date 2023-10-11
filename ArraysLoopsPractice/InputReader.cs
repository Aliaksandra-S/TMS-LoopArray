namespace ArraysLoopsPractice;
internal class InputReader
{
    public static int ReadInteger(int lowerBound, int upperBound)
    {
        var value = -1;
        var input = Console.ReadLine();
        while(!int.TryParse(input, out value) || value < lowerBound || value > upperBound)
        {
            Console.WriteLine("Ввод не соответствует условию! Введите еще раз.");
            input = Console.ReadLine();
        }
        return value;
    }
        
    public static int ReadInteger(int lowerBound)
    {
        return ReadInteger(lowerBound, int.MaxValue);
    }
        
    public static double ReadDouble(double lowerBound, double upperBound)
    {
        var value = -1.0;
        var input = Console.ReadLine();
        while (!double.TryParse(input, out value) || value < lowerBound || value > upperBound)
        {
            Console.WriteLine("Ввод не соответствует условию! Введите еще раз.");
            input = Console.ReadLine();
        }
        return value;
    }

    public static double ReadDouble(double lowerBound)
    {
        return ReadDouble(lowerBound, double.MaxValue);
    }

    public static decimal ReadDecimal(decimal lowerBound)
    {
        var value = -1.0m;
        var input = Console.ReadLine();
        while (!decimal.TryParse(input, out value) || value < lowerBound)
        {
            Console.WriteLine("Ввод не соответствует условию! Введите еще раз.");
            input = Console.ReadLine();
        }
        return value;
    }

    public static int[] ReadIntArray(int lenght)
    {
        var array = new int[lenght];
        for (var i = 0; i < lenght; i++)
        {
            array[i] = ReadInteger(int.MinValue, int.MaxValue);
        }
        return array;
    }

    public static string[] ReadStringArray(int length)
    {
        var array = new string[length];
        for (var i = 0; i < length; i++)
        {
            var input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Некорректный ввод! Попробуйте еще раз.");
                input = Console.ReadLine();
            }
            array[i] = input;
        }
        return array;
    }    
}

