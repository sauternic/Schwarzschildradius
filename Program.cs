using System;

namespace Schwarzschildradius
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double R;//Radius
                double c = 299792458;//Lichtgeschwindigkeit
                double G = 6.67428e-11;//Gravitations-Konstante Genauster Wert nach Markus: 6.6725985e-11
                double M;//Masse

                Console.WriteLine("\n\tCopyright \u00A9 2009 Nicolas Sauter");
                Console.Write("\n\tTaste <0> zum Beenden");
                Console.Write("\n\n  Bitte Masse in Kg Eingeben: ");


                try
                {
                    //Eingabe-Fehler werden sofort Abgefangen!!!
                    M = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception) { Console.WriteLine("\n\n\t\tFehler!\n\n"); continue; }

                if (M == 0)
                    Environment.Exit(0);

                R = (2 * G * M) / Math.Pow(c, 2);

                Console.WriteLine("\n  Der Schwarzschild-Radius beträgt:\n");
                Console.WriteLine("  {0} Km", R * 1.0e-3);
                Console.WriteLine("  {0} Meter", R);
                Console.WriteLine("  {0} mm", R * 1.0e3);
                Console.WriteLine("  {0} Mikro-Meter(-6)", R * 1.0e6);
                Console.WriteLine("  {0} Nano-Meter(-9)", R * 1.0e9);
                Console.WriteLine("  {0} Piko-Meter(-12)", R * 1.0e12);
                Console.WriteLine("  {0} Femto-Meter(-15)", R * 1.0e15);
                Console.WriteLine("  {0} Atto-Meter(-18)", R * 1.0e18);
            }


        }
    }
}
