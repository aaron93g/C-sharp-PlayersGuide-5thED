// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


(Receipe, Ingredient, Seasoning) dish;
string plate;
string vegetable;
string taste;

Console.WriteLine($"What kind of dish would you like? {Receipe.Gumbo}, {Receipe.Soup}, or {Receipe.Stew}?");
plate = Console.ReadLine();

Console.WriteLine($"What kind of ingredient would you like? {Ingredient.Carrot}, {Ingredient.Potatoe}, or {Ingredient.Mushroom}?");
vegetable = Console.ReadLine();


Console.WriteLine($"What kind of ingredient would you like? {Seasoning.Spicy}, {Seasoning.Sweet}, or {Seasoning.Salty}?");
taste = Console.ReadLine();


if(plate == "Stew" && vegetable == "Carrot" && taste == "Salty")
{
    Console.WriteLine($"{Seasoning.Salty} {Ingredient.Carrot} {Receipe.Stew}!");
}



enum Receipe { Soup, Stew, Gumbo }
enum Ingredient { Mushroom, Checken, Carrot, Potatoe }
enum Seasoning { Spicy, Salty, Sweet }
