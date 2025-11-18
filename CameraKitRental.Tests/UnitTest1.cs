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

    [Fact]
    public void Constructor_Empty_Brand_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new CameraKit("", "Model1", "Camera1", "Mirrorless", 230.33));
    }

    [Fact]
    public void Constructor_Empty_Model_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new CameraKit("Canon", "", "Camera1", "Mirrorless", 230.33));
    }
    [Fact]
    public void Constructor_Empty_KitType_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new CameraKit("Canon", "Model1", "Camera1", "", 230.33));
    }
    [Fact]
    public void Constructor_Empty_AssetTag_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new CameraKit("Canon", "Model1", "", "Mirrorless", 230.33));
    }

    [Fact]
    public void isBooked_Returns_Correct_Status()
    {
        var cameraKit = CreateDefaultCameraKit();
        Assert.False(cameraKit.isBooked());

        cameraKit.Book();
        Assert.True(cameraKit.isBooked());
    }

    [Fact]
    public void CheckRate_Returns_Correct_DailyRate()
    {
        var cameraKit = CreateDefaultCameraKit();
        Assert.Equal(230.33, cameraKit.CheckRate());
    }

}
