do
{
    Console.WriteLine("ingrese primer numero entero");
    var N1 = (Console.ReadLine());

    if (int.TryParse(N1, out int N1int))
    {
        Console.Write("ingrese segundo numero");
        var N2 = (Console.ReadLine());
        if (int.TryParse(N2, out int N2int))
        {
            if (N1int % N2int == 0)
            {
                Console.WriteLine($"El numero:{N2}, es multiplo de:{N1}");
            }
            else
            {
                Console.WriteLine($"El numero: {N2}, no es multiplo de {N1}");
            }
        }
        else
        {
            Console.WriteLine("debes ingresar un numero entero");
        }






    }
    else
    {
        Console.WriteLine("debes ingresar un numero entero");

    }
}while (true);













