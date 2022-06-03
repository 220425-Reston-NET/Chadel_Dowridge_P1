using Xunit;
using StoreModel;

namespace SneakerTest;

public class SneakerModelTest
{
    // This is how C#/Xunit reconizes that this particluar method will be a unit test
    // Data annotations - They just add specail metadat information that gives
    [Fact]
    public void SneakerID_Should_Set_VaildData()
    {
        //Arrange
        Sneaker sneakerObj = new Sneaker();
        int SneakerId = 28;

        //Act
        sneakerObj.SneakerID = SneakerId;

        //Assert
        Assert.NotNull(sneakerObj.SneakerID);
        Assert.Equal(SneakerId, sneakerObj.SneakerID);
    }
    
    /// <summary>
    /// Checks the validation for PokeId and checks if it fails (invalidData < 0)
    /// </summary>
    /// <param name="p_sneakerId">The inline data being given</param>
    [Theory]
    [InlineData(-19)]
    [InlineData(-1290)]
    [InlineData(0)]
    [InlineData(-12983)]
    public void StoreID_Should_Fail_Set_InvaildData(int p_sneakerId)
    {
        //Arrange
        Sneaker sneakerObj = new Sneaker();
        // int sneakerId = -19;

        //Act & Assert
        Assert.Throws<System.ComponentModel.DataAnnotations.ValidationException>(() =>
        {
            sneakerObj.SneakerID = p_sneakerId;
        });
    }
}


