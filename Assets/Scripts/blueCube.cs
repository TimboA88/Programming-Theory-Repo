using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueCube : masterCube
// INHERITANCE
{

    protected override void EventEffect()
    {
        changeColor();
        colorDisplay.text = "Blue";
    }
    //POLYMORPHISIM
    protected override bool EventCondition()
    {
        return true;
    }
}
