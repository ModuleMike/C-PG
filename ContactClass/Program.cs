using ContactClass;

Contact c1 = new Contact();

c1.FirstName = "Joe";
c1.LastName = "Schmoe";
c1.Birthdate = new DateTime(1997, 2, 15);

Console.WriteLine($"{c1.NameLastFisrt} | Age: {c1.AgeYears}");

Contact c2 = new Contact()
{
    FirstName = "Sue",
    LastName = "Miller",
    Birthdate = new DateTime(1997, 6, 15)
};

Console.WriteLine($"{c2.NameLastFisrt} | Age: {c2.AgeYears}");