namespace Assignment2.Tests;

public class QueriesTests
{
    Queries q = new Queries();

    // Extension
    [Fact]
    public void byRowlingExtTest()
    {
        //arrange
        IEnumerable<string> exp = new List<string>(){"Albus Dumbledore","Severus Snape"};

        //act
        var res = q.byRowlingExt();

        //asert
        res.Should().BeEquivalentTo(exp);

    }

    [Fact]
    public void firstSithExtTest()
    {
        //arrange

        //act

        //asert

    }

    [Fact]
    public void uniqHPExtTest()
    {
        //arrange

        //act

        //asert

    }

    [Fact]
    public void wizRevExtTest()
    {
        //arrange

        //act

        //asert

    }

    // LINQ
    [Fact]
    public void byRowlingTest()
    {
        //arrange
        IEnumerable<string> exp = new List<string>(){"Albus Dumbledore","Severus Snape"};

        //act
        var res = q.byRowling();

        //asert
        res.Should().BeEquivalentTo(exp);

    }

    [Fact]
    public void firstSithTest()
    {
        //arrange

        //act

        //asert

    }

    [Fact]
    public void uniqHPTest()
    {
        //arrange

        //act

        //asert

    }

    [Fact]
    public void wizRevTest()
    {
        //arrange

        //act

        //asert

    }
}
