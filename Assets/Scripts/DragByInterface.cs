using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragByInterface : MonoBehaviour,IBeginDragHandler,IEndDragHandler,IDragHandler
{
    private RectTransform rectTrans;
    private CanvasGroup canvasGroup;
    [SerializeField]
    private Canvas canvas;

    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("Begin drag");
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("The Drag");
        rectTrans.anchoredPosition += eventData.delta / canvas.scaleFactor;                  //eventData.delta是Vector2结构体类型


    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("End drag");
        canvasGroup.blocksRaycasts = true;
    }
   

    // Start is called before the first frame update
    void Start()
    {
        rectTrans = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
