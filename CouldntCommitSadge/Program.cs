using CouldntCommitSadge;

SchoolClass kilencA = new()
{
    Evfolyam = "9. a",
    BefizetendoOsztalypenz = 7000
};
Console.WriteLine(kilencA);

SchoolClass kilencB = new()
{
    Evfolyam = "9.b",
    BefizetendoOsztalypenz = 6000
};

Console.WriteLine($"A {kilencB.Evfolyam} osztály által befizetett osztálypénz a teljes tanévben: {kilencB.TeljesTanevbenBefizetettOsztalypenz} Ft");