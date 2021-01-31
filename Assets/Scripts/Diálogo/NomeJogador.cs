using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NomeJogador : MonoBehaviour
{
    [SerializeField]
    private Text iField;
    private string nome;
    void Start() 
    {
        nome = iField.text;
        print(nome);
    } 

    public string GetNome() {
        return nome;
    }
}
