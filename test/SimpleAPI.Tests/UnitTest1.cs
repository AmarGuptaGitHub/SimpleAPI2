namespace SimpleAPI.Tests;


public class UnitTest1
{
   ValuesController controller = new ValuesController();
[Fact]
public void GetReturnsCorrectNumber()
{
  var returnValue = controller.Get(0);
  Console.WriteLine(returnValue);
  Assert.Equal("Amar", returnValue);
}
}