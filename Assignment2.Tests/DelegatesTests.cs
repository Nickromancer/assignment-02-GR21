namespace Assignment2.Tests;

public class DelegatesTests
{
    delegate string RevDel(string s);
    
    delegate decimal ProdDel(decimal x, decimal y);
    
    delegate bool EqsDel(int i, string s);

    string Rev(string s) {
        var chaS = s.ToCharArray();
        Array.Reverse(chaS);
        return new string(chaS);
    }
    
    decimal Prod(decimal x, decimal y) {
        return x*y;
    }
    
    bool Eqs(int i, string s) {
        return i == Int32.Parse(s);
    }

    [Fact]
    public void Reverse_Test()
    {
        //arrange
        string exp = "gid dem jeh";

        //act
        RevDel revTest = (x) => {
            return Rev(x);
        };
        string res = revTest("hej med dig");

        //assert
        res.Should().Be(exp);
    }

    [Fact]
    public void Product_Test()
    {
        //arrange
        decimal exp = 11.5M;
        
        //act
        ProdDel prodTest = (x, y) => {
            return Prod(x, y);
        };
        decimal res = prodTest(23, 0.5M);

        //assert
        res.Should().Be(exp);
    }
    
    [Fact]
    public void Equals_Test()
    {
        //arrange
        bool exp = true;
        
        //act
        EqsDel eqsTest = (x, y) => {
            return Eqs(x, y);
        };
        bool res = eqsTest(42, " 0042");

        //assert
        res.Should().Be(exp);
    }
}
