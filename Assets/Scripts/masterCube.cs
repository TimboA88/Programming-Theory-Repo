using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class masterCube : MonoBehaviour
{
    public GameObject plane;
    public TextMeshProUGUI colorDisplay;
    public Material thisColor
    {
        get { return thisTrueColor; }
        set
        {
            if (value != gameObject.GetComponent<Renderer>().material)
            {
                Debug.Log("The Material does not match the object.");
            }
            else
            {
                thisTrueColor = value;
            }
        }
    }
    //ENCAPSULATION
    protected Material thisTrueColor;

    protected virtual void RunEvent()
    {
        if (EventCondition())
        {
            EventEffect();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        RunEvent();
    }
    protected virtual bool EventCondition()
    {

        return true;
    }

    protected virtual void EventEffect()
    {
        return;
    }

    protected void changeColor()
    {
        thisColor = GetComponent<Renderer>().material;
        plane.gameObject.GetComponent<Renderer>().material = thisColor;
    }

}
