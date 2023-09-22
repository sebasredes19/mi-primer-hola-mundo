//Escribir un programa que convierta un valor dado en grados Fahrenheit a grados Celsius


public class ejercicio6

{
    static void Main(String[] args)
    {
        

        Console.WriteLine("Conversor de grados Fahrenheit a grados Celsius");
        Console.Write("Ingresa la temperatura en grados Fahrenheit: ");

        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine($"La temperatura en grados Celsius es: {celsius:F2}");
    }


}
