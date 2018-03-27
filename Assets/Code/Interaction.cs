using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {
    public string interactionText;
    public string getText()
    {
        return interactionText;
    }
    public virtual void doTriggerEvent()
    {
        Debug.Log("oops");
    }
}
