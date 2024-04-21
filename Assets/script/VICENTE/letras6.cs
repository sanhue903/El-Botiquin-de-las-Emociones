using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class letras6 : MonoBehaviour
{
    string frase ="Cuando siento sorpresa, abro mi boca y levanto mis orejitas.\n\nY por último, cuando me dan de comer esas croquetas de verduras, siento mucho asco, siento un “¡Wacalas!”, interno, abro la boca y cierro los ojos al enfrentarme a tal desagradable sabor.";
    public TextMeshProUGUI texto;

    IEnumerator Reloj()
    {
        texto.text = " ";
        foreach (char caracter in frase)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.065f);
        }
    }

    public void blanco()
    {
        StartCoroutine(Reloj());
    }
}
