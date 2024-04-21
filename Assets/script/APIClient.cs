using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct Score{
    public int attempts;
    public float time;

    public Score(int scoreAttempts, float scoreTime){
        attempts = scoreAttempts;
        time = scoreTime;       
    }
}

public class APIClient : MonoBehaviour
{
    //cambiar string por estructura correspondiente
    private List<Score> scores;

    public void Start(){
        scores = new List<Score>();    
    }
 
    public void AddScore(int attempts,float time){
        scores.Add(new Score(attempts, time));
    }

    public void SendScores(){
        //utilizar api  
        return;  
    }
}
