using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragFruit : MonoBehaviour
{
    private Vector2 startPos;
    [SerializeField] private Transform correctPos;
    [SerializeField] private bool isFinished=false;
    public float passRange = 0;

    Vector2 currentPos;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    private void OnMouseDrag()
    {
        if (!isFinished)
        {
            currentPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = currentPos;
        }           

        if (Vector2.Distance(currentPos, correctPos.position) <= passRange)
        {
            isFinished = true;
        }
    }

    private void OnMouseUp()
    {
        if (!isFinished)
        {
            transform.position = startPos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
