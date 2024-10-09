using Xunit;
using MathApp;

public class MathAppTests
{
  [Fact]
  public void Test1()
  {
    int a = 5;
    int b = 3;
    int result = MathApp.MathOperations.Add(5, 3);
    Console.WriteLine("hi");
    Assert.Equal(8, result);
  }
}


