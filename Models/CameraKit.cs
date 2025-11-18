using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CameraKitRental.Models;

public abstract class RentalItem
{
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public double DailyRate { get; set; } = 0.0;
    public bool Booked { get; protected set; } = false;

    protected RentalItem(string brand, string model, double dailyRate)
    {
        if (string.IsNullOrEmpty(brand) || (string.IsNullOrEmpty(model)) || (dailyRate <= 0))
        {
            throw new ArgumentException("Invalid parameters for CameraKit constructor.");

        }

        Brand = brand;
        Model = model;
        DailyRate = dailyRate;

    }

    public abstract void Display();

}

public interface IRentable
{
    bool Book();
    void returnKit();
    void Display();

    bool isBooked();

    double CheckRate();

    void changeRate(double newRate);
}

public class CameraKit : RentalItem, IRentable
{
    // public CameraKit()
    // {
    //     Console.WriteLine("CameraKit instance created.\n");

    // }

    public string AssetTag { get; set; } = string.Empty;
    public string KitType { get; set; } = string.Empty;



    public double CheckRate() => DailyRate;

    public void changeRate(double newRate)
    {
        if (newRate > 0)
        {
            DailyRate = newRate;
            Console.WriteLine($"CameraKit: {Brand} {Model} rate changed to {DailyRate}\n");
        }
        else
        {
            Console.WriteLine("Error: Daily rate must be positive.\n");
        }
    }


    public CameraKit(string brand, string model, string assetTag, string kitType, double dailyRate) : base(brand, model, dailyRate)
    {
        if (string.IsNullOrEmpty(brand) || (string.IsNullOrEmpty(model)) || (dailyRate <= 0))
        {
            throw new ArgumentException("Invalid parameters for CameraKit constructor.");

        }

        AssetTag = assetTag;
        KitType = kitType;
    }

    public override void Display()
    {
        Console.WriteLine("\nCameraKit Display Called\n");
        Console.WriteLine(new string('*', 40));
        Console.WriteLine($"\nBranch: {Brand}, Model: {Model}, Asset Tag: {AssetTag}, Kit Type: {KitType} Daily Rate: {DailyRate}, Booked: {Booked}\n");
    }

    public bool Book()
    {
        if (!Booked)
        {
            Booked = true;
            Console.WriteLine($"CameraKit: {Brand} {Model} has been booked.\n");
            return true;
        }
        else
        {
            Console.WriteLine($"Error: CameraKit: {Brand} {Model} is already booked.\n");
            return false;

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
