using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Gerenciador2 : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI nome;
    [SerializeField]
    private TextMeshProUGUI frase;
    [SerializeField]
    private TextMeshProUGUI buttonContinuar;

    [SerializeField]
    private GameObject caixaDialogo;

    [SerializeField]
    private GameObject joysticker;

    [SerializeField]
    private GameObject botaoCorrer;

    [SerializeField]
    private GameObject botaoProximo;

    [SerializeField]
    private GameObject botaoStop;

    [SerializeField]
    private GameObject Calado;

    [SerializeField]
    private GameObject Responder;

    public TextMeshProUGUI ativo;

    private Dialogo dialogoAtual;
    private int cont = 0;

    public void Inicializa(Dialogo dialogo)
    {
        cont = 0;
        dialogoAtual = dialogo;
        ProximaFrase();
    }

    IEnumerator mostrar_text(string str)
    {
        frase.text = "";
        for(int letter = 0; letter < str.Length; letter++)
        {
            frase.text = frase.text + str[letter];
            if (str[letter] == 'é') {
                if (letter == str.Length - 1) {
                    string strAux = nome.text;
                    frase.text = frase.text + ' ' + strAux + '.';
                }
            }
            yield return new WaitForSeconds(0.05f);
        }
    } 

    public void ProximaFrase()
    {
        joysticker.gameObject.SetActive(false);
        botaoCorrer.gameObject.SetActive(false);
        if( cont != 1){
            botaoProximo.gameObject.SetActive(true);
            Calado.gameObject.SetActive(false);
            Responder.gameObject.SetActive(false);
        }
        if (dialogoAtual == null)
            return;
        if (cont == dialogoAtual.GetFrases().Length)
        {
            caixaDialogo.gameObject.SetActive(false);
            dialogoAtual = null;
            cont = 0;
            joysticker.gameObject.SetActive(true);
            botaoCorrer.gameObject.SetActive(true);
            return;
        }
        string name = dialogoAtual.GetNomeNPC(cont);
        nome.text = name;

        // frase.text = dialogoAtual.GetFrases()[cont].GetFrase();
        string str = dialogoAtual.GetFrases()[cont].GetFrase();

        StartCoroutine("mostrar_text", str);
        //mostrar_text(str);
        
        buttonContinuar.text = dialogoAtual.GetFrases()[cont].GetBotaoContinuar();
        caixaDialogo.gameObject.SetActive(true);
        // string ativador = ativo.text;
        if(cont == 1) {
            if (ativo.text == "0") {
                botaoProximo.gameObject.SetActive(false);
                Calado.gameObject.SetActive(true);
                Responder.gameObject.SetActive(true);
                ativo.text = ativo.text + 'a';
            }
        }
        cont++;
    }
}