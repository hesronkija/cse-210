using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
    }
}

class Vehicle 
{
    private string model;
    private string make;
    private int miles;

    public Vehicle(string model, string make, int miles) 
    {
        this.model = model;
        this.make = make;
        this.miles = miles;
    }
}

class Car : Vehicle
{
    Car(string model, string make, int miles, int towing) : base(model, make, miles)
    {
         
    }
}

class Truck : Vehicle
{
    private int towing;
    public Truck(string model, string make, int miles, int towing) : base(model, make, miles)
    {
        this.towing = towing;
    }
}