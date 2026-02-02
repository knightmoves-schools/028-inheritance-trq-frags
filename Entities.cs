namespace knightmoves;
public class Company{
    private string Name;
    private string Id;
    private int Year;
    private decimal TaxRate;

    public Company(string name, string taxId, int yearEstablished, decimal taxRate){
        Name = name;
        Id = taxId;
        Year = yearEstablished;
        TaxRate = taxRate;
    }
}

public class Person{
    private string Name;
    private string Id;
    private int Year;
    private decimal TaxRate;

    public Person(string name, string ssn, int birthYear, decimal taxRate){
        Name = name;
        Id = ssn;
        Year = birthYear;
        TaxRate = taxRate;
    }
}

public class Car{
    private string Name;
    private string Id;
    private int Year;

    public Car(string model, string vin, int year){
        Name = model;
        Id = vin;
        Year = year;
    }
}
