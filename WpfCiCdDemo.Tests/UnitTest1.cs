using WpfCiCdDemo;

namespace WpfCiCdDemo.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Topla_IkiEdedin_Cemi()
        {
            var calc = new Calculator();
            int netice = calc.Topla(2, 3);
            Assert.Equal(5, netice);
        }
    }
}