using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [Header("Timer Settings")]
    private float currentTime = 0;

    void Update()
    {
        currentTime += Time.deltaTime;
    }

    public float GetTimer(){
        return currentTime;    
    }
}
