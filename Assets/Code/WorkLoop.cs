using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WorkLoop : Interaction {
    public int loopCounter;
    public bool promoted = false;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        loopCounter = 0;
    }

    private void OnLevelWasLoaded(int level)
    {
        if (loopCounter < 6)
            loopCounter++;
        if (level == 2)
            promoted = true;
    }

    public int getCounter()
    {
        return loopCounter;
    }
    public bool getPromoted()
    {
        return promoted;
    }
}
