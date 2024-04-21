using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; //recalcar la libreria importar interfaz

public class DragHandler : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler //interfaces
{
    public static GameObject itemDragging; 


    Vector3 startPosition;
    Transform startParent;
    Transform dragParent;


    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;

    }
    
    public void OnBeginDrag(PointerEventData eventData) //se llama solo una vez
    {
        Debug.Log("empieza arrastra objeto");
        itemDragging = gameObject;

        startPosition = transform.position;
        startParent = transform.parent;
        transform.SetParent(dragParent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("arrasta objeto");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("termina arrastrar objeto");
        itemDragging = null;

        if (transform.parent == dragParent)
        {
            //transform.position = startPosition;
            transform.SetParent(startParent);

        }
    }

}


