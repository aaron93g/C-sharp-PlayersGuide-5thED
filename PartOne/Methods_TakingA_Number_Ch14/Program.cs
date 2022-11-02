///<summary>
///intro to methods. 
/// </summary>
/// 

int AskForNumber(string text)
{
    Console.WriteLine(text);
    return Int32.Parse(Console.ReadLine());

}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int triedNumber = AskForNumber(text);
        if (min <= triedNumber && max >= triedNumber)
            return triedNumber;
    }
}

//int result = AskForNumber("what is the airspeed velocity of an unladen swallow?");

int result = AskForNumberInRange(" Enter a number within 0 and 100 ", 0, 100);
