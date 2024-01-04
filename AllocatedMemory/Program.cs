namespace AllocatedMemory;

class Program
{
    static void Main(string[] args)
    {
        int number = 10;
        //unsafe
        //{
        //    int* pointer = &number;
        //}

        var numbera = new Application();

        //Console.WriteLine(nameof(Application));
    }

    public class Application
    {
        private int number = 6;
    }
}