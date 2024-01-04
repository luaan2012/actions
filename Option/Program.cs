using System.IO.Compression;

namespace Option.Program;

class Program
{
    static string EnvironmentKCC = "\\\\servidor02\\inetpub\\kcfarma.com.br\\Private\\CargaPortal\\dados_2";
    static string PathSource = "C:\\Users\\luan.santos\\Downloads\\MeusZips";

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        ShowArgs(args);

        GetChoose();
    }

    static void GetChoose ()
    {
        ConsoleKeyInfo keyPress = new ();

        while (keyPress.Key != ConsoleKey.Escape)
        {
            Menu();

            keyPress = Console.ReadKey();

            Console.Write("");

            HandlingMenu(keyPress.Key);
        }
    }

    static void HandlingMenu(ConsoleKey keyPress)
    {
        switch (keyPress)
        {
            case ConsoleKey.D1:
                ShowFiles();
                break;

            default:
                Console.WriteLine($"Nenhuma ação foi encontrada.");
                break;
        }
    }

    static void HandlingMenu2(ConsoleKey keyPress)
    {
        switch (keyPress)
        {
            case ConsoleKey.D1:
                ZipFiles();
                break;

            default:
                Console.WriteLine($"Nenhuma ação foi encontrada.");
                break;
        }
    }

    static void ShowFiles()
    {
        if(!Directory.Exists(EnvironmentKCC))
        {
            Console.WriteLine("Diretorio não existe");
            return;
        }

        var filesDirectory = Directory.GetFiles(EnvironmentKCC).Select(Path.GetFileName);

        Console.WriteLine($"Foram encontrados nessa pasta {filesDirectory.Count()}");

        for (int i = 0; i < filesDirectory.Count(); i++)
        {
            Console.WriteLine($"{i + 1} - {filesDirectory.ElementAt(i)}");
        }

        Console.WriteLine();

        Menu2();

        var keyPress = Console.ReadKey();

        HandlingMenu2(keyPress.Key);
    }

    static void ShowArgs(string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine($"Argumento número {i + 1}: {args[i]}");
        }
    }

    static void ZipFiles()
    {
        if (!Directory.Exists(PathSource))
        {
            Directory.CreateDirectory(PathSource);
        }

        try
        {
            ZipFile.CreateFromDirectory(EnvironmentKCC, PathSource);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Aconteceu um erro ao tentar zipar esses arquivos: {ex.Message}");
        }
    }

    static void Menu()
    {
        Console.Write("");

        Console.WriteLine(@"
        [1] - List Files 
        ");
    }

    static void Menu2()
    {
        Console.Write("");

        Console.WriteLine(@"
        [1] - Deseja zipar esses arquivos?
        ");
    }
}