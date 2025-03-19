using Xunit;
using MathApp;

public class SubtractionTests
{
  [Fact]
  public void SubtractionTest()
  {
    int result = MathApp.MathOperations.Subtract(5, 3);
    Assert.Equal(2, result);
  }
}