namespace Tests;

using System.Reflection;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    /*
- should create a class named `Ageable` that takes a `year` and has an `Age` method that calculates the age (current year - object's year)
- should inherit from `Ageable` in `Company` class and pass `YearEstablished` to `Agable` in the constructor
- should inherit from `Ageable` in `Person` class and pass `BirthYear` to `Agable` in the constructor
- should inherit from `Ageable` in `Car` class and pass `Year` to `Agable` in the constructor
    */

    [Fact]
    public void Should_Create_A_Class_Named_Ageable_That_Takes_A_Year_And_Has_An_Age_Method_That_Calculates_The_Age(){
       var ageable = new Ageable(2000);
       var expected = DateTime.Today.Year - 2000;
       Assert.Equal(expected, ageable.Age());
    }

    [Fact]
    public void Should_Inherit_From_Ageable_In_Company_Class_And_Pass_YearEstablished_To_Ageable_In_The_Constructor(){
       Ageable ageable = new Company("test", "testTaxId", 2000, 3.5M);
       var expected = DateTime.Today.Year - 2000;
       Assert.Equal(expected, ageable.Age());
    }

    [Fact]
    public void Should_Inherit_From_Ageable_In_Person_Class_And_Pass_BirthDate_To_Ageable_In_The_Constructor(){
       Ageable ageable = new Person("test", "testSsn", 2000, 20.0M);
       var expected = DateTime.Today.Year - 2000;
       Assert.Equal(expected, ageable.Age());
    }

    [Fact]
    public void Should_Inherit_From_Ageable_In_Car_Class_And_Pass_year_To_Ageable_In_The_Constructor(){
       Ageable ageable = new Car("Test", "testVin", 2000);
       var expected = DateTime.Today.Year - 2000;
       Assert.Equal(expected, ageable.Age());
    }
}