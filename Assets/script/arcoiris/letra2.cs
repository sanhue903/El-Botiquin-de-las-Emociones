using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class letra2 : MonoBehaviour
{
    string frase = "Su envidia era tanta, que la sentía en TODO su cuerpo. Tanto así, que un día, unos de sus cabellos amanecieron de color verde.\n\n¡Y todos los demás cabellos de su cabeza sintieron envidia de esos cabellos! ¡Por lo que decidieron también teñirse de color verde! ¡Todos los cabellos de su cabeza se tiñeron de verde!";
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
