using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDrop : MonoBehaviour, IDropHandler
{
    private int attempts;

    public AudioSource[] loseAudios;
    public GameObject[] setInactive;
    public GameObject[] setActive;

    public void Start(){
        attempts = 0;    
    }

    public void OnDrop(PointerEventData eventData){
        Debug.Log("OnDrop"); 

        if(eventData.pointerDrag == null){
            return;    
        }

        attempts++;  
        Debug.Log(attempts);   

        if(!eventData.pointerDrag.GetComponent<DragDrop>().isCorrectAnswer){              
            loseAudios[Random.Range(0,loseAudios.Length)].Play();  
            return;
        }     

        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

        foreach (GameObject active in setActive){
            active.SetActive(true);            
        } 

        foreach (GameObject inactive in setInactive){
            inactive.SetActive(false);
        }
    }

    public int GetAttempts(){
        return attempts;    
    }
}
