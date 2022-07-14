# Projeto: Calculando IR

Crie um programa que receba um valor e apresente o imposto a ser pago com base na tabela abaixo¹:

Faixas de Valor($)&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;Aliquota&emsp;&emsp;&emsp;&emsp;Deduzir<br />
Até 22.847,76&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&ensp; Isento&emsp;&emsp;&emsp;&emsp;&emsp; Isento<br />
De 22.847,77 a 33.919,80&emsp;&emsp;&ensp; 0,075&emsp;&emsp;&emsp;&emsp;&emsp;&ensp;1.713,58<br />
De 33.919,81 a 45.012,60&emsp;&emsp;&ensp; 0,150&emsp;&emsp;&emsp;&emsp;&emsp;&ensp;4.257,57<br />
De 45.012,61 a 55.976,16&emsp;&emsp;&ensp; 0,225&emsp;&emsp;&emsp;&emsp;&emsp;&ensp;7.633,51<br />
Acima de 55.976,16 &emsp;&emsp;&emsp;&emsp;&emsp;0,275&emsp;&emsp;&emsp;&emsp;&emsp;&ensp;10.432,32<br />

O programa deve seguir algumas diretrizes:

Estar dividido em 3 camadas principais:

DOMAIN: camada responsável por conter:
- Classes que são apenas para conter dados (POCOs/DTOs)
- Enums
- Extensões
- Qualquer outro tipo de informação que seja comum a todas as camadas

PRESENTATION: camada que representa o console app. Nesta camada poderemos ter:
- Uma interface que represente a lógica da "tela".
- Uma classe que contenha a lógica da "tela". A lógica da tela não deve estar diretamente no método Main da classe Program
- A classe deve receber a 'injeção' da interface através do construtor da classe
- Mensagens apresentadas aos usuário
- Entrada de dados
- Montagem dos objetos que contém dados (POCOs/DTOs)
- Criação do container para injeção de dependência

SERVICES: camada responsável por conter as regras de negócio. Essa camada terá a princípio:
- Uma interface ITaxCalculator com um método: TaxCalculation
- A implementação dessa interface

Segue abaixo exemplo da interface:

public interface ITaxCalculator
{
    double TaxCalculation(double value);
}

¹A tabela representa o cálculo de imposto anual para verificar se um contribuinte pagou mais ou menos imposto durante um ano. Caso o valor esteja acima da soma de impostos retidos ma fonte durante um ano o contribuinte poderá ter uma restituição. Essa informação é apenas a título de curiosidade em nada afeta o comportamento do programa.
