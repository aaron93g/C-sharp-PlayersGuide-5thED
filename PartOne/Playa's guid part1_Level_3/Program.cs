// See https://aka.ms/new-console-template for more information

Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine();//string for a noun

Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine();//store string, for adjective

string c = "of Doom";
string d = "3000";
/* below is the concantenation of the adjective noun and */
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");

