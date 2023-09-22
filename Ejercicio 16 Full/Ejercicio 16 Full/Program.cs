 

    public class Ejercicio16
    {

        static void Main(string[] args)

        {
            DateTime fechaActual = DateTime.Now;
            Random tasaMes = new Random();

            //declaracion de varibles
            decimal rendimientoMes,bonoMes = 0, ahorroMes, rendimientoAnual = 0,
                   bonoAnual = 0, ahorroAnual = 0, sumaTotalNeta = 0;
            double interesMes;
            bool continuar = true;
            int  mes, contadorWhile  = -1;
            string respuesta;

            const double TASA_MAX =  1.5;

       
            while(continuar) 
            {
                Console.Clear(); //borra pantalla
                contadorWhile++;
                Console.WriteLine($"------NATILLERA NAVIDEÑA AÑO {fechaActual.Year + contadorWhile}-----\n");


                for (mes = 1; mes <= 12; mes++)
                {
                    Console.WriteLine($"Ingrese la cantidad que desea ahorrar en el mes {mes}: ");
                    ahorroMes = Convert.ToDecimal(Console.ReadLine());

                    interesMes = tasaMes.Next(10, 501) / 100.0;
                    rendimientoMes = (ahorroMes * (decimal)interesMes) / 100;

                    if (interesMes < TASA_MAX)
                    {
                        bonoMes = (2 * ahorroMes) / 5;
                        bonoAnual += bonoMes; // bonoAnual = bonoAnual + bonoMes;
                    }

                    ahorroAnual += ahorroMes;
                    rendimientoAnual += rendimientoMes;

                    sumaTotalNeta = ahorroAnual + rendimientoAnual + bonoAnual;

                    //mostrar la informacion de la natilera;
                    Console.WriteLine($"Tasa de interes del mes {mes}: {interesMes}%");
                    Console.WriteLine($"Rendimiento del mes {mes}: {rendimientoMes:C2}");
                    if (bonoMes > 0) Console.WriteLine($"Bono del mes {mes}: {bonoMes:C2}");
                    Console.WriteLine($"Total ahorrado en el mes {mes}: {ahorroAnual:C2}");
                    Console.WriteLine($"Total de rendimiento hasta el mes {mes}: {rendimientoAnual:C2}");
                    Console.WriteLine($"Suma total neta hasta el {mes}: {sumaTotalNeta:C2}\n");

                }

                Console.WriteLine(String.Format("Resumen total Natillera navideña del año {0}", fechaActual.Year));
                Console.WriteLine($"Total ahorrado en el año: {ahorroAnual:C2}");
                Console.WriteLine($"Total rendimiendos en el año: {rendimientoAnual:C2}");
                if (bonoAnual > 0) Console.WriteLine($"Total bono en el año {bonoAnual:C2}");
                Console.WriteLine($"TOTAL NETO DEL AÑO: {sumaTotalNeta:C2}\n");

                Console.WriteLine(String.Format("¿Desea continuar en la natillera navideña " +
                    "para el año {0}? (s/n)", fechaActual.Year + 1));
                 respuesta = Console.ReadLine();

                if (respuesta != "s") continuar = false;
            }

      
        }

    }
 