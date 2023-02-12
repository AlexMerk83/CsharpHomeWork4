bool isWork = true;

while (isWork)
{
    PrintMainMenu();

    if (int.TryParse(Console.ReadLine(), out int taskNo))
    {
        System.Console.WriteLine();

        switch (taskNo)
        {
            case 1: Task25(); break;
            case 2: Task27(); break;
            case 3: Task29(); break;
            case 0: isWork = false; break;
            default: System.Console.WriteLine("There is no such option. Try again."); break;
        }
        
        if (isWork)
            WaitForAnyKey();
        
    }
    else
    {
        System.Console.WriteLine();
        System.Console.WriteLine("There is no such option. Try again.");

        WaitForAnyKey();
    }

}

void PrintMainMenu()
{
    Console.Clear();

    System.Console.WriteLine();
    System.Console.WriteLine("Homework 4 tasks:");
    System.Console.WriteLine("1 - Task 25: ");
    System.Console.WriteLine("2 - Task 27: ");
    System.Console.WriteLine("3 - Task 29: ");
    System.Console.WriteLine("0 - Exit");
    System.Console.Write("Enter a task nunber: ");    
}

void WaitForAnyKey()
{
        System.Console.WriteLine();
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
}

void ClearLine(int lineShift = 0, bool keepCursor = true)
{
    int currentTop = Console.CursorTop,
        currentLeft = Console.CursorLeft;
    
    Console.SetCursorPosition(0, currentTop + lineShift);
    Console.Write(new string(' ', Console.WindowWidth));

    if (keepCursor)
        Console.SetCursorPosition(currentLeft, currentTop);
    else
        Console.SetCursorPosition(0, currentTop + lineShift);
}

int ReadInt(string argument)
{
    int intNum = 0,
        inputFieldX = 0,
        inputFieldY = 0;

    System.Console.Write($"Enter {argument}: ");
    inputFieldX = Console.CursorLeft;
    inputFieldY = Console.CursorTop;
    while (!int.TryParse(Console.ReadLine(), out intNum))
    {
        Console.SetCursorPosition(0, inputFieldY);
        ClearLine();
        System.Console.WriteLine($"Enter {argument}: ");
        System.Console.WriteLine("Input error. This is not an integer number. Try again...");
        Console.SetCursorPosition(inputFieldX, inputFieldY);
    }

    ClearLine();
    
    return intNum;
}

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
void Task25()
{    
    System.Console.WriteLine("Enter two integer numbers A and B, B > 0.");
    
    int a = ReadInt("A");
    int b = ReadInt("B");;

    long res = 1;

    while (b <= 0)
    {
        System.Console.WriteLine("Please enter B > 0.");
        ClearLine(-2, false);
        b = ReadInt("B");
    }   

    for (int i = 0; i < b; i++)
        res *= a;
    
    //System.Console.WriteLine($"{a} to the power of {b} is {res}");
    System.Console.WriteLine("{0} to the power of {1} is {2:N0}", a, b, res);
}

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
void Task27()
{
    int num = ReadInt("an integer number");

    System.Console.WriteLine($"The sum of the digits of {num} is {GetDigitsSum(num)}");
}

int GetDigitsSum(int number)
{
    int res = 0;
    
    number = int.Abs(number);

    while (number / 10 > 0)
    {
        res += number % 10;
        number /= 10;
    }
    
    res += number;

    return res;
}

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void Task29()
{
    bool isWorkTask = true;

    while (isWorkTask)
    {
        int[] array = new int[8];

        PrintTask29Menu();

        if (int.TryParse(Console.ReadLine(), out int optionNo))
        {
            System.Console.WriteLine();

            switch (optionNo)
            {
                case 1: ReadIntArray(array); WriteArray(array); break;
                case 2: FillRandomArray(array, -100, 100); WriteArray(array); break;
                case 0: isWorkTask = false; break;
                default: System.Console.WriteLine("There is no such option. Try again."); break;
            }
            
            if (isWorkTask)
                WaitForAnyKey();
            
        }
        else
        {
            System.Console.WriteLine();
            System.Console.WriteLine("There is no such option. Try again.");

            WaitForAnyKey();
        }

    }
}

void PrintTask29Menu()
{
    Console.Clear();

    System.Console.WriteLine();
    System.Console.WriteLine("Choose how to fill the array.");
    System.Console.WriteLine("1 - Manual filling");
    System.Console.WriteLine("2 - Random filling");
    System.Console.WriteLine("0 - Exit to Main Menu");
    System.Console.Write("Enter a number: ");      
}

void ReadIntArray(int[] arr)
{
    System.Console.WriteLine($"Enter {arr.Length} integer numbers of the Array.");

    for (int i = 0; i < arr.Length; i++)
        arr[i] = ReadInt($"Array[{i}]");
}

void FillRandomArray(int[] arr, int rangeMin, int rangeMax)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rand.Next(rangeMin, rangeMax+1);
}

void WriteArray (int[] arr)
{
    System.Console.Write($"{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
        System.Console.Write($", {arr[i]}");
    System.Console.WriteLine();
}