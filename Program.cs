using System;

namespace upn_T1_q_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Double km, milla;
            Console.WriteLine("Conversión de millas a kilómetros");
            Console.Write("Ingrese cantidad de millas: ");
            milla = Convert.ToDouble(Console.ReadLine());
            km = milla * 1.609;
            Console.WriteLine("El valor en kilómetros es: " + Convert.ToString(km) + " Kilómetros");
        }
    }
}
