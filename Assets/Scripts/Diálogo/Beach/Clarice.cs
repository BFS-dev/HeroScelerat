using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clarice : MonoBehaviour
{
    /* [SerializeField]
    private GameObject Player;
    [SerializeField]
    private GameObject clarice;
    [SerializeField]
    private GameObject BotaoConversar;

    private float distancia = 1000;

    public void calculandoDistancia(){
        distancia = Vector3.Distance(Player.transform.position, clarice.transform.position);
        if (distancia < 1.0) {
            BotaoConversar.gameObject.SetActive(true);
        }
    } */

    [SerializeField]
    private GameObject BotaoConversar;

    public void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")){
            //BotaoConversar.gameObject.SetActive(true);
            print("Colidiu até que enfim");
        }
    }

}
