Console.Write("Podaj liczbe racji: ");
string WpisanyTekst1 = Console.ReadLine();
int racje = int.Parse(WpisanyTekst1);

Console.Write("Liczba czlonkow druzyny: ");
string WpisanyTekst2 = Console.ReadLine();
int druzyna = int.Parse(WpisanyTekst2);

Console.Write("Liczba dni wyprawy: ");
string WpisanyTekst3 = Console.ReadLine();
int dni = int.Parse(WpisanyTekst3);


Console.WriteLine("Liczba racji jaka otrzyma kazdy czlonek druzyny: ");
int podzial = racje/druzyna;
int reszta1 = racje%druzyna;
Console.WriteLine($"{podzial} reszta: {reszta1}");

Console.WriteLine("Liczba racji dziennie na cala druzyne: ");
double racjadzien = (double)racje/dni;
Console.WriteLine($"{racjadzien}");


Console.WriteLine("Liczba racji dziennie na jedna osobe: ");
double racjadzienosoba = (double)racje/druzyna;
Console.WriteLine($"{racjadzien}");