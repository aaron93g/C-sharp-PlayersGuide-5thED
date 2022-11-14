// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Arrow choiceOne = assignArrowInfo();// CALL METHOD TO INVOKE A CONSTRUCT
Console.WriteLine($"That arrow costs {choiceOne.GetCost()} gold.");





    // PLACE ARROW OBJECTS INTO VARIABLES
    Arrow assignArrowInfo()
    {
        ArrowHead holder1 = getArrowHead();
        Fletching holder2 = getFletching();
        int holder3 = getLength();
        return new Arrow(holder1, holder2, holder3); // RETURN NEW INSTANCE OF CLASS
    }



// GETS ARROW OBJECTS
ArrowHead getArrowHead()
{
    //switch case 
    Console.Write("select one arrow head of steel, wood, or obsidian: ");
    string input = Console.ReadLine();
    return input switch
    {
        "steel" => ArrowHead.Steel,
        "wood" => ArrowHead.Wood,
        "obsidian" => ArrowHead.Obsidian
    };
}
Fletching getFletching()
{
    //switch case 
    Console.Write("select a fletching Plastic, turkey, or goose: ");
    string input = Console.ReadLine();
    return input switch
    {
        "plastic" => Fletching.Plastic,
        "turkey" => Fletching.Turkey,
        "goose" => Fletching.Goose
    };
}
int getLength()
{
    Console.Write("enter a  size you want for the length: ");
    int input = int.Parse(Console.ReadLine());
    return input;
}



class Arrow // CONTAIN A CONSTRUCTOR AND A CALC COST METHOD USING LOCAL VARIABLES
{
public ArrowHead headType;
public Fletching featherType;
public int shaftLegnth;

    public Arrow(ArrowHead headType, Fletching featherType, int shaftLegnth)
    {
        this.headType = headType;
        this.featherType = featherType;
        this.shaftLegnth = shaftLegnth;
    }

    public float GetCost()
    {
        float arrowheadCost = headType switch
        {
            ArrowHead.Steel => 10,
            ArrowHead.Wood => 3,
            ArrowHead.Obsidian => 5,
        };
        float fletchingCost = featherType switch
        {
            Fletching.Plastic => 10,
            Fletching.Turkey => 5,
            Fletching.Goose => 3,
        };
        float shaftCost = 0.05f * shaftLegnth;

        return arrowheadCost + fletchingCost + shaftCost;
    }

}



enum ArrowHead 
{ 
    Steel, 
    Wood, 
    Obsidian
};
enum Fletching
{
    Plastic,
    Turkey,
    Goose,
};