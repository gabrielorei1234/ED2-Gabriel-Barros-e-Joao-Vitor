namespace AV1;
using System.IO;

public class ProcessadorDeArquivos
{
    private ArvoreAVL _arvoreAVL;
    private ListaDeExclusao _listaDeExclusao;

    public ProcessadorDeArquivos(ArvoreAVL arvoreAVL, ListaDeExclusao listaDeExclusao)
    {
        _arvoreAVL = arvoreAVL;
        _listaDeExclusao = listaDeExclusao;
    }

    public void ProcessarArquivo(string caminhoArquivo)
    {
        var linhas = File.ReadAllLines(caminhoArquivo);
        for (int i = 0; i < linhas.Length; i++)
        {
            var palavras = linhas[i].Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var palavra in palavras)
            {
                if (!_listaDeExclusao.DeveExcluir(palavra))
                {
                    _arvoreAVL.Inserir(palavra.ToLower(), caminhoArquivo, i + 1);
                }
            }
        }
    }
}
