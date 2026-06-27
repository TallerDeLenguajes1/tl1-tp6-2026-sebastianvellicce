void mostrarMenu()
{
    Console.WriteLine("-------------MENU-------------\n");
    Console.WriteLine("1-Sumar\n");
    Console.WriteLine("2-Restar\n");
    Console.WriteLine("3-Multiplicar\n");
    Console.WriteLine("4-Dividir\n");
    Console.WriteLine("5-Salir\n");
}
int opcion, num1, num2, resultado;
string cadena, cadenaNum1, cadenaNum2;

mostrarMenu();

Console.WriteLine("Ingrese una opcion");
cadena = Console.ReadLine();
opcion = int.Parse(cadena);



while (opcion != 5)
{
    if (opcion > 0 && opcion <= 5)
    {
        Console.WriteLine("Ingrese su primer numero\n");
        cadenaNum1 = Console.ReadLine();
        Console.WriteLine("Ingrese el segundo numero\n");
        cadenaNum2 = Console.ReadLine();

        if (int.TryParse(cadenaNum1, out num1) && int.TryParse(cadenaNum2, out num2))
        {
            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"El resultado es {resultado}\n");
                    break;

                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"El resultado es {resultado}\n");
                    break;

                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"El resultado es {resultado}\n");
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"El resultado es {resultado}\n");
                    }
                    else
                    {
                        Console.WriteLine("Indefinido\n");
                    }
                    break;
            }

        }
        else
        {
            Console.WriteLine("Debe ingresar numeros\n");
        }
    }
    else
    {
        Console.WriteLine("Opcion invalida\n");
    }

    mostrarMenu();
    Console.WriteLine("Ingrese una opcion");
    cadena = Console.ReadLine();
    opcion = int.Parse(cadena);
}
Console.WriteLine("Saliendo...\n");
