void mostrarMenu()
{
    Console.WriteLine("-------------MENU-------------\n");
    Console.WriteLine("1-Sumar\n");
    Console.WriteLine("2-Restar\n");
    Console.WriteLine("3-Multiplicar\n");
    Console.WriteLine("4-Dividir\n");
    Console.WriteLine("5-Salir\n");
}
int opcion; 
float num1, num2, resultado, numUnico, numMax1,numMax2;
string cadena, cadenaNum1, cadenaNum2, cadenaNumUnico,cNumMax1,cNumMax2;

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

        if (float.TryParse(cadenaNum1, out num1) && float.TryParse(cadenaNum2, out num2))
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
    Console.WriteLine("Ingrese un numero unico\n");
    cadenaNumUnico = Console.ReadLine();
    if (float.TryParse(cadenaNumUnico, out numUnico))
    {
        Console.WriteLine($"Valor absoluto = {Math.Abs(numUnico)}\n");
        Console.WriteLine($"Numero al cuadrado = {Math.Pow(numUnico, 2)}\n");
        if (numUnico >= 0)
        {
            Console.WriteLine($"Raiz cuadrada = {Math.Sqrt(numUnico)}\n");
        }
        Console.WriteLine($"Seno = {Math.Sin(numUnico)}\n");
        Console.WriteLine($"Coseno = {Math.Cos(numUnico)}\n");
        Console.WriteLine($"Parte entera = {Math.Truncate(numUnico)}\n");
    }
    Console.WriteLine("primer numero\n");
    cNumMax1 = Console.ReadLine();
    Console.WriteLine("segundo numero\n");
    cNumMax2 = Console.ReadLine();
    if(float.TryParse(cNumMax1, out numMax1) && float.TryParse(cNumMax2, out numMax2))
    {
        Console.Write($"El numero maximo entre los dos ingresados es {Math.Max(numMax1, numMax2)}\n");
    }
    
    
    mostrarMenu();
    Console.WriteLine("Ingrese una opcion");
    cadena = Console.ReadLine();
    opcion = int.Parse(cadena);
}
Console.WriteLine("Saliendo...\n");
