int PDoswiadczenia = 40;
int zloto = 30;
int trening = 1;

Console.WriteLine($"Lvl: {PDoswiadczenia}");
Console.WriteLine($"Zloto: {zloto}");
Console.WriteLine($"Trening: {trening}");


PDoswiadczenia += 25;
Console.WriteLine($"Lvl po dodaniu:{PDoswiadczenia}");

PDoswiadczenia = PDoswiadczenia*2;
Console.WriteLine($"Lvl po podwojeniu: {PDoswiadczenia}");

zloto -= 8;
Console.WriteLine($"Zloto po odjeciu: {zloto}");

zloto += 15;
Console.WriteLine($"Zloto po dodaniu: {zloto}");

trening++;
Console.WriteLine($"Trening: {trening}");

