using Moq;
using Xunit;

namespace TestesDeMock
{
    public class ConsultaCreditoTests
    {
        [Fact]
        public void TestarConsultaComMock_Sucesso()
        {
            // Criando o mock do serviço de consulta de crédito
            var mockServico = new Mock<IServicoConsultaCredito>();

            // Configurando o mock para retornar 'true' quando o CPF fornecido for "12345678900"
            mockServico.Setup(s => s.Consultar("12345678900")).Returns(true);

            // Chamando o método Consultar no mock
            bool resultado = mockServico.Object.Consultar("12345678900");

            // Verificando se o resultado foi verdadeiro (sucesso na consulta)
            Assert.True(resultado);
        }

        [Fact]
        public void TestarConsultaComMock_Falha()
        {
            // Criando o mock do serviço de consulta de crédito
            var mockServico = new Mock<IServicoConsultaCredito>();

            // Configurando o mock para retornar 'false' quando o CPF fornecido for "98765432100"
            mockServico.Setup(s => s.Consultar("98765432100")).Returns(false);

            // Chamando o método Consultar no mock
            bool resultado = mockServico.Object.Consultar("98765432100");

            // Verificando se o resultado foi falso (falha na consulta)
            Assert.False(resultado);
        }
    }

    // Interface para o serviço de consulta de crédito
    public interface IServicoConsultaCredito
    {
        bool Consultar(string cpf);
    }
}
