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

    [SerializeField]
    private NomeJogador jogador;

    public TextoDialogo[] GetFrases()
    {
        return frases;
    }

    public string GetNomeNPC(int x)
    {
        if(nome[x] == "jogador"){
            nome[x] = jogador.GetNome();
        }
        return nome[x];
    }

}
