namespace AV1;

using AV1.Modelos;
using System;

public class ArvoreAVL
{
    private NoAVL _raiz;

    public List<ResultadoAVL> ObterResultadosInOrder()
    {
        var resultados = new List<ResultadoAVL>();
        PercorrerInOrder(_raiz, resultados);
        return resultados;
    }

    public void Inserir(string palavra, string nomeArquivo, int numeroLinha)
    {
        _raiz = Inserir(_raiz, palavra, nomeArquivo, numeroLinha);
    }

    private NoAVL Inserir(NoAVL no, string palavra, string nomeArquivo, int numeroLinha)
    {
        if (no == null)
        {
            var novoNo = new NoAVL(palavra);
            novoNo.AdicionarOcorrencia(nomeArquivo, numeroLinha);
            return novoNo;
        }

        if (string.Compare(palavra, no.Palavra, StringComparison.OrdinalIgnoreCase) < 0)
        {
            no.Esquerda = Inserir(no.Esquerda, palavra, nomeArquivo, numeroLinha);
        }
        else if (string.Compare(palavra, no.Palavra, StringComparison.OrdinalIgnoreCase) > 0)
        {
            no.Direita = Inserir(no.Direita, palavra, nomeArquivo, numeroLinha);
        }
        else
        {
            no.AdicionarOcorrencia(nomeArquivo, numeroLinha);
        }

        // Atualizar altura e balancear
        no.Altura = 1 + Math.Max(ObterAltura(no.Esquerda), ObterAltura(no.Direita));
        int balanceamento = ObterBalanceamento(no);

        // Balanceamento da árvore
        if (balanceamento > 1)
        {
            if (string.Compare(palavra, no.Esquerda.Palavra, StringComparison.OrdinalIgnoreCase) < 0)
            {
                return RotacionarDireita(no);
            }
            else
            {
                no.Esquerda = RotacionarEsquerda(no.Esquerda);
                return RotacionarDireita(no);
            }
        }

        if (balanceamento < -1)
        {
            if (string.Compare(palavra, no.Direita.Palavra, StringComparison.OrdinalIgnoreCase) > 0)
            {
                return RotacionarEsquerda(no);
            }
            else
            {
                no.Direita = RotacionarDireita(no.Direita);
                return RotacionarEsquerda(no);
            }
        }

        return no;
    }

    private int ObterAltura(NoAVL no)
    {
        return no?.Altura ?? 0;
    }

    private int ObterBalanceamento(NoAVL no)
    {
        return no == null ? 0 : ObterAltura(no.Esquerda) - ObterAltura(no.Direita);
    }

    private NoAVL RotacionarDireita(NoAVL y)
    {
        NoAVL x = y.Esquerda;
        NoAVL T2 = x.Direita;

        x.Direita = y;
        y.Esquerda = T2;

        y.Altura = Math.Max(ObterAltura(y.Esquerda), ObterAltura(y.Direita)) + 1;
        x.Altura = Math.Max(ObterAltura(x.Esquerda), ObterAltura(x.Direita)) + 1;

        return x;
    }

    private NoAVL RotacionarEsquerda(NoAVL x)
    {
        NoAVL y = x.Direita;
        NoAVL T2 = y.Esquerda;

        y.Esquerda = x;
        x.Direita = T2;

        x.Altura = Math.Max(ObterAltura(x.Esquerda), ObterAltura(x.Direita)) + 1;
        y.Altura = Math.Max(ObterAltura(y.Esquerda), ObterAltura(y.Direita)) + 1;

        return y;
    }

    private void PercorrerInOrder(NoAVL no, List<ResultadoAVL> resultados)
    {
        if (no != null)
        {
            PercorrerInOrder(no.Esquerda, resultados);
            foreach (var ocorrencia in no.OcorrenciasArquivos)
            {
                foreach (var linha in ocorrencia.Value)
                {
                    resultados.Add(new ResultadoAVL
                    {
                        Palavra = no.Palavra,
                        Arquivo = ocorrencia.Key,
                        Linha = linha.linha,
                        Contagem = linha.contagem
                    });
                }
            }
            PercorrerInOrder(no.Direita, resultados);
        }
    }

    public NoAVL ObterRaiz() => _raiz;    
}
