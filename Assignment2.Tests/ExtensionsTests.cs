namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Flatten_Multiple()
    {
        // Arrange
        IEnumerable<IEnumerable<int>> multiple = new [] { new[] {1, 2}, new[] {3, 4} };
        // Act
        var actual = Extensions.Flatten(multiple);

        // Assert
        actual.Should().Equal(1, 2, 3, 4);
    }
    [Fact]
    public void div7great42_test(){
        //Arrange
        int[] list = new [] { 6, 21, 44, 49, 56};
        
        //act
        var actual = Extensions.div7great42(list);

        //assert
        actual.Should().Equal(49, 56);
    }
    
    [Fact]
    public void returns_true_if_given_leap_year()
    {
        //arrange
        int[] list = new [] {1600, 1704, 1800, 1900, 2000};

        //act
        var actual = Extensions.leapyears(list);
        //assert
        actual.Should().Equal(1600, 1704, 2000);

    }

    [Fact]
    public void Uri_test(){
        //arrange
        Uri uriTrue = new Uri("https://github.com/Nickromancer/assignment-02-GR21");
        Uri uriFalse = new Uri("http://info.cern.ch");

        //act
        var actualTrue = Extensions.IsSecure(uriTrue);
        var actualfalse = Extensions.IsSecure(uriFalse);

        //assert
        actualTrue.Should().BeTrue();
        actualfalse.Should().BeFalse();
    }

    [Fact]
    public void WordCount_test(){
        //arrange
        string str = "This string contains five words";

        //act
        var actual = Extensions.WordCount(str);

        //assert
        actual.Should().Be(5);
    }
}
