 using UnityEngine;
 using System.Collections;
 using System;
 using UnityEngine.Events;
 using UnityEngine.EventSystems;

public class ButtonPlanet1 : MonoBehaviour
{
    public UnityEvent onMyOwnEvent;
     public void OnPointerClick (PointerEventData eventData)
     {
         onMyOwnEvent.Invoke();
         Debug.Log("Text: ");
     }

    public void MyOwnEventTriggered()
     {
         onMyOwnEvent.Invoke();
         Debug.Log("Text: ");
         
     }
}
