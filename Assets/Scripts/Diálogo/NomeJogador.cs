using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NomeJogador : MonoBehaviour
{
    [SerializeField]
    private InputField iField;
    private string nome;    

    public string GetNome() {
        nome = iField.text;
        return nome;
    }
}
