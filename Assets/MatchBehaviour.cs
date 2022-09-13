using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    //AnthonyRomrell Module  Matching game 1 code
    public ID idObj;
    public UnityEvent matchEvent, NoMatchEvent;
    public void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDcontatinerBehavior>();
        if (tempObj == null) 
            return;
            
            
        var otherID = tempObj.idObj;
        
        otherID = other.GetComponent<IDcontatinerBehavior>().idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
           NoMatchEvent.Invoke();
        }
    }
}
