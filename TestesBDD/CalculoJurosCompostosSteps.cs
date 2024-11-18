using TechTalk.SpecFlow;
using Xunit;

namespace TestesBDD
{
    [Binding]
    public class CalculoJurosCompostosSteps
    {
        private double _emprestimo;
        private double _taxa;
        private int _meses;
        private double _resultado;

        [Given(@"o valor do emprestimo é (.*)")]
        public void DadoOValorDoEmprestimoE(double emprestimo)
        {
            _emprestimo = emprestimo;
        }

        [Given(@"a taxa de juros é (.*)%")]
        public void DadoATaxaDeJurosE(double taxa)
        {
            _taxa = taxa / 100;
        }

        [Given(@"o periodo é de (.*) meses")]
        public void DadoOPeriodoEDeMeses(int meses)
        {
            _meses = meses;
        }

        [When(@"eu calcular o montante")]
        public void QuandoEuCalcularOMontante()
        {
            _resultado = _emprestimo * Math.Pow(1 + _taxa, _meses);
        }

        [Then(@"o resultado será (.*)")]
        public void EntaoOResultadoSera(double esperado)
        {
            Assert.Equal(esperado, Math.Round(_resultado, 2));
        }
    }
}
