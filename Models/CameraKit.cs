using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CameraKitRental.Models;

public class CameraKit
{
    //adding attributes:
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public double DailyRate { get; set; } = 0.0;
    public bool Booked { get; protected set; } = false;



    public CameraKit()
    {
        Console.WriteLine("CameraKit instance created.\n");

    }

    public CameraKit(string brand, string model, double dailyRate)
    {
        if (string.IsNullOrEmpty(brand) || (string.IsNullOrEmpty(model)) || (dailyRate <= 0))
        {
            throw new ArgumentException("Invalid parameters for CameraKit constructor.");

        }

        Brand = brand;
        Model = model;
        DailyRate = dailyRate;

    }

    public void Display()
    {
        Console.WriteLine("\nCameraKit Display Called\n");
        Console.WriteLine(new string('*', 40));
        Console.WriteLine($"\nBranch: {Brand}, Model: {Model}, Daily Rate: {DailyRate}, Booked: {Booked}\n");
    }

    public void Book()
    {
        if (!Booked)
        {
            Booked = true;
            Console.WriteLine($"CameraKit: {Brand} {Model} has been booked.\n");
        }
        else
        {
            Console.WriteLine($"Error: CameraKit: {Brand} {Model} is already booked.\n");

        }
    }

    public void returnKit()
    {
        if (Booked)
        {
            Booked = false;
            Console.WriteLine($"CameraKit: {Brand} {Model} has been returned.\n");
        }
        else
        {
            Console.WriteLine($"Error: CameraKit: {Brand} {Model} was not booked.\n");
        }
    }

    public bool isBooked() => Booked;
    
}
