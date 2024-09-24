namespace AV1;

using System.Collections.Generic;

public class NoAVL
{
    public string Palavra;
    public Dictionary<string, List<(int linha, int contagem)>> OcorrenciasArquivos;
    public NoAVL Esquerda;
    public NoAVL Direita;
    public int Altura;

    public NoAVL(string palavra)
    {
        Palavra = palavra;
        OcorrenciasArquivos = new Dictionary<string, List<(int linha, int contagem)>>();
        Altura = 1;
    }

    public void AdicionarOcorrencia(string nomeArquivo, int numeroLinha)
    {
        if (!OcorrenciasArquivos.ContainsKey(nomeArquivo))
        {
            OcorrenciasArquivos[nomeArquivo] = new List<(int linha, int contagem)>();
        }

        var linhasArquivo = OcorrenciasArquivos[nomeArquivo];
        var ultima = linhasArquivo.Count > 0 ? linhasArquivo[^1] : (linha: -1, contagem: 0);

        if (ultima.linha == numeroLinha)
        {
            linhasArquivo[^1] = (numeroLinha, ultima.contagem + 1);
        }
        else
        {
            linhasArquivo.Add((numeroLinha, 1));
        }
    }
}
