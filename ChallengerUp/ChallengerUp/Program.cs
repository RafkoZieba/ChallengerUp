string gender = null;
string message = null;

Console.WriteLine("Kim jesteś? Podaj swoje imię do wyboru Adam, Ala, Ela");
var name = Console.ReadLine();

Console.WriteLine(name + " podaj swój wiek");
var age = int.Parse(Console.ReadLine());

if (name == "Ela" || name == "Ala")
{
    Console.WriteLine(name + " sądzę że jesteś kobietą. Czy tak? T/N");
    string isWoman = Console.ReadLine();

    if (isWoman.ToUpper() == "T")
    {
        gender = "Kobieta";
    }
    else
    {
        gender = "Mężczyzna";
        Console.WriteLine("Ups, czyli jesteś mężczyzną.");
    }
}

if (name == "Adam")
{
    Console.WriteLine(name + " sądzę że jesteś meżczyzną. Czy tak? T/N");
    var isMan = Console.ReadLine();
    if (isMan.ToUpper() == "T")
    {
        gender = "Mężczyzna";
    }
    else
    {
        gender = "Kobieta";
        Console.WriteLine("Ups, czyli jesteś kobietą.");
    }
}

if (gender == "Kobieta")
{
    if (age < 30)
    {
        message = gender + " poniżej 30 lat";
    }
    else
    {
        message = name + ", lat " + age;
    }
}
else if (gender == "Mężczyzna")
{
    if (age < 18)
    {
        message = "Niepełnoletni " + gender.ToLower();
    }
}

Console.WriteLine(message);
Console.ReadKey();
