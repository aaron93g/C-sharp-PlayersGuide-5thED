using System.Reflection.Emit;
int turnCounter = 1;
int ManticoreHealth = 20;
int ConsolaHealth = 15;
int manticorePosition; // how far from city/ 0 - 100
int defendersAttack; // chose number to guess manticore / 


// player 1 chooses number
manticorePosition = askForNumber("enter an integer representing the position of The Manticore: ");
Console.Clear();

Console.WriteLine("Player 2, it is your turn.");
Console.WriteLine("------------------------------------------------------");

// While LOOP continues the turns until zero is met
while(ConsolaHealth > 0 && ManticoreHealth > 0)
{

    Console.WriteLine($"STATUS: Round: {turnCounter} City: {ConsolaHealth}/15  Manticore: {ManticoreHealth}/10");
    Console.WriteLine($"The cannon is expected to deal {damageMultiplyer(turnCounter)} damage this round.");
    defendersAttack = askForNumber("Defender, enter desired cannon range: ");

    ManticoreHealth = HitStatus(ManticoreHealth, manticorePosition, defendersAttack);
    ConsolaHealth--;
    turnCounter++;

    Console.WriteLine("------------------------------------------------------");

}


// displays message for game outcome
if (ConsolaHealth <= 0)
{
    Console.WriteLine("The City was destroyed, Try Again!");
}
else if (ManticoreHealth <= 0)
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");





// checks if counter(round) is a multiple of 3 or 5, then apllies 3 or 5 or 10 damage
static int damageMultiplyer(int turn)
{
    if (!(turn % 3 == 0 || turn % 5 == 0))
    {
        return 1;
    }
    else if (turn % 3 == 0 && turn % 5 == 0)
    {
        return 10;
    }
    else return 3;
}   


//required integer and 1-100
int askForNumber(string text)
{
    Label:
    try
    {
        Console.Write(text);
        int number;

        while (true)
        {
            number = Int32.Parse(Console.ReadLine());
            if (!(number >= int.MinValue) || !(number <= int.MaxValue))
            {
                Console.WriteLine("Must be an integer entered: ");
                number = Int32.Parse(Console.ReadLine());
            }
            else if (number < 1 || number > 100)
            {
                Console.WriteLine("number must be a number between 0 and 100 ");
            }
            else return number;
        }
    }
    catch(FormatException fex)
    {
        Console.WriteLine("Invalid Input");
        Console.WriteLine("More details about Error: \n\n" + fex.ToString() + "\n\n");
        goto Label;
    }

}

//display if player2 got a hit, high miss, or low miss on player1 
int HitStatus(int player1Health, int player1Position, int player2Attack)
{
    if (player2Attack > player1Position)
        Console.WriteLine("That round OVERSHOT the target! \n");
    else if (player2Attack < player1Position)
        Console.WriteLine("That round FELL SHORT of the target! \n");
    else
    {
        Console.WriteLine("That round was a DIRECT HIT! Fire Again! \n");
        player1Health -= damageMultiplyer(turnCounter);
    }

    return player1Health;
}