/// <summary>
/// make method that take int and subtracts by 1 and stops at 1.
/// have method call self to keep subtracting
/// </summary>
/// 

int countDownRecursion(int start)
{
    if (start == 1)
    {
        Console.WriteLine(start);
        return start;
    }
    Console.WriteLine(start);
    return countDownRecursion(start - 1);
}

countDownRecursion(10);