using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : Interaction {
    private Light myLight;
    void Awake()
    {
       myLight = this.gameObject.GetComponentInChildren<Light>();
    }
    // Use this for initialization
    public override void doTriggerEvent()
    {
        myLight.enabled = !myLight.enabled;
    }
}
