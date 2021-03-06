using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WorkLoop : Interaction {
    public int loopCounter;
	public int apartmentTracker;
    public bool promoted = false;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        loopCounter = 0;
		apartmentTracker = 0;
    }

    private void OnLevelWasLoaded(int level)
    {
		if (level == 3)
			loopCounter++;
		if (level == 10)
			apartmentTracker++;
        if (level == 2)
            promoted = true;
    }

    public int getCounter()
    {
        return loopCounter;
    }
	public int getApartmentTracker()
	{
		return apartmentTracker;
	}
    public bool getPromoted()
    {
        return promoted;
    }
}
