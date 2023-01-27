using tareasemana2.models;

class Program
{
    static void Main(string[] args)
    {
        Expresion expresion1 = new Expresion { Numero1 = 3, Numero2 = 2 };
        Expresion expresion2 = new Expresion { Numero1 = 15, Numero2 = 20 };

        Console.WriteLine("-----Valores para el primer objeto-----");
        Console.WriteLine("Suma: " + expresion1.Suma());
        Console.WriteLine("Resta: " + expresion1.Resta());
        Console.WriteLine("División: " + expresion1.Division());
        Console.WriteLine("Multiplicación: " + expresion1.Multiplicacion());
        Console.WriteLine("Máximo: " + expresion1.Maximo());
        Console.WriteLine("Mínimo: " + expresion1.Minimo());

        Console.WriteLine("-----Valores para el segundo objeto-----");
        Console.WriteLine("Suma: " + expresion2.Suma());
        Console.WriteLine("Resta: " + expresion2.Resta());
        Console.WriteLine("División: " + expresion2.Division());
        Console.WriteLine("Multiplicación: " + expresion2.Multiplicacion());
        Console.WriteLine("Máximo: " + expresion2.Maximo());
        Console.WriteLine("Mínimo: " + expresion2.Minimo());

        Console.ReadLine();
    }
}
