using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Tests;


public class UnitTest1
{
   ValuesController controller = new ValuesController();
[Fact]
[HttpGet("getnumber")]
public void GetReturnsCorrectNumber()
{
  var returnValue = controller.GetName(0);
  Console.WriteLine(returnValue);
  Assert.Equal("Amar", returnValue);
}
}