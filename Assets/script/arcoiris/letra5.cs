using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class letra5 : MonoBehaviour
{
    string frase = "Al otro día, una ceja se le tiñó de color azul y así fue como todos los pelos de su cuerpo se pusieron azules también ¡De pura envidia!\n\nY un día consumido por la envidia, se tiró muy fuerte los cabellos, y un pelo de raíz pequeñita no aguantó y se le salió.";
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
