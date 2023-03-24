using _03._Teste;
using Newtonsoft.Json;

string directory = Directory.GetCurrentDirectory();

string filePath = @"D:\Teste\03. Teste\Arquivos\dados.json";

// Read the entire contents of the file into a string
string fileContents = File.ReadAllText(filePath);

List<Billing> billings = JsonConvert.DeserializeObject<List<Billing>>(fileContents);

double lowestValue = billings.Min(v => v.valor);
double biggestValue = billings.Max(v => v.valor);
double averageValue = billings.Select(v => v.valor).Where(v => v != 0).DefaultIfEmpty(0).Average();

int count = billings.Select(v => v.valor).Count(v => v < averageValue);

Console.WriteLine($"Lowest: {lowestValue}");
Console.WriteLine($"Biggest: {biggestValue}");
Console.WriteLine($"Average: {averageValue}");
Console.WriteLine($"Days wich value lowest than average: {count}");