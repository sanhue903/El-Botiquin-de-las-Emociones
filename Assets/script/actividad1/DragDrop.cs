using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{    
    [SerializeField] private Canvas canvas;
    
    public bool isCorrectAnswer;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    private Vector2 startPosition;

    private void Awake(){
        rectTransform = GetComponent<RectTransform>();  
        canvasGroup = GetComponent<CanvasGroup>(); 

        startPosition = rectTransform.anchoredPosition; 
    }

    public void OnDrag(PointerEventData eventData){
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta/canvas.scaleFactor;    
    }

    public void OnBeginDrag(PointerEventData eventData){
        Debug.Log("OnBeginDrag");
        canvasGroup.alpha = .8f;
        canvasGroup.blocksRaycasts = false;
    }
    
    public void OnEndDrag(PointerEventData eventData){
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        rectTransform.anchoredPosition = startPosition;
        
    }

    public void OnPointerDown(PointerEventData eventData){
        Debug.Log("OnPointerDown");
    }
}
