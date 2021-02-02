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

    private int cont = 0;
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
            yield return new WaitForSeconds(0.1f);
        }
    } 

    public void ProximaFrase()
    {
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
        nome.text = name;

        // frase.text = dialogoAtual.GetFrases()[cont].GetFrase();
        string str = dialogoAtual.GetFrases()[cont].GetFrase();

        StartCoroutine("mostrar_text", str);
        //mostrar_text(str);
        
        buttonContinuar.text = dialogoAtual.GetFrases()[cont].GetBotaoContinuar();
        caixaDialogo.gameObject.SetActive(true);
        cont++;
    }
}