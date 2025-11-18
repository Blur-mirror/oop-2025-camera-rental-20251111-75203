// See https://aka.ms/new-console-template for more information

// Create a class called CameraKit with the following public attributes:

//     brand (String)
//     model (String)
//     kitType (String, e.g., DSLR, Mirrorless, Cinema)
//     assetTag (String)
//     dailyRate (double)
//     booked (Boolean)

// Add the following methods:

//     Constructor
//         Takes 6 parameters to set all attributes above.
//     book()
//         If booked is false, set it to true.
//         Otherwise, print a clear error message indicating the kit is already booked.
//     returnKit()
//         Set booked to false.
//     changeRate(double newRate)
//         Update dailyRate to newRate.
//     checkRate()
//         Return the current dailyRate.
//     checkBooked()
//         Return the current booked status.
//     display()
//         Print the six attributes in a neat, labeled format (e.g., brand: Canon) with a header line and a blank line at the end.

// Design requirement: Add validation methods, abstract classes, and interfaces you deem appropriate (e.g., validation of non-empty strings, positive rates; an interface for priceable items; an abstract base for rentable assets). Structure your solution cleanly (packages/namespaces, comments, naming conventions).

using System.ComponentModel.DataAnnotations;
using CameraKitRental.Models;

Console.WriteLine("Hello, World!");


DriverCameraKit.Run();
