using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class letras5 : MonoBehaviour
{
    string frase = "Cuando algo me causa enfado, muestro mis feroces colmillos, mi colita se detiene y … ¡Gruño, gruño!\n\nCuando me siento triste, mi cabeza se agacha, mi colita y mis orejas también, hasta que mi mirada se va al suelo.\n\nCuando siento miedo, como esa vez en que el perro de la vecina intentó morderme la pata, tiemblo, mi colita se mete entre mis piernas y mis ojitos intentan buscar la ayuda de tus padres.";
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
