using Xunit;

namespace TestesDeUnidade
{
    public class ConversaoTemperaturaTests
    {
        [Theory]
        [InlineData(32, 0)]
        [InlineData(212, 100)]
        public void TestarConversaoFahrenheitParaCelsius(double fahrenheit, double celsiusEsperado)
        {
            double resultado = (fahrenheit - 32) * 5 / 9;
            Assert.Equal(celsiusEsperado, resultado);
        }
    }
}
