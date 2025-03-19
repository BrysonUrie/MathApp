using Xunit;
using MathApp;

public class AdditionTests
{
  [Fact]
  public void AdditionTest()
  {
    int result = MathApp.MathOperations.Add(5, 3);
    Assert.Equal(8, result);
  }
}