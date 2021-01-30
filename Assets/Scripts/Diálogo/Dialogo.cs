using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class Dialogo
{

    [SerializeField]
    private TextoDialogo[] frases;

    [SerializeField]
    private string[] nome;

    public TextoDialogo[] GetFrases()
    {
        return frases;
    }

    public string GetNomeNPC(int x)
    {
        return nome[x];
    }

}
