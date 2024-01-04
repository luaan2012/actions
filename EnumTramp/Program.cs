using Ardalis.GuardClauses;

namespace EnumTramp;

class Program
{
    static void Main(string[] args)
    {
        var saoPaulo = HumaStates.SaoPaulo.ToString();
        var capital = nameof(HumaStates.Capital);
        var soares = HumaStates.Soares.ToString("F");

        Console.WriteLine(saoPaulo);
        Console.WriteLine(capital);
        Console.WriteLine(soares);

        Guard.Against.NullOrWhiteSpace("ts");
    }

    public enum HumaStates
    {
        SaoPaulo,
        Capital,
        Soares
    }
}