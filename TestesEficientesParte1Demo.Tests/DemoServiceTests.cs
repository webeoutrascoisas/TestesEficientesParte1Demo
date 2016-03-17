using Xunit;

namespace TestesEficientesParte1Demo.Tests
{
    public class DemoServiceTests
    {
        [Theory]
        [InlineData(7, true)]
        [InlineData(8, false)]
        [InlineData(23, true)]
        [InlineData(179, true)]
        [InlineData(463, true)]
        [InlineData(617, true)]
        [InlineData(649, false)]
        [InlineData(811, true)]
        [InlineData(907, true)]
        [InlineData(972, false)]
        [InlineData(997, true)]
        public void IsPrimeNumber_WhenNumberIs7_ShouldReturnTrue(int number, bool expectedResult)
        {
            var service = new Demo1Service();

            Assert.Equal(service.IsPrimeNumber(number), expectedResult);
        }
    }
}
