using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TextoDialogo
{
    [SerializeField]
    [TextArea(1,4)]
    private string frase;

    [SerializeField]
    private string buttonContinuar;

    public string GetFrase()
    {
        return frase;
    }

    public string GetBotaoContinuar()
    {
        return buttonContinuar;
    }
}