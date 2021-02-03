using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NomeJogador : MonoBehaviour
{
    [SerializeField]
    private InputField iField;
    private string nome;    

    [SerializeField]
    public GameObject Remover;

    public string GetNome() {
        nome = iField.text;
        Remover.gameObject.SetActive(false);
        return nome;
    }
}
