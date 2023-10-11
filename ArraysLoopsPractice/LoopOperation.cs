namespace ArraysLoopsPractice;

internal class LoopOperation
{
    public static void PrintFibonacciSequence(int n)
    {
        var first = 0;
        var second = 1;

        Console.WriteLine("Последовательность Фибоначчи из n элементов:");
        Console.Write(first);

        for (int i = 1; i < n; i++)
        {
            Console.Write(" " + second);
            var temp = first + second;
            first = second;
            second = temp;
        }
        Console.WriteLine();
    }

    public static decimal CalculateTotalDeposit(decimal sum, double interestRate, int months)
    {
        for(var i = 0; i < months; i++)
        {
            sum += sum * (decimal)(interestRate * 0.01 / 12);
        }
        return sum;
    }
}

