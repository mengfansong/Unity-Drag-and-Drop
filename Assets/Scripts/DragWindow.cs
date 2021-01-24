using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragWindow : MonoBehaviour,IDragHandler,IBeginDragHandler
{
    [SerializeField]
    private RectTransform panelRectrans;

    public void OnBeginDrag(PointerEventData eventData)
    {
        panelRectrans.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        panelRectrans.anchoredPosition += eventData.delta;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
