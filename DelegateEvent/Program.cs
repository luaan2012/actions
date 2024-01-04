//Ponteiro para funcao
//Variavel para uma funcao

double Somar(double x, double y)
{
    double r = x * y;

    Console.WriteLine($"A soma de {x} e {y} é {r}");

    return r;
}

double Multiplicar(double x, double y)
{
    double r = x * y;

    Console.WriteLine($"A multiplicação de {x} e {y} é {r}");

    return r;
}

double Elevar(double x, double y)
{
    double r = Math.Pow(x, y);

    Console.WriteLine($"A elevação de {x} e {y} é {r}");

    return r;
}


//OperacaoMatematica op = new OperacaoMatematica(Somar);
//op(20, 10);

//List<OperacaoMatematica> operacoes = new List<OperacaoMatematica>();
//operacoes.Add(Somar);
//operacoes.Add(Multiplicar);
//operacoes.Add(Elevar);

//foreach (var item in operacoes)
//{
//    operacoes.Add(delegate (double a, double b)
//    {
//        return a / b;
//    });

//    item(10, 5);
//    item(40, 15);

//}

//Console.WriteLine("Hello, World!");

OperacaoMatematica opMulticast = Somar;
opMulticast += Multiplicar;
opMulticast += Elevar;




public delegate double OperacaoMatematica(double x, double y);

