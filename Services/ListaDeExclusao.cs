namespace AV1;

using System;
using System.Collections.Generic;

public class ListaDeExclusao
{
    private List<string> _palavrasExcluidas;

    public ListaDeExclusao(string palavrasInput)
    {
        _palavrasExcluidas = new List<string>(palavrasInput.Split(new[] { ',', ';', '"' }, StringSplitOptions.RemoveEmptyEntries));
        _palavrasExcluidas = _palavrasExcluidas.ConvertAll(p => p.Trim().ToLower());
        _palavrasExcluidas.Sort();
    }

    public bool DeveExcluir(string palavra)
    {
        return _palavrasExcluidas.Contains(palavra.ToLower());
    }
}