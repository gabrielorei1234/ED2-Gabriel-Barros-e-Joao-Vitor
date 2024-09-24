namespace AV1;

using System;
using System.Collections.Generic;

public class ListaDeExclusao
{
    private List<string> _palavrasExcluidas;

    public ListaDeExclusao()
    {
        _palavrasExcluidas = new List<string> { "a", "o", "de", "e", "para" };
        _palavrasExcluidas.Sort();
    }

    public bool DeveExcluir(string palavra)
    {
        return Array.BinarySearch(_palavrasExcluidas.ToArray(), palavra.ToLower()) >= 0;
    }
}