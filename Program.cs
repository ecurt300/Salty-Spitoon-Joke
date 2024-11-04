using System;

//A Simple Joke Project --- I have been watching way too much Spongebob repeats.
public static class SaltySpitoon
{
    private static Dictionary<int, string> ToughnessValues = new Dictionary<int, string>();


    private static void Setup()
    {
        ToughnessValues.Clear();
        Random random = new Random();
        string toughness0 = "I am sorry but I think you'll be more happy at SuperWheenieHutJr";
        string toughness1 = "Your pretty weenie";
        string toughness2 = "You think your that tough huh? Sorry Still not getting in";
        string toughness3 = "Not tough enough";
        string toughness4 = "Unless you're tough enough to fight me you cannot get in.";
        string toughness5 = "Oww my tattoo!! Right this way!!";

        int toughnessSpawn0 = random.Next(6);
        int toughnessSpawn1 = random.Next(6);
        int toughnessSpawn2 = random.Next(6);
        int toughnessSpawn3 = random.Next(6);
        int toughnessSpawn4 = random.Next(6);
        int toughnessSpawn5 = random.Next(6);
        ToughnessValues.TryAdd(toughnessSpawn0, toughness0);
        ToughnessValues.TryAdd(toughnessSpawn1, toughness1);
        ToughnessValues.TryAdd(toughnessSpawn2, toughness2);

        ToughnessValues.TryAdd(toughnessSpawn3, toughness3);
        ToughnessValues.TryAdd(toughnessSpawn4, toughness4);
        ToughnessValues.TryAdd(toughnessSpawn5, toughness5);
    }
    private  static void Choose(ref string? userInput)
    {
        Random random = new Random();
        int choice =  random.Next(6);
        string winText = "Oww my tattoo!! Right this way!!";
        string? choiceText = ToughnessValues.GetValueOrDefault(choice);
        Console.WriteLine(choiceText);
        if (choiceText == (winText) && choiceText != null)
        {
            
            Console.WriteLine("You have entered the Salty Spittoon but you slipped on an icecube and got covered in booboos");
           
        }
        else
        {
            Console.WriteLine("Come back when you're tough enough to enter!");
            Setup();
        }

    }
    public static void Main(String[] args)
    {
        Setup();

        Console.WriteLine("------Welcome to the Salty Spitoon, how tough are you?------");
        Console.WriteLine("------type howtoughami to see how tough are you? or exit to exit------");
        string? userInput = Console.ReadLine()?.Trim().ToLower();
        while (userInput != null && userInput != "exit")
        {
            if (userInput == "howtoughami")
            {
                Choose(ref userInput);
            }
            userInput = Console.ReadLine()?.Trim().ToLower();
        }

    }

}
