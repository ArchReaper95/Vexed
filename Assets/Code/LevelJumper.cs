using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelJumper : Interaction {
    public string sceneToLoad;
    public override void doTriggerEvent()
    {
        Debug.Log("Loading scene " + sceneToLoad);
        SceneManager.LoadScene(sceneToLoad);
    }
}
