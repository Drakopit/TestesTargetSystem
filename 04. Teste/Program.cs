double SP = 67836.43;
double RJ = 36678.66;
double MG = 29229.88;
double ES = 27165.48;
double Outros = 19849.53;

double Total = (SP + RJ + MG + ES + Outros);

double spRepresentation = (SP / Total) * 100;
double rjRepresentation = (RJ / Total) * 100;
double mgRepresentation = (MG / Total) * 100;
double esRepresentation = (ES / Total) * 100;
double outrosRepresentation = (Outros / Total) * 100;

Console.WriteLine($"Representation SP: {spRepresentation}");
Console.WriteLine($"Representation RJ: {rjRepresentation}");
Console.WriteLine($"Representation MG: {mgRepresentation}");
Console.WriteLine($"Representation ES: {esRepresentation}");
Console.WriteLine($"Representation Outros: {outrosRepresentation}");
