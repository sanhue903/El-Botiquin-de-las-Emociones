using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class letra6 : MonoBehaviour
{
    string frase = "¡Los demás cabellos de su cabeza sintieron envidia del pequeño pelo y se soltaron también! ¡Y el niño quedó sorprendido ante su cabeza sin ningún pelo en el espejo!\n\nDesde ese día aprendió, que la envidia no era buena. Que todos tenemos un gran tesoro, que nos hace únicos y que tenemos que valorarlo, que es mejor apreciar lo que se tiene y no compararse con los demás.";
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
