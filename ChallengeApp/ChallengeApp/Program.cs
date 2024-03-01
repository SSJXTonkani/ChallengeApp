using System.ComponentModel.Design;
using System.Security.Cryptography;

var name = "Antonina";
var sex = "male";
var age = 9;


if (sex == "female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex == "male" && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Wartość Nieprawidłowa");
}


