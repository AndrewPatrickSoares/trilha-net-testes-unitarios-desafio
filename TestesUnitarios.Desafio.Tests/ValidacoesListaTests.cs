using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        List<int> lista = new List<int> { 5, -1, -8, 9 };
        List<int> resultadoEsperado = new List<int> { 5, 9 };
        List<int> resultado = _validacoes.RemoverNumerosNegativos(lista);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        List<int> lista = new List<int> { 5, -1, -8, 9 };
        int numeroParaProcurar = 9;
        bool resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        List<int> lista = new List<int> { 5, -1, -8, 9 };
        int numeroParaProcurar = 10;
        bool resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        Assert.False(resultado);
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        List<int> lista = new List<int> { 5, 7, 8, 9 };
        List<int> resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        List<int> resultado = _validacoes.MultiplicarNumerosLista(lista, 2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        List<int> lista = new List<int> { 5, -1, -8, 9 };
        int maiorNumeroDeveSer = 9;
        int resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        Assert.Equal(maiorNumeroDeveSer, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        List<int> lista = new List<int> { 5, -1, -8, 9 };
        int menorNumeroDeveSer = -8;
        int resultado = _validacoes.RetornarMenorNumeroLista(lista);

        Assert.Equal(menorNumeroDeveSer, resultado);
    }
}
