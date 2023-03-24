string stringTeste = "Patrick";

string newString = "";
for (int i = stringTeste.Length - 1; i >= 0; i--)
{
    newString += stringTeste[i];
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine($"String: {newString}");
