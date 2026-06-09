public void mostrarMenu()
{
    Console.WriteLine("-------------MENU-------------\n");
    Console.WriteLine("Ingrese el numero que desea invertir");
    Console.WriteLine("1-Sumar\n");
    Console.WriteLine("2-Restar\n");
    Console.WriteLine("3-Multiplicar\n");
    Console.WriteLine("4-Dividir\n");
    Console.WriteLine("5-Salir\n");
}


int opcion=1, num1, num2, resultado;
string cadena,cadenaNum1,cadenaNum2;
while(opcion !=5)
{
    mostrarMenu();
    cadena = Console.ReadLine();
    opcion = int.Parse(cadena);
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el primer numero");
            cadenaNum1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero");
            cadenaNum2 = Console.ReadLine();
            if (int.TryParse(cadenaNum1, out num1) && int.TryParse(cadenaNum2, out num2))
            {
                resultado = num1 + num2;
                Console.WriteLine($"el resultado es {resultado}");
            }
        break;
        case 1:
            Console.WriteLine("Ingrese el primer numero");
            cadenaNum1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero");
            cadenaNum2 = Console.ReadLine();
            if (int.TryParse(cadenaNum1, out num1) && int.TryParse(cadenaNum2, out num2))
            {
                resultado = num1 + num2;
                Console.WriteLine($"el resultado es {resultado}");
            }
        break;
        case 1:
            Console.WriteLine("Ingrese el primer numero");
            cadenaNum1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero");
            cadenaNum2 = Console.ReadLine();
            if (int.TryParse(cadenaNum1, out num1) && int.TryParse(cadenaNum2, out num2))
            {
                resultado = num1 + num2;
                Console.WriteLine($"el resultado es {resultado}");
            }
        break;
        case 1:
            Console.WriteLine("Ingrese el primer numero");
            cadenaNum1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero");
            cadenaNum2 = Console.ReadLine();
            if (int.TryParse(cadenaNum1, out num1) && int.TryParse(cadenaNum2, out num2))
            {
                resultado = num1 + num2;
                Console.WriteLine($"el resultado es {resultado}");
            }
        break;             
    }
}



cadena = Console.ReadLine();

{
    if (num>0)
    {
        while (num != 0)
        {
            numeroFinal *= 10;
            digito = num % 10;
            numeroFinal += digito;
            num /= 10;
        }
        Console.WriteLine($"{numeroFinal}");
    }else
    {
        Console.WriteLine("Lo que ingreso no es valido");
    }
}else
{
    Console.WriteLine("Lo que ingreso no es valido");
}

