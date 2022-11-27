using System;

namespace WSB_programowanie
{
    class Instrukcje
    {
        public static void HelloWorld()
        {
            Console.WriteLine("Podaj imię:");
            string name = Console.ReadLine();
            Console.WriteLine($"Witaj {name}");

        }
    }

    class Konwertowanie
    {
        public static void parsowanie()
        {
            int liczba;
            Console.WriteLine("Podaj liczbe:");
            try
            {
                liczba = int.Parse(Console.ReadLine());
                Console.WriteLine(liczba + 10);
            }
            catch (OverflowException)
            {
                Console.WriteLine("AAAAAAAAAAAAAAAAAA");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Zepsuło się na amen");
                return;
            }
        }
        
        public static void klasa_convert()
        {
            try
            {
                int liczba;
                Console.WriteLine("Podaj liczbę");
                liczba = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(liczba + 69);
            }
            catch (OverflowException)
            {
                Console.WriteLine("P A I N");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Y e E E t");
                return;
            }
        }

        public static void TryParseMetoda()
        {
            int liczba;
            Console.WriteLine("Podaj liczbę");
            if(  
                int.TryParse(
                    Console.ReadLine(),
                    out liczba
                    )
            )
            {
                Console.WriteLine(liczba + 101);
            }
            else
            {
                Console.WriteLine("DORIME");
            }
        }

        public static void Rzutowanie()
        {
            int liczba_ujemna = -1;
            uint liczbaDodatnia = (uint) liczba_ujemna; // niebezpieczna konwersja - potencjalna strata informacji+

            Console.WriteLine(liczbaDodatnia);
        }
    }

    class Arytmetyka
    {
        public static void DzielnikiCalkowite()
        {
            int dzielna, dzielnik, iloraz;
            dzielna = 12;
            dzielnik = 5;
            iloraz = dzielna / dzielnik;
            Console.WriteLine($"{iloraz}, {dzielna % dzielnik}");
        }
        
        public static void FunkcjeMat()
        {
            Console.WriteLine(Math.Sqrt(2));
            Console.WriteLine(Math.Pow(2, 9));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Arytmetyka.FunkcjeMat();
            Console.ReadKey();
        }
    }
}

//https://sites.google.com/view/pmb-laboratoria/programowanie-komputer%C3%B3w