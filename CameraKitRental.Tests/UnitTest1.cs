using System.Reflection;
using CameraKitRental.Models;
namespace CameraKitRental.Tests;


public class UnitTest1
{

    private CameraKit CreateDefaultCameraKit(bool booked = false)
    {
        return new CameraKit("Canon", "Model1", "Camera 1", "Mirrorless", 230.33);
    }

    [Fact]
    public void Constructor_Properties_Are_Set_Correctly()
    {
        var cameraKit = CreateDefaultCameraKit();

        Assert.Equal("Canon", cameraKit.Brand);
        Assert.Equal("Model1", cameraKit.Model);
        Assert.Equal("Camera 1", cameraKit.AssetTag);
    }
}
