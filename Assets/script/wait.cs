using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wait : MonoBehaviour
{
    public string scene;
    public float time;

    private void Start()
    {
        StartCoroutine(Delay());
    
    }

     IEnumerator Delay()
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(scene);
    }
}
