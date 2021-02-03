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

    public void TrocarScene() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("NewGame");
    }

    public void Inicializa()
    {
        if (gerenciador == null)
            return;
        gerenciador.Inicializa(dialogo);
    }
}