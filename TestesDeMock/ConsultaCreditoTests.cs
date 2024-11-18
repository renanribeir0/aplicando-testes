using Moq;
using Xunit;

namespace TestesDeMock
{
    public class ConsultaCreditoTests
    {
        [Fact]
        public void TestarConsultaComMock()
        {
            var mockServico = new Mock<IServicoConsultaCredito>();
            mockServico.Setup(s => s.Consultar("12345678900")).Returns(true);

            bool resultado = mockServico.Object.Consultar("12345678900");

            Assert.True(resultado);
        }
    }

    public interface IServicoConsultaCredito
    {
        bool Consultar(string cpf);
    }
}
