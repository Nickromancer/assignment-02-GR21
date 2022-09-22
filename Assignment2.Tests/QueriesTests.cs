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
        res.Should().Equal(exp);

    }

    [Fact]
    public void firstSithExtTest()
    {
        //arrange
        int exp = 1977;

        //act
        var res = q.firstSithExt();

        //asert
        res.Should().Equal(exp);

    }

    [Fact]
    public void uniqHPExtTest()
    {
        //arrange
        IEnumerable<(string, int?)> exp = new List<(string, int?)> {("Albus Dumbledore",1997), ("Severus Snape",1997)};

        //act
        var res = q.uniqHPExt();

        //asert
        res.Should().Equal(exp);

    }

    [Fact]
    public void wizRevExtTest()
    {
        //arrange
        IEnumerable<string> exp = new List<string> {
            "Doctor Strange", "Morgan Le Fay", "Gandalf",
            "Saruman", "Sauron", "Albus Dumbledore",
            "Severus Snape", "Darth Sidious", "Darth Vader",
            "Zatanna Zatara"
        };

        //act
        var res = q.wizRevExt();

        //asert
        res.Should().Equal(exp);

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
        res.Should().Equal(exp);

    }

    [Fact]
    public void firstSithTest()
    {
        //arrange
        int exp = 1977;

        //act
        var res = q.firstSith();

        //asert
        res.Should().Equal(exp);

    }

    [Fact]
    public void uniqHPTest()
    {
        //arrange
        IEnumerable<(string, int?)> exp = new List<(string, int?)> {("Albus Dumbledore",1997), ("Severus Snape",1997)};

        //act
        var res = q.uniqHP();

        //asert
        res.Should().Equal(exp);

    }

    [Fact]
    public void wizRevTest()
    {
        //arrange
        IEnumerable<string> exp = new List<string> {
            "Doctor Strange", "Morgan Le Fay", "Gandalf",
            "Saruman", "Sauron", "Albus Dumbledore",
            "Severus Snape", "Darth Sidious", "Darth Vader",
            "Zatanna Zatara"
        };

        //act
        var res = q.wizRev();

        //asert
        res.Should().Equal(exp);

    }
}
