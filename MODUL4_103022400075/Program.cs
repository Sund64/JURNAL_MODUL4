// See https://aka.ms/new-console-template for more information
Console.WriteLine("Table Driven - Kode Paket:");

var pakets = new[]
{
    "Basic",
    "Standard",
    "Premium",
    "Unlimited",
    "Gaming",
    "Streaming",
    "Family",
    "Business",
    "Student",
    "Traveler"
};

foreach (var k in pakets)
{
    Console.WriteLine($"{k} => {KodePaket.getKodePaket(k)}");
}