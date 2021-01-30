using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class TypeWriter : MonoBehaviour {

    public Text textWriter;
    public float delayWriter = 0.1f;
    public string escrevaFrase;

    // Start is called before the first frame update
    void Start() 
    {
        StartCoroutine("mostrar_text", escrevaFrase);
    }

    IEnumerator mostrar_text( string textType ) 
    {
        textWriter.text = ""; // auxiliar que começa vazia e vai sendo preenchida letra por letra.

        for(int letter = 0; letter < textType.Length; letter++)
        {
            textWriter.text = textWriter.text + textType[letter];
            yield return new WaitForSeconds(delayWriter);
        }

    }
}
