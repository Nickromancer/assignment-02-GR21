namespace Assignment2.Tests;

public class StudentTests
{
    [Fact]
    public void create_student_return_student_toString()
    {
        //arrange
        var swu = new Student("John", "Jensen");
        var ddit = new Student("Stine", "Johansen");
        var gbi = new Student("Bob", "Jansen");
        //act

        var output = ddit.ToString();
        //assert
        output.Should().Be("Student: Johansen, Stine; Graduated \n Student ID: 1");
    }

    [Fact]
    public void create_immutable_student_return_string()
    {
        //arrange
        ImmutableStudent student = new(3, "Nancy", "Davolio");
        //act
        var output = student.ToString();
        //assert
        output.Should().Be("ImmutableStudent { Id = 3, GivenName = Nancy, Surname = Davolio }");
    }    
}