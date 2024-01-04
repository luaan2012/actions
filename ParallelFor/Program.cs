// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var array = new int[1000000];

void For()
{

    for (int i = 0; i < 1_000_000; i++)
    {
        array[i] = i;
    }

}

void Pararell()
{

    Parallel.For(0, 1000000, i =>
    {
        array[i] = i;
    });

}

var teste = 0; 