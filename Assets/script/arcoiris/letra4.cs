using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class letra4 : MonoBehaviour
{
    string frase = "A todos les gustaba mucho la melena colorida del niño, por eso le decían el “niño cabeza de arcoíris”.\n\nPero al niño parecía no importarle, ya que seguía envidiando a los demás. ¡Ahora quería tener un pelo normal!";
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
