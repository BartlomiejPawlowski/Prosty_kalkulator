using System;

namespace peirwszy_program
{
    /// <summary>
    /// Główna kalsa programu
    /// </summary>
    /// 

    public class Program
    {
        private static int silnia(int i)
        {
            if (i <= 1)
            {
                return 1;
            }
            else
            {
                return i * silnia(i - 1);
            }

        }
        private static int dodawanie(int i)
        {
            while (Console.ReadKey().Key == ConsoleKey.Y)
            {

                Console.WriteLine();
                Console.WriteLine("Podaj kolejną liczbę: ");

                int d = int.Parse(Console.ReadLine());

                i = i + d;

                Console.WriteLine("Czy chcesz dodać jeszcze jedną liczbę? y/n");

            }
            Console.WriteLine();
            return i;
        }

        private static int odejmowanie(int i)
        {
            while (Console.ReadKey().Key == ConsoleKey.Y)
            {

                Console.WriteLine();
                Console.WriteLine("Podaj kolejną liczbę: ");

                int d = int.Parse(Console.ReadLine());

                i = i - d;

                Console.WriteLine("Czy chcesz dodać jeszcze jedną liczbę? y/n");

            }
            Console.WriteLine();
            return i;
        }
        private static int mnozenie(int i)
        {
            while (Console.ReadKey().Key == ConsoleKey.Y)
            {

                Console.WriteLine();
                Console.WriteLine("Podaj kolejną liczbę: ");

                int d = int.Parse(Console.ReadLine());

                i = i * d;

                Console.WriteLine("Czy chcesz dodać jeszcze jedną liczbę? y/n");

            }
            Console.WriteLine();
            return i;
        }
        private static float dzielenie(float i)
        {
            while (Console.ReadKey().Key == ConsoleKey.Y)
            {

                Console.WriteLine();
                Console.WriteLine("Podaj kolejną liczbę: ");

                int d = int.Parse(Console.ReadLine());

                i = i / d;

                Console.WriteLine("Czy chcesz dodać jeszcze jedną liczbę? y/n");

            }
            Console.WriteLine();
            return i;
        }
        /// <remarks>
        /// Metoda startowa aplikacji
        /// </remarks>
        public static void Main()
        {

            int a, b, c;
            float g;


            Console.WriteLine("To jest kalkulator. Wybierz rodzaj działania: ");
            Console.WriteLine("1. Dodawanie," +
                                "2. Odejmowanie," +
                                "3. Mnożenie," +
                                "4. Dzielenie," +
                                "5. Silnia");
            int działanie = int.Parse(Console.ReadLine());

            if (działanie == 1)
            {
                Console.WriteLine("Podaj pierwsza liczbę: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę: ");
                b = int.Parse(Console.ReadLine());
                c = a + b;
                Console.WriteLine("Czy chcesz dodać jeszcze jedną liczbę? y/n");

                
                Console.WriteLine("Wynik to: " + dodawanie(c));
                Console.WriteLine();
            }

            else if (działanie == 2)
            {
                {
                    Console.WriteLine("Podaj pierwsza liczbę: ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj drugą liczbę: ");
                    b = int.Parse(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("Czy chcesz dodać jeszcze jedną liczbę? y/n");


                    Console.WriteLine("Wynik to: " + odejmowanie(c));
                    Console.WriteLine();
                }
            }

            else if (działanie == 3)
            {
                {
                    Console.WriteLine("Podaj pierwsza liczbę: ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj drugą liczbę: ");
                    b = int.Parse(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Czy chcesz dodać jeszcze jedną liczbę? y/n");


                    Console.WriteLine("Wynik to: " + mnozenie(c));
                    Console.WriteLine();
                }
            }
            else if (działanie == 4)
            {
                {
                    Console.WriteLine("Podaj pierwsza liczbę: ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj drugą liczbę: ");
                    b = int.Parse(Console.ReadLine());
                    g = a / b;
                    Console.WriteLine("Czy chcesz dodać jeszcze jedną liczbę? y/n");

                    Console.WriteLine("Wynik to: " + dzielenie(g));
                    Console.WriteLine();
                }
            }

            else if (działanie == 5)
            {
                Console.Write("Podaj Liczbę: ");
                int liczba = int.Parse(Console.ReadLine());

                Console.WriteLine("Silnia wynosi: " + silnia(liczba));

            }
            else
            {
                Console.ReadKey();
            }

        }
    }
}


