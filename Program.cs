using System;

namespace tp8_Punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
           
            string[] meses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

            int[] diasMeses = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.WriteLine("Ingrese el Numero de Mes del año: ");
            num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Eligio el Mes " + meses[num-1] + ", Tiene: " + diasMeses[num-1] + " Dias.");

            Console.WriteLine("Presione una tecla para terminar...");
            Console.ReadKey();
        }
    }
}
