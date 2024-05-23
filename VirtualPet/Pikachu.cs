namespace VirtualPet;

public class Pikachu
{
    private int _hunger;
    private int _cleanliness;

    public Pikachu(int hunger = 40, int cleanliness = 20)
    {
        _hunger = hunger;
        _cleanliness = cleanliness;
    }

    public void ShowPikachu()
    {
        Console.Clear();
        var originalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Pikachu\n");
        Console.ForegroundColor = originalColor;
        Console.WriteLine($"Hunger: {_hunger}");
        Console.WriteLine($"Cleanliness: {_cleanliness}");
    }

    public void FeedPikachu()
    {
        Console.Clear();
        Console.WriteLine("Pikachu has been fed!");
        Console.WriteLine("Pikachu spilled food all over himself!");
        _hunger += 20;
        _cleanliness -= 10;
        Thread.Sleep(1000);
    }

    public void CleanPikachu()
    {
        Console.Clear();
        Console.WriteLine("Pikachu has been cleaned!");
        Console.WriteLine("Pikachu is hungry!");
        _hunger -= 10;
        _cleanliness += 20;
        Thread.Sleep(1000);
    }

    public void ReduceFoodAndOther()
    {
        _hunger -= 6;
        _cleanliness -= 6;
    }
    public void PetPikachu()
    {
        Console.Clear();
        Console.WriteLine("You pet Pikachu.");
        Console.WriteLine("Pikachu smiles at you.");
        Thread.Sleep(1000);
    }

    public static Pikachu LoadPikachu()
    {
        var pikachu = new Pikachu();
        return pikachu;
    }
}