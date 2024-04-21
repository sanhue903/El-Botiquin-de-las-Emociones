using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropItem : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public GameObject congratulations;
    public GameObject next_button;
    public AudioSource audioincorrecto1;
    public AudioSource audioincorrecto2;

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragHandler.itemDragging;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
            next_button.SetActive(true);
            congratulations.SetActive(true);
            audioincorrecto1.Pause();
            audioincorrecto2.Pause();

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;


        }
    }
}
