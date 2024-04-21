using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class letras1 : MonoBehaviour
{
    string frase = "Había una vez un niño que envidiaba a todos, incluyendo a sus amigos, a sus primos, e incluso a sus papás.";
    public TextMeshProUGUI texto;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Delay());
    }

    IEnumerator Reloj()
    {
        texto.text = " ";
        foreach (char caracter in frase)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.065f);
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2.5f);
	    StartCoroutine(Reloj());
    }

        public void blanco()
    {
        StartCoroutine(Reloj());
    }
}
