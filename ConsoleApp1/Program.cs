void kratki()
{
	Console.Write("Podaj wymiar: ");
	int rozmiar = int.Parse(Console.ReadLine());
	int rozmiar_calkowity = 3 * rozmiar + 2;

	for (int i = 0; i < rozmiar_calkowity; i++)
	{
		string linijka;
		if (i == rozmiar || i == 2 * rozmiar + 1)
		{
			linijka = String.Concat(Enumerable.Repeat("-", rozmiar)) + "+" + String.Concat(Enumerable.Repeat("-", rozmiar)) + "+" + String.Concat(Enumerable.Repeat("-", rozmiar));
		}
		else
		{
			linijka = String.Concat(Enumerable.Repeat(" ", rozmiar)) + "|" + String.Concat(Enumerable.Repeat(" ", rozmiar)) + "|";
		}
		Console.WriteLine(linijka);
	}
}

int proby = 30;
for (int i = 0; i < proby; i++)
	kratki();