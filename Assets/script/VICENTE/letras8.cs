using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class letras8 : MonoBehaviour
{
    string frase = "-¡Muchas gracias Bobby! ¡Qué alegría!\n- De nada Vicente, ahora ¡Todos podrán comprenderte mucho mejor!\n\nVicente nunca olvidó los consejos que le dio su fiel perrito, y logró comprender la importancia de expresar sus emociones en el momento en que las siente, y  que estas expresiones son, después de todo, “el idioma universal”.";
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