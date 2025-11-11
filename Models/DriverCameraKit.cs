using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CameraKitRental.Models;

public static class DriverCameraKit
{
    public static void Run()
    {
        try
        {
            CameraKit cameraKit = new CameraKit("Canon", "Model1", 230.33);

            cameraKit.Display();

            cameraKit.Book();

            cameraKit.Display();

            cameraKit.Book(); // Attempt to book again to test error handling

            cameraKit.returnKit();

            cameraKit.Display();

            Console.WriteLine($"Camera Kit is booked: {cameraKit.Booked}\n");
            Console.WriteLine($"Camera Kit is not booked: {!cameraKit.Booked}\n");

            if (!cameraKit.isBooked())
            {
                cameraKit.Book();
            }

        }

        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error creating CameraKit: {ex.Message}\n");
        }

        finally

        {
            Console.WriteLine("DriverCameraKit Run method completed.\n");
        }

    }
}
