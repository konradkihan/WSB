using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSB_programowanie
{
    class tablice
    {
        public static void tablice_1(){
            // jednowymiarowa tablica intów długości 3
            int[] tablica_intow = new int[3];
            tablica_intow[0] = 10;
            tablica_intow[1] = 20;
            tablica_intow[2] = 30;

            Console.WriteLine($"{tablica_intow[0]}, {tablica_intow[1]}, {tablica_intow[2]}");
        }
        public static void tablice_petle()
        {
            int[] tablica_intow = new int[3];
            tablica_intow[0] = 10;
            tablica_intow[1] = 20;
            tablica_intow[2] = 30;
            tablica_intow[3] = 40;

            for (int i=0; i<tablica_intow.Length; i++)
            {
                Console.WriteLine($"{i} = {tablica_intow[i]}");
            }

            // tworzenie tablicy o długości określonej zmienną
            int[] tablica2 = new int[Convert.ToByte(Console.ReadLine())];
            // dodawanie elementów do tablicy
            for(int i =0; i < tablica_intow.Length; i++)
            {
                tablica_intow[i] = i * 23;
            }
        }

        public static void tablice_str()
        {
            string[] tablica = { "Adam", "Beata", "Cyprian", "Danuta" };

            for(int i=0; i<tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }

            foreach(string elem in tablica)
            {
                Console.WriteLine(elem);
            }

            int[] tabInt = { 1, 2, 3, 4, 5 };
            int[] tabInt2 = tabInt; // nie kopiowanie tablicy, lecz kopiowanie referencji !!!

            for (int i = 0; i < tabInt2.Length; i++)
                tabInt2[i]++;

            for (int i = 0; i < tabInt2.Length; i++)
                Console.WriteLine($"{i} -- {tabInt[i]} - {tabInt[i]}"); 
            /* wypisane są te same wartości bo zmienne tablicowe to nie są typy proste, sama zmienna nie jest informacją o adresie
            w pamięci, a jedynie deklaracją o początku tablicy - referencja - adres struktury 
            typy referencyjne nie są kopiowane, ale kopiują jedynie referencje*/

        }

        public static void kopiowanie_typow_ref()
        {
            // właściwe kopiowanie tablic tego samego typu
            int[] oryginal = { 1, 2, 3, 4, 5 };
            int[] kopia = (int[])oryginal.Clone();

            for (int i = 0; i < oryginal.Length; i++)
                Console.WriteLine($"{i} -- {oryginal[i]} - {kopia[i]}");
        }

        public static void ostatni_wyraz()
        {
            string[] wyrazy = new string[1];
            do
            {
                wyrazy[^1] = Console.ReadLine(); // [^1] -- OSTANTNI WYRAZ
            } while (wyrazy[^2].Trim().ToLower != "koniec");
        }


    }
}
