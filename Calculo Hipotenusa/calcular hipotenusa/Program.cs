//Dados los catetos de un triángulo rectángulo, calcular su hipotenusa

public class Ejercicio5
{
    static void Main(string[] args)
    {
        double cateto1, cateto2;
        Console.WriteLine("Ingrese cateto o lado 1 ");
        cateto1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese cateto o lado 2 ");
        cateto2 = double.Parse(Console.ReadLine());
     
        double hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
        Console.WriteLine($" La hipotenusa del triangulo rectangulo es: {hipotenusa}");




    }


}