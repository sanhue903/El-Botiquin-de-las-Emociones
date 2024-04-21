using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlock_level : MonoBehaviour
{
    public int level;    
    
// Start is called before the first frame update
    void Start()
    {
        if (level > PlayerPrefs.GetInt("levelAt")){
            PlayerPrefs.SetInt("levelAt", level);        
        }
    }

}
