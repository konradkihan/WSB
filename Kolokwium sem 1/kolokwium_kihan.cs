/*
 * IMIĘ I NAZWISKO: KONRAD KIHAN 
 * NR ALBUMU: 70495
 * GRUPA: INiN1 A2.1
 * /


// ZADANIE DLA KOŃCÓWEK 8,5
/*
Poproś użytkownika o podanie liczby całkowitej bezznakowej N. Następnie utwórz Unicode-Art w postaci kratki o wymiarach M na M, gdzie M = 3*N+2, złożonej ze spacji oraz znaków |, - i +; 
N oznacza ilość wierszy/znaków pomiędzy skrzyżowaniami, czyli znakami +

0:
	++
	++
1:
	 | | 
	-+-+-
	 | | 
	-+-+-
	 | | 
2:
	  |  |  
	  |  |  
	--+--+--
	  |  |  
	  |  |  
	--+--+--
	  |  |  
	  |  |  
itd.
*/
void zadanie(int N)
{
	for (int i = 0; i < 3*N+2; i++)
    {
		if(i == N || i== 2 * N + 1)
        {
	
			Console.WriteLine(String.Concat(Enumerable.Repeat("-", N)) + "+" + String.Concat(Enumerable.Repeat("-", N)) + "+" + String.Concat(Enumerable.Repeat("-", N)));

		}
        else
        {
			Console.WriteLine(String.Concat(Enumerable.Repeat(" ", N)) + "|" + String.Concat(Enumerable.Repeat(" ", N)) + "|");
		}
	}

}

int N;
Console.WriteLine("Podaj rozmiar kratki:");
try
{
	N = int.Parse(Console.ReadLine());
	zadanie(N);
}
catch (FormatException)
{
	Console.WriteLine("Format error");
	return;
}
catch (OverflowException)
{
	Console.WriteLine($"Overflow error - spróbuj podać liczbę {int.MinValue} <= N <= {int.MaxValue}");
	return;
}

// automatyczny test

/*
int proby = 30;
for (int i = 0; i < proby; i++)
	zadanie(i);
*/

