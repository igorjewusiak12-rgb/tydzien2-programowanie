Console.WriteLine("Imie: ");
string imie = Console.ReadLine();

Console.WriteLine("Max hp: ");
string wpisanytekst1 = Console.ReadLine();
int MaxHp = int.Parse(wpisanytekst1);

Console.WriteLine("Aktualne hp: ");
string wpisanytekst2 = Console.ReadLine();
int AktualneHp = int.Parse(wpisanytekst2);

Console.WriteLine("Podstawowe obrazenia broni: ");
string wpisanytekst3 = Console.ReadLine();
int PodstawaDmg = int.Parse(wpisanytekst3);

Console.WriteLine("Premia do sily: ");
string wpisanytekst4 = Console.ReadLine();
int PremiaSila = int.Parse(wpisanytekst4);

Console.WriteLine("Mnoznik ataku specjalnego: ");
string wpisanytekst5 = Console.ReadLine();
double MnoznikAtakSpecjalny = double.Parse(wpisanytekst5);

Console.WriteLine("Liczba wykonanych zwyklych atakow: ");
string wpisanytekst6 = Console.ReadLine();
int LiczbaWykonanychAtakow= int.Parse(wpisanytekst6);

int DmgJedenAtak = PodstawaDmg + PremiaSila;
double DmgAtakSpecjalny = PodstawaDmg * MnoznikAtakSpecjalny;
int DmgAtakSpecjalny2 = (int) DmgAtakSpecjalny;
int LaczneObrazenia = LiczbaWykonanychAtakow*DmgJedenAtak + 1*DmgAtakSpecjalny2;
double PozostaleZdrowie = MaxHp - AktualneHp;
bool zyje = AktualneHp>0;
bool maPelneZdrowie = AktualneHp != MaxHp;



Console.WriteLine("=== RAPORT ===");
Console.WriteLine($"Bohater: {imie}");
Console.WriteLine($"Zdrowie:{AktualneHp}/{MaxHp} ({AktualneHp},00%)");
Console.WriteLine($"Zwykly atak: {DmgJedenAtak}");
Console.WriteLine($"Atak specjalny: {DmgAtakSpecjalny2}");
Console.WriteLine($"Laczne zadane obrazenia: {LaczneObrazenia}");
Console.WriteLine($"Zyje: {zyje}");
Console.WriteLine($"Pelne zdrowie: {maPelneZdrowie}");
Console.WriteLine("==========");




