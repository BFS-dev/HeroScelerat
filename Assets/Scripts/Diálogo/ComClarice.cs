using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ComClarice : MonoBehaviour
{
    [SerializeField]
    private GerenciadorDialogo gerenciador;

    [SerializeField]
    private Dialogo dialogo;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Clarice")){
            Debug.Log("Colidiu com Clarice");
            gerenciador.Inicializa(dialogo);
        }
        
    }
}