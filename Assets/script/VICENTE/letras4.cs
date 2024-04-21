using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class letras4 : MonoBehaviour
{
    string frase = "Para su sorpresa Boby le respondió:\n-Es porque hablo el idioma mundial, el de las emociones.\n-¿El qué..?\n\nBoby muy contento, le explicó a su gran amigo, la importancia de la expresión de las emociones para que los demás le comprendan.\n\nTus Padres me comprenden porque... cuando estoy feliz, muevo la colita y saco mi lengua.";
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