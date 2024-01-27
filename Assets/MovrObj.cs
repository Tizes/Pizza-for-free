using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class MovrObj : MonoBehaviour
{
    Vector2 diffrence = Vector2.zero;
    private void OnMouseDown()
    {
        diffrence = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
        Debug.Log(diffrence);
        
    }
    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - diffrence;
    }
}
