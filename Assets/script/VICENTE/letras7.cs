using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class letras7 : MonoBehaviour
{
    string frase = "-¡Oh!, ahora entiendo, es por eso que mamá y papá pueden comprenderte.\n-¡Exactamente! Lo mismo podrías hacer tú… Deja que tus expresiones fluyan en tu rostro.\n\nCuando sientas alegría ¡Sonríe! Cuando sientas ira o enojo ¡Frunce tus cejas! Cuando sientas tristeza, deja salir tus lágrimas. Cuando sientas miedo, tiembla o ¡Congélate! Cuando sientas asco, solo pon tu cara de “Wacalas”.";
    public TextMeshProUGUI texto;

    IEnumerator Reloj()
    {
        texto.text = " ";
        foreach (char caracter in frase)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.067f);
        }
    }
    public void blanco()
    {
        StartCoroutine(Reloj()); 
    }
}