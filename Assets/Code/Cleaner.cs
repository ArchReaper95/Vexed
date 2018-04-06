using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner : MonoBehaviour {

    void Awake()
    {
		GameObject character = GameObject.Find("Character");
        GameObject workLoop = GameObject.Find("WorkLoopTracker");
        Destroy(character);
        Destroy(workLoop);
    }
	
}
