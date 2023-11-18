using TheElseKeyword;

class Program
{
    static void Main(string[] args)
    {
        var recipebook = new RecipeBook(Console.ReadLine, Console.WriteLine);
        var bartender = new BartenderRefac(Console.ReadLine, Console.WriteLine, recipebook);

        while (true)
        {
            bartender.AskForDrink();
        }
    }
}