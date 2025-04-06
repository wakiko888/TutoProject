using Tuto;

Calcu calc = new Calcu();
Console.WriteLine("donnez nombre 1 et 2");
int nb1 = int.Parse(Console.ReadLine());
int nb2 = int.Parse(Console.ReadLine());
string operation = Console.ReadLine();

if (operation == "+") ;
{
    Console.WriteLine(calc.addition(nb1, nb2))
}

if (operation == "-") ;
{
    Console.WriteLine(calc.Substraction(nb1, nb2))
}


if (operation == "*") ;
{
    Console.WriteLine(calc.multiplication(nb1, nb2))
}


if (operation == "/") ;
{
    Console.WriteLine(calc.Division(nb1, nb2))
}


if (operation == "%") ;
{
    Console.WriteLine(calc.Modulo(nb1, nb2))
}

