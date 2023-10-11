namespace ArraysLoopsPractice;
class Program
{
    static void Main(string[] args)
    {
        var isFinished = false;
        while (!isFinished)
        {
            Console.WriteLine("\nВыберите задачу:");
            Console.WriteLine("1 - Последовательность Фибоначчи");
            Console.WriteLine("2 - Сумма банковского вклада");
            Console.WriteLine("3 - Массив случайных чисел");
            Console.WriteLine("4 - Элементы массива с нечетными индексами = 0");
            Console.WriteLine("5 - Массив имен");
            Console.WriteLine("6 - Сортировка пузырьком");
            Console.WriteLine("0 - ВЫХОД");
            Console.Write("\nВведите номер: ");
            var operation = InputReader.ReadInteger(0, 6);

            Console.WriteLine();

            switch (operation)
            {
                case 0:
                {
                    isFinished = true;
                    Console.WriteLine("Пока :)");
                    break;
                }
                case 1:
                {
                    Console.Write("Введите длину последовательности: ");
                    var count = InputReader.ReadInteger(0);
                    LoopOperation.PrintFibonacciSequence(count);
                    break;
                }

                case 2:
                {
                    Console.Write("Введите сумму вклада: ");
                    var initialSum = InputReader.ReadDecimal(0);
                    Console.Write("Введите процент вклада (%): ");
                    var interestRate = InputReader.ReadDouble(0, 100);
                    Console.Write("Введите количество месяцев вклада: ");
                    var months = InputReader.ReadInteger(0);
                    var totalSum = LoopOperation.CalculateTotalDeposit(initialSum, interestRate, months);
                    Console.WriteLine($"Итоговая сумма вклада: {totalSum:F2}");
                    break;
                }

                case 3:
                {
                    Console.Write("Введите размерность массива (5, 10]: ");
                    var length = InputReader.ReadInteger(6, 10);
                    var array = ArrayOperation.CreateArrayOfRandomNumbers(length);
                    ArrayOperation.PrintArray(array);
                    var arrayOfEven = ArrayOperation.CreateArrayOfEvenNumbers(array);
                    Console.WriteLine($"В этом массиве {arrayOfEven.Length} четных чисел:");
                    ArrayOperation.PrintArray(arrayOfEven);
                    break;
                }

                case 4:
                {
                    Console.Write("Введите размерность массива: ");
                    var length = InputReader.ReadInteger(0);
                    Console.WriteLine("Вводите элементы целочисленного массива по одному в строке:");
                    var array = InputReader.ReadIntArray(length);
                    Console.WriteLine("Исходный массив:");
                    ArrayOperation.PrintArray(array);
                    Console.WriteLine("\nРезультат:");
                    var changedArr = ArrayOperation.ChangeElementsWithOddIndex(array);
                    ArrayOperation.PrintArray(changedArr);
                    break;
                }

                case 5:
                {
                    Console.Write("Введите размерность массива: ");
                    var length = InputReader.ReadInteger(0);
                    Console.WriteLine("Заполните массив именами по одному в строке:");
                    var array = InputReader.ReadStringArray(length);
                    Console.WriteLine("Исходный массив:");
                    ArrayOperation.PrintArray(array);
                    ArrayOperation.SelectionSort(array);
                    ArrayOperation.PrintArray(array);
                    break;
                }

                case 6:
                {
                    Console.Write("Введите размерность массива: ");
                    var length = InputReader.ReadInteger(0);
                    Console.WriteLine("Вводите элементы целочисленного массива по одному в строке:");
                    var array = InputReader.ReadIntArray(length);
                    Console.WriteLine("Исходный массив:");
                    ArrayOperation.PrintArray(array);
                    Console.WriteLine("\nРезультат:");
                    ArrayOperation.BubbleSort(array);
                    ArrayOperation.PrintArray(array);
                    break;
                }
            }
        }
    }

}