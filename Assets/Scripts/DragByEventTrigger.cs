using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragByEventTrigger : MonoBehaviour
{
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DragMethod()
    {
        transform.position = Input.mousePosition;
    }

    public void EndDragMethod()
    {
        GameObject slotG0 = GameObject.Find("Slot");
        float dist = Vector3.Distance(transform.position, slotG0.transform.position);

        if (dist < 100)
        {
            transform.position = slotG0.transform.position;
        }
        else
        {
            transform.position = startPos;
        }
    }
}
