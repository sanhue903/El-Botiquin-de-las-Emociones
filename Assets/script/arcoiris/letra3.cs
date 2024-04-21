using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class letra3 : MonoBehaviour
{
    string frase = "Al día siguiente, el niño caminaba por la calle, cuando de repente unos mechones sintieron envidia del color del sol y se tiñeron de color amarillo.\n\nLos cabellos del otro lado de su cabeza, sintieron envidia de que fueran de otro color que no fuera verde y decidieron teñirse de colores distintos como, naranja, morado, rojo y celeste.";
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
