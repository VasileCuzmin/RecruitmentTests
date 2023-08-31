using FluentAssertions;
using System.Text;
using Xunit;

namespace DiamondKata.Tests;

public class DiamondKataTests
{
    [Fact]
    public void PrintDiamondKata_EmptyMiddleCharacterParam_ReturnsEmpty()
    {
        //Arrange
        var sut = new DiamondKata();

        //Act
        var result = sut.GetDiamondKata('\0');

        //Assert
        result.Should().BeNullOrEmpty();
    }

    [Fact]
    public void PrintDiamondKata_A_MiddleCharacterParam_Returns_ExpectedResult()
    {
        //Arrange
        var sut = new DiamondKata();
        var expectedResult = "__A__";

        //Act
        var result = sut.GetDiamondKata('A');

        //Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void PrintDiamondKata_B_MiddleCharacterParam_ReturnsExpectedResult()
    {
        //Arrange
        var sut = new DiamondKata();
        var sb = new StringBuilder();
        sb.Append("__A__");
        sb.Append("\n");
        sb.Append("_B_B_");
        sb.Append("\n");
        sb.Append("__A__");
        var expectedResult = sb.ToString();

        //Act
        var result = sut.GetDiamondKata('B');

        //Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void PrintDiamondKata_C_MiddleCharacterParam_ReturnsExpectedResult()
    {
        //Arrange
        var sut = new DiamondKata();
        var sb = new StringBuilder();
        sb.Append("__A__");
        sb.Append("\n");
        sb.Append("_B_B_");
        sb.Append("\n");
        sb.Append("C___C");
        sb.Append("\n");
        sb.Append("_B_B_");
        sb.Append("\n");
        sb.Append("__A__");
        var expectedResult = sb.ToString();

        //Act
        var result = sut.GetDiamondKata('C');

        //Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void PrintDiamondKata_OtherMiddleCharacterParam_ReturnsEmptyString()
    {
        //Arrange
        var sut = new DiamondKata();

        //Act
        var result = sut.GetDiamondKata('D');

        //Assert
        result.Should().Be(string.Empty);
    }
}