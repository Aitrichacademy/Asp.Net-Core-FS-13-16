
using System;

abstract class Appliance
{
    protected string brand;

    public Appliance(string brand)
    {
        this.brand = brand;
    }

    public abstract void ShowFunction();
}

class WashingMachine : Appliance
{
    public WashingMachine(string brand) : base(brand) { }

    public override void ShowFunction()
    {
        Console.WriteLine(brand + " Washing Machine: Cleans clothes.");
    }
}

class Program4
{
    static void Main()
    {
        WashingMachine wm = new WashingMachine("Samsung");
        wm.ShowFunction();
    }
}
