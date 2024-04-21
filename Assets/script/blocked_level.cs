using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blocked_level : MonoBehaviour
{
    public Button[] lvlButtons;
    // Start is called before the first frame update
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 0); 
        Debug.Log(levelAt);        

        for (int i = 0;i < lvlButtons.Length; i++){
            if (i > levelAt){
                lvlButtons[i].interactable = false;            
            }        
        }
    }
 }
