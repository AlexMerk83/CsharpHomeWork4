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

void ClearLine(int lineShift = 0)
{
    int currentTop = Console.CursorTop,
        currentLeft = Console.CursorLeft;
    
    Console.SetCursorPosition(0, currentTop + lineShift);
    Console.Write(new string(' ', Console.WindowWidth)); 
    Console.SetCursorPosition(currentLeft, currentTop);
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

}

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
void Task27()
{

}

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void Task29()
{

}