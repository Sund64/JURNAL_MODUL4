// See https://aka.ms/new-console-template for more information
using static MesinKopi;

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

MesinKopi mesin = new MesinKopi(); 
mesin.activateTrigger(Trigger.POWER_ON);
mesin.activateTrigger(Trigger.POWER_OFF);
mesin.activateTrigger(Trigger.START_BREW);
mesin.activateTrigger(Trigger.FINISH_BREW);
mesin.activateTrigger(Trigger.START_MAINTENANCE);
mesin.activateTrigger(Trigger.FINISH_MAINTENANCE);
