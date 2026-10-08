Console.WriteLine("Podaj ilosc hp: ");
string wpisanytekst1 = Console.ReadLine();
int PunktyZycia = int.Parse(wpisanytekst1);

Console.WriteLine("Podaj liczbe mikstur: ");
string wpisanytekst2 = Console.ReadLine();
int Mikstury = int.Parse(wpisanytekst2);

Console.WriteLine("Czy posiada klucz: ");
string wpisanytekst3 = Console.ReadLine();
bool Klucz = bool.Parse(wpisanytekst3);

Console.WriteLine("Czy posiada mape: ");
string wpisanytekst4 = Console.ReadLine();
bool Mapa = bool.Parse(wpisanytekst4);

bool zyje = PunktyZycia > 0;
bool maPelneZdrowie = PunktyZycia == 100;
bool wymagaLeczenia = !maPelneZdrowie;
bool maZaopatrzenie = Mikstury>0;
bool maPrzedmiotNawigacyjny = Klucz || Mapa;
bool gotowyDoWyprawy = zyje && maZaopatrzenie && maPrzedmiotNawigacyjny;


Console.WriteLine($"Zyje: {zyje}");
Console.WriteLine($"Ma pelne zdrowie: {maPelneZdrowie}");
Console.WriteLine($"Wymaga leczenia: {wymagaLeczenia}");
Console.WriteLine($"Ma zaopatrzenie: {maZaopatrzenie}");
Console.WriteLine($"Ma klucz lub mape: {maPrzedmiotNawigacyjny}");
Console.WriteLine($"Gotowy: {gotowyDoWyprawy}");

