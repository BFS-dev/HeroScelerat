using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GerenciadorDialogo : MonoBehaviour
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
    private GameObject EscolhaFeminino;

    [SerializeField]
    private GameObject EscolhaMasculino;

    [SerializeField]
    private GameObject BotãoProximo;

    [SerializeField]
    private GameObject ProximaScene;

    [SerializeField]
    private GameObject Ratriz;

    private int cont = 0;
    private int ativo = 0;
    private Dialogo dialogoAtual;

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
        EscolhaFeminino.gameObject.SetActive(false);
        EscolhaMasculino.gameObject.SetActive(false);
        if (dialogoAtual == null)
            return;
        if (cont == dialogoAtual.GetFrases().Length)
        {
            caixaDialogo.gameObject.SetActive(false);
            dialogoAtual = null;
            cont = 0;
            return;
        }
        string name = dialogoAtual.GetNomeNPC(cont);
        if(name != "Ratriz") {
            Ratriz.gameObject.SetActive(false);
        } else {
            Ratriz.gameObject.SetActive(true);
        }
        nome.text = name;

        // frase.text = dialogoAtual.GetFrases()[cont].GetFrase();
        string str = dialogoAtual.GetFrases()[cont].GetFrase();

        StartCoroutine("mostrar_text", str);
        //mostrar_text(str);
        
        buttonContinuar.text = dialogoAtual.GetFrases()[cont].GetBotaoContinuar();
        caixaDialogo.gameObject.SetActive(true);
        if (ativo == 1) {
            ProximaScene.gameObject.SetActive(true);
        }
        if (cont == 3) {
            EscolhaFeminino.gameObject.SetActive(true);
            EscolhaMasculino.gameObject.SetActive(true);
            BotãoProximo.gameObject.SetActive(false);
            ativo = 1;
        }
        cont++;
    }
}