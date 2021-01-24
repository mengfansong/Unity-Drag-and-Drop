using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag2DSprite : MonoBehaviour
{
    [SerializeField] private bool isSelected;
    private void OnMouseDrag()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;
    }

    private void OnMouseEnter()
    {
        transform.localScale += Vector3.one * 0.07f;
    }

    private void OnMouseExit()
    {
        transform.localScale -= Vector3.one * 0.07f;
    }
}
