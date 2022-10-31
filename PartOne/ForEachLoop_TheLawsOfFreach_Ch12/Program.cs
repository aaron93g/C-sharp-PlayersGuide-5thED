int[] firstArray = new int[5] { 5, 7, 1, 45, 4 };
int minNumber = firstArray[0];
double averageArray = 0;

foreach (int i in firstArray)   // Get min value
{
    if (i < minNumber)
    {
        minNumber = i;
    }
}

foreach (int i in firstArray)   // Get Average
{
    averageArray += i;
}
averageArray /= firstArray.Length;

Console.WriteLine(" minNumber " + minNumber + " " + "average array " + averageArray);