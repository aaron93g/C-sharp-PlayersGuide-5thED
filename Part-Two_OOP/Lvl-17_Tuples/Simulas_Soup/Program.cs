// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
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
*/

//int name = value
//create a tuple variable with types of the enums and assign values to the variable
(Receipe type, Ingredient vegitable, Seasoning season) dish = assignDish();
Console.WriteLine($"{dish.season} {dish.vegitable} {dish.type}");


// create a methode that returns values of the types specified!
(Receipe, Ingredient, Seasoning) assignDish()
{
    // make methods to return values to variables
    Receipe type = assignReceipe();
    Ingredient vegitable = assignIngredient();
    Seasoning season = assignSeasoning();

    // return the variables
    return (type, vegitable, season);
}


Receipe assignReceipe()
{
    Console.WriteLine("choose dish type (soup, stew, gumbo): ");
    string input = Console.ReadLine();
    return input switch
    {
        "soup" => Receipe.Soup,
        "stew" => Receipe.Stew,
        "gumbo" => Receipe.Gumbo
    };
}

Ingredient assignIngredient()
{
    Console.WriteLine(" choose main ingredient for dish (mushroom, chicken, carrot, potatoe): ");
    string input = Console.ReadLine();
    return input switch
    {
        "mushroom" => Ingredient.Mushroom,
        "chicken" => Ingredient.Chicken,
        "carrot" => Ingredient.Carrot,
        "potatoe" => Ingredient.Potatoe,
    };
}

Seasoning assignSeasoning()
{
    Console.WriteLine("Pick season for dish (salty, spicy, sweet): ");
    string input = Console.ReadLine();
    return input switch
    {
        "salty" => Seasoning.Salty,
        "spicy" => Seasoning.Spicy,
        "sweet" => Seasoning.Sweet,
    };
}




enum Receipe { Soup, Stew, Gumbo }
enum Ingredient { Mushroom, Chicken, Carrot, Potatoe }
enum Seasoning { Spicy, Salty, Sweet }
