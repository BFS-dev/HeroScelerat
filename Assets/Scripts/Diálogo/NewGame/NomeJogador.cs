using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NomeJogador : MonoBehaviour
{
    [SerializeField]
    private InputField iField;

    [SerializeField]
    private GameObject ImageNomeJogador;

    private string nome;    

    [SerializeField]
    public GameObject Remover;

    public string GetNome() {
        nome = iField.text;
        Remover.gameObject.SetActive(false);
        ImageNomeJogador.gameObject.SetActive(false);
        return nome;
    }
}
