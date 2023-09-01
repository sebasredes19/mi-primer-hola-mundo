// Construir un programa que pida un número y luego diga si este número es par o no




public class Ejercicio7
{

    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int numero = Convert.ToInt16(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine($"El número {numero} es par.");
        }
        else
        {
            Console.WriteLine($"El número {numero} es impar.");
        }

    }
}