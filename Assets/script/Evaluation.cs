using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Evaluation : MonoBehaviour
{
    public GameObject score;
    public GameObject apiClient;
    private string URL = "";
    // Start is called before the first frame update
    void Start()
    {
        int attempts = score.GetComponent<ItemDrop>().GetAttempts();
        float time = score.GetComponent<Timer>().GetTimer(); 

        apiClient.GetComponent<APIClient>().AddScore(attempts, time);  

        Debug.Log("intentos: " + attempts);
        Debug.Log("tiempo: "+ time);
    }
}

