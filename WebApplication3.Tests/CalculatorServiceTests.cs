using WebApplication3.Services;
using Xunit;

namespace WebApplication3.Tests
{
    public class CalculatorServiceTests
    {
        [Fact]
        public void TwoPlusFiveShouldBeSeven()
        {
            var service = new CalculatorService();
            var result = service.Add(2, 5);
            Assert.Equal(7, result);
        }
    }
}
