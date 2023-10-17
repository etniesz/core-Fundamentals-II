static void PrintNumbers()
{
    for (int i = 1; i <= 255; i++)
    {
        Console.WriteLine(i);
    }
}

static void PrintOdds()
{
    for (int i = 1; i <= 255; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}

static void PrintSum()
{

    int sum = 0;
    for (int i = 0; i <= 255; i++)
    {
        sum = sum + i;
        Console.WriteLine($"New number: {i} Sum: {sum}");
    }
}

static void LoopArray(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}

static int FindMax(int[] numbers)
{
    int max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}

static void GetAverage(int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    double average = (double)sum / numbers.Length;
    Console.WriteLine($"Average: {average}");
}

static List<int> OddList()
{
    List<int> oddNumbers = new List<int>();
    for (int i = 1; i <= 255; i += 2)
    {
        oddNumbers.Add(i);
    }

    return oddNumbers;
}

static int GreaterThanY(List<int> numbers, int y)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        if (number > y)
        {
            sum += 1;
        }
    }

    return sum;
}

static void SquareArrayValues(List<int> numbers)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        numbers[i] = numbers[i] * numbers[i];
    }
}

static void EliminateNegatives(List<int> numbers)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] < 0)
        {
            numbers.RemoveAt(i);
        }
    }
}

int[] numbersArray = new int[10] { 5, -3, 7, -2, 8, -1, 10, -6, 4, -9 };
List<int> numbersList = new List<int> { 5, -3, 7, -2, 8, -1, 10, -6, 4, -9 };

PrintNumbers();
PrintOdds();
PrintSum();
LoopArray(numbersArray);
FindMax(numbersArray);
GetAverage(numbersArray);
OddList();
GreaterThanY(numbersList, 5);
SquareArrayValues(numbersList);
EliminateNegatives(numbersList);