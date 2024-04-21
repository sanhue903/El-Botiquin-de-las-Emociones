using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class letra7 : MonoBehaviour
{
    string frase = "Su calva cabeza la convirtió en su lienzo personal. Hacía unas pinturas tan lindas en su cuero cabelludo, que todos quienes lo veían admiraban.\n\nEl niño descubrió su verdadera vocación y se convirtió en un gran artista, viajando por todo el mundo mostrando sus pinturas.";
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