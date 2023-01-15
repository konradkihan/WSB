using System;

public class Zadania_zajecia
{
 // Ćwiczenia

    // 0
    /*
     Poproś użytkownika o podanie imienia i osobno o podanie nazwiska i zachowaj te dane w zmiennych typu string
    Następnie wypisz komunikat "Witaj {imię} {nazwisko}."
     */
    public static void zad1()
    {
        Console.WriteLine("Imie: ");
        string name = Console.ReadLine();
        Console.WriteLine("Naziwsko: ");
        string surname = Console.ReadLine();
        Console.WriteLine($"Witaj {name} {surname}");
    }
    // 1
    /*
     Poproś użytkownika o podanie liczby całkowitej (Int32 / int) - informując go z góry o dozwolonym zakresie.
    W wypadku podania zbyt dużej/małej liczby lub niepoprawnego formatu wypisz w konsoli informację o tym
    W przeciwnym wypadku wypisz liczbę o 1 mniejszą
     */
    public static void zad2()
    {
        Console.WriteLine($"Podaj liczbe w zakresie od {int.MinValue} do {int.MaxValue}");
        int num;
        try
        {
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(num - 1);
        }
        catch (OverflowException)
        {
            Console.WriteLine("B... Baka! It does not fit senpai OwO");
            return;
        }
        catch (FormatException)
        {
            Console.WriteLine("S... Senpai what are you putting in?!?!");
            return;
        }
    }
    // 2
    /*
     Poproś użytkownika o podanie dwóch liczb całkowitych (Int16 / short) - informując go z góry o dozwolonym zakresie.
    Można zweryfikować poprawność jak w 1
    Zapisz iloczyn tych liczb w zmiennej (dobrać odpowiedni typ) i wypisz wynik
     */
    public static void zad3()
    {
        Console.WriteLine($"Podaj liczbe w zakresie od {short.MinValue} do {short.MaxValue}");
        try
        {
            short num1, num2;
            int wynik;
            num1 = short.Parse(Console.ReadLine());
            num2 = short.Parse(Console.ReadLine());
            wynik = num1 * num2;
            Console.WriteLine(wynik);
        }
        catch (OverflowException)
        {
            Console.WriteLine("B... Baka! It does not fit senpai OwO");
            return;
        }
        catch (FormatException)
        {
            Console.WriteLine("S... Senpai what are you putting in?!?!");
            return;
        }
    }
    // 3
    // a)
    /*
     Napisać program w którym zdeklarujemy 3 zmienne:
        - dzielna i dzielnik typu całkowitego (np wartości 2, 3)
        - iloraz typu zmiennoprzecinkowego
     Wykonać dzielenie zmiennoprzecinkowe, przypisać wartość do zmiennej iloraz oraz wypisać w konsoli formatkę
     {dzielna} / {dzielnik} = {iloraz}
     */
    public static void zad3a()
    {
        int dzielna, dzielnik;
        Console.WriteLine("Zapisz dwie liczby oddzielajac je enterem");
        dzielna = int.Parse(Console.ReadLine());
        dzielnik = int.Parse(Console.ReadLine());
        float iloraz;
        iloraz = dzielna / dzielnik;
        Console.WriteLine(iloraz);
    }
    // b)
    /*
     Do zadania dodać wczytywanie od użytkownika danych dla zmiennych dzielna i dzielnik
     */
    // c)
    /*
     W trakcie konwersji danych wczytywanych do zmiennych poinformować użytkownika o błędnych danych - 
    przechywtując wyjątek lub stosując konwersję przez TryParse
     */

    // 4
    // a)
    /*
     Napisać program w którym zdeklarujemy 4 zmienne:
        - dzielna i dzielnik typu całkowitego (np wartości 12, 5)
        - iloraz i reszta - również typu całkowitego
     Wykonać dzielenie całkowite i modulo, przypisać wartości do zmiennych (odpowiednio) iloraz i reszta
     oraz wypisać w konsoli formatkę
     {dzielna} / {dzielnik} = {iloraz} reszty {reszta}
     */

    // b)
    /*
     dodać wczytywanie danych od użytkownika
     */

    // c)
    /*
     Jak w a), tylko wykonać korektę, aby wyniki były zgodne z polską konwencją, to jest:
        - iloraz zawsze zaokrąglany w dół, a nie w stronę zera
        - reszty zawsze dodatnie
     Sprawdzić dla dzielnej i dzielnika np -12 / 5
     */

    // 5
    /*
     Poproś użytkownika o podanie współczynników a i b dla prostej ax+b (a = współczynnikKierunkowy, b = wyrazWolny)
    Zmienne mają być typu Int32
    Stwierdzić ile miejsc zerowych ma funkcja liniowa o tym wzorze
     */

    // 6
    /*
     Poproś użytkownika o podanie współczynników a i b dla prostej ax+b (a = współczynnikKierunkowy, b = wyrazWolny)
    Zmienne mają być typu double
    Stwierdzić ile jest miejsc zerowych i w wypadku dokładnie jednego podać jego wartość
     */

    // 7
    // Poproś użytkownika o podanie współczynników a, b i c dla paraboli ax^2 + bx +c, oraz:
    // a)
    /*
    Sprawdź, czy faktycznie mamy do czynienia z parabolą, czyli dla a = 0 stwierdzić, że to funkcja liniowa
    Oblicz deltę i wypisz jej wartość
     */

    // b)
    /*
    Sprawdź, czy faktycznie mamy do czynienia z parabolą, czyli dla a = 0 stwierdzić, że to funkcja liniowa
    Oblicz deltę i na jej podstawie stwierdź ilość miejsc zerowych paraboli
     */

    // c)
    /*
    Sprawdź, czy faktycznie mamy do czynienia z parabolą, czyli dla a = 0 stwierdzić, że to funkcja liniowa
    Obliczyć deltę, na jej podstawie stwierdzić ilość miejsc zerowych paraboli
    Jeśli są miejsca zerowe to podaj ich wartości
     */

    // d)
    /*
     Poproś użytkownika o podanie współczynników a, b i c dla paraboli ax^2 + bx +c
    Na podstawie współczynników a,b,c oraz delty stwierdzić
    - czy to faktycznie funkcja kwadratowa czy liniowa
    - ile ma miejsc zerowych
     */
}
