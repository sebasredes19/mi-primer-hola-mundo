//Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor,
//el del medio y el menor de los números ingresados


public class Ejercicio10
{

    static void Main(string[] args)
    
    {

        Console.WriteLine("Ingrese tres números:");

        // Solicitar al usuario ingresar los tres números
        Console.Write("Número 1: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Número 2: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Número 3: ");
        double numero3 = Convert.ToDouble(Console.ReadLine());

        // Encontrar el mayor número
        double mayor = Math.Max(numero1, Math.Max(numero2, numero3));

        // Encontrar el menor número
        double menor = Math.Min(numero1, Math.Min(numero2, numero3));

        // Encontrar el número del medio
        double medio = (numero1 + numero2 + numero3) - (mayor + menor);

        // Mostrar los resultados
        Console.WriteLine($"El mayor número ingresado es: {mayor}");
        Console.WriteLine($"El número del medio ingresado es: {medio}");
        Console.WriteLine($"El menor número ingresado es: {menor}");

    }

}