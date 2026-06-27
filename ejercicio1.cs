public class Ejercicio1
{
    public void mostrarEjercicio1()
    {
        int num, digito, numeroFinal=0;
        string cadena;
    Console.WriteLine("Ingrese el numero que desea invertir");
    cadena = Console.ReadLine();
    if (int.TryParse(cadena, out num))
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
        }
}





