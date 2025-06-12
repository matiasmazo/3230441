do { 
Console.WriteLine("Ingrese primer numero entero:");
var N1= int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese segundo numero entero:");
    var N2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese tercer numero entero:");
    var N3 = int.Parse(Console.ReadLine());

    if (N1 > N2 & N2 > N3)
    {
        Console.WriteLine($"El numero mayor es:{N1}");
    }
    else if (N1 > N3 & N3 > N2)
    {
        Console.WriteLine($"El numero mayor es:{N1}");
    }
    else if (N2 > N1 & N1 > N3)
    {
        Console.WriteLine($"El numero mayor es:{N2}");
    }
    else if (N2 > N3 & N3 > N1)
    {
        Console.WriteLine($"El numero mayor es:{N2}");
    }
    else if (N3 > N1 & N1 > N2)
    {
        Console.WriteLine($"El numero mayor es:{N3}");
    }
    else if (N3 > N2 & N2 > N1)
    {
        Console.WriteLine($"El numero mayor es:{N3}");
    }


    } while (true) ;

  





    