using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class redCube : masterCube
// INHERITANCE
{
    
    protected override void EventEffect()
    {
        changeColor();
        colorDisplay.text = "Red";
    }
    //POLYMORPHISIM
    protected override bool EventCondition()
    {
        return true;
    }
}
