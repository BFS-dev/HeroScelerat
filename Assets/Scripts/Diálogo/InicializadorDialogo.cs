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

    public void NewGame() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("NewGame");
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
        gerenciador.Inicializa(dialogo);
    }
}