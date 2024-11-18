Feature: Calculo de Juros Compostos
  Scenario: Simular calculo de juros compostos
    Given o valor do emprestimo é 1000
    And a taxa de juros é 2%
    And o periodo é de 12 meses
    When eu calcular o montante
    Then o resultado será 1268.24
