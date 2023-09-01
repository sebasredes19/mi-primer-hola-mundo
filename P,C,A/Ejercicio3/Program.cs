//Realizar un algoritmo con C# donde me permita calcular el perímetro/circunferencia y área de las siguientes
//figuras geométricas:
//cuadrado, rectángulo, triángulo y círculo.
//Mostrar en pantalla los valores calculados por cada figura geométrica.



public class Ejercicio4

{

    static void Main(string[] args)
    {
        double ladoCuadrado, baseRectangulo, alturaRectangulo, lado1, lado2, lado3, alturaTriangulo, radio;
        Console.Write("Ingrese lado del cuadrado");
        ladoCuadrado = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese base del rectangulo");
        baseRectangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese altura del rectangulo");
        alturaRectangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese lado 1 del triangulo");
        lado1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese lado 2 del triangulo");
        lado2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese lado 3 del triangulo");
        lado3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del triangulo");
        alturaTriangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el radio del circilo");
        radio = double.Parse(Console.ReadLine());

        double perimetroCuadrado = ladoCuadrado * 4;
        double areaCuadrado = 2 * ladoCuadrado;
        double perimetroRectangulo = 2 * baseRectangulo +  2 * alturaRectangulo;
        double areaRectangulo = baseRectangulo * alturaRectangulo;
        double areaTriangulo = (lado1 * alturaTriangulo) / 2;
        double perimetroTriangulo = lado1 + lado2 + lado3;
        double perimetroCirculo = 2 * Math.PI * radio;
        double areaCirculo = Math.PI * Math.Pow (radio, 2);


        Console.WriteLine($"El area del cuadrado es: {areaCuadrado}");
        Console.WriteLine($"El perimetro del cuadrado es: {perimetroCuadrado}");

        Console.WriteLine($"El area del rectangulo es: {areaRectangulo}");
        Console.WriteLine($"El perimetro del rectangulo es: {perimetroRectangulo}");

        Console.WriteLine($"El area del triangulo es: {areaTriangulo}");
        Console.WriteLine($"El perimetro del triangulo es: {perimetroTriangulo}");

        Console.WriteLine($"El area del circulo es: {areaCirculo}");
        Console.WriteLine($"El perimetro del circulo es: {perimetroCirculo}");

    }
}


