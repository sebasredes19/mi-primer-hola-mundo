// Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor de los números ingresados.



public class Ejercicio9
{

    static void Main(string[] args)
    {
        // ingresar datos
        Console.WriteLine("calcular el mayor numero de los 3");
        Console.WriteLine("Ingresa tres numeros");

        Console.Write("numero1: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("numero2: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("numero3: ");
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
