using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class letras3 : MonoBehaviour
{   
    string frase = "Un día, Vicente estaba sentado en el patio con su perrito y se puso a pensar en voz alta:\n-Me gustaría que mis padres me pudieran entender, como lo hacen contigo, ellos siempre entienden lo que quieres o lo que te pasa.\n\nMiró a Boby, le hizo cariño en la cabeza y luego le preguntó:\n-¿Cómo es que ellos siempre te comprenden Boby? Si ni siquiera  hablamos el mismo idioma.";
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