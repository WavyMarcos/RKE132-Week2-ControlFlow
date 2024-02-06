// See https://aka.ms/new-console-template for more information

// Rakendus küsib kasutaja sugu (m/f) ja perekonnanime
// Lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
// "Welcome, Mr. [kasutaja perekonnanimi]" / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");
char userGender = Char.Parse(Console.ReadLine()); // Loeb konsoolist maha andmeid sõne formaadis
Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}