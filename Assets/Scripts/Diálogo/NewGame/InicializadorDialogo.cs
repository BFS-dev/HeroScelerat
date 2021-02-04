using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InicializadorDialogo : MonoBehaviour
{
    [SerializeField]
    private GerenciadorDialogo gerenciador;

    [SerializeField]
    private Dialogo dialogo;
    
    [SerializeField]
    private GameObject Background;

    [SerializeField]
    private GameObject Parte1;

    [SerializeField]
    private GameObject Background2;

    [SerializeField]
    private GameObject Parte2;

    public void NewGame() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("NewGame");
    }

    public void TelaInicial() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TelaInicial");
    }

    public void Personalizacao() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Personalização");
    }

    public void MapaRotas() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MapaRotas");
    }

    public void Beach() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Beach");
    }


    public void Inicializa()
    {
        if (gerenciador == null)
            return;
        Background.gameObject.SetActive(false);
        Parte1.gameObject.SetActive(false);
        Background2.gameObject.SetActive(true);
        Parte2.gameObject.SetActive(true);
        gerenciador.Inicializa(dialogo);
    }
}