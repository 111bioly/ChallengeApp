var myName = "Ewa";
string mySex = "kobieta";
string mySexM = "mężczyzna";
var myAge = 33;
var myAge2 = 17;
if (myName == "Ewa" && mySex == "kobieta" && myAge == 33)
{
    Console.WriteLine("Mam na imie Ewa mam 33 lat");
}
else if (mySex == "kobieta" && myAge < 30)
{
    Console.WriteLine("jestm kobietą poniżej 30 lat");
}
else if (mySexM == "mężczyzna" && myAge2 < 18)
{
    Console.WriteLine("jestem niepełnoletni");
}