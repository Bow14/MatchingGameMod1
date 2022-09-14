using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableBehaviour : MonoBehaviour
{
    //    //AnthonyRomrell Module  Matching game 1 code

    
    private Camera cameraObj;
    public bool dragabble;
    public Vector3 position, offset;
    
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        dragabble = true;
        yield return new WaitForFixedUpdate();


        while (dragabble)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToViewportPoint(Input.mousePosition) + offset;
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        dragabble = false;
    }
}
