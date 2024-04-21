using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class letras2 : MonoBehaviour
{
    string frase = "A él le gustaba pasar tiempo con su mascota y su familia, sin embargo la mayor parte del tiempo Vicente mantenía un rostro que no expresaba emociones, porque él no las conocía. \n\nEn ocasiones, esto hacía que a sus padres y otras personas, se les dificultara entender lo que Vicente les quería expresar.";
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
