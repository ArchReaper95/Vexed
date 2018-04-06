using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TelephoneJumper : Interaction {
    public string sceneToLoad;
    public string sceneToLoad2;
    public string sceneToLoad3; 
    public GameObject workLoop;

    private void Awake()
    {
       workLoop = GameObject.Find("WorkLoopTracker");
    }
   

    
    public override void doTriggerEvent()
    {
        if (workLoop.GetComponent<WorkLoop>().getCounter() < 3)
            SceneManager.LoadScene(sceneToLoad);
        else if (workLoop.GetComponent<WorkLoop>().getPromoted())
            SceneManager.LoadScene(sceneToLoad3);

        else
            SceneManager.LoadScene(sceneToLoad2);

    }
}
