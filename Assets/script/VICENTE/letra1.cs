using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class letra1 : MonoBehaviour
{
    string frase =  "Vicente era un pequeño niño de 5 años que vivía con sus dos padres y su perrito Boby.";
    public TextMeshProUGUI texto;

    void Start()
    {
        StartCoroutine(Delay());
    }

    IEnumerator Reloj()
    {
        texto.text = " ";
        foreach (char caracter in frase)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.065f);
        }
    }
     IEnumerator Delay() // tiempo de espera para la lectura del titulo 
    {
        yield return new WaitForSeconds(.2f);
	    StartCoroutine(Reloj());
    }

    public void blanco()
    {
        StartCoroutine(Reloj());
    }
}
