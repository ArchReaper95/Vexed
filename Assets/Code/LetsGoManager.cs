using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetsGoManager : MonoBehaviour {
    public GameObject narrator; 
	// Use this for initialization
	void Awake () {
        narrator = GameObject.FindGameObjectWithTag("Narrator");
        AudioSource narratorVoice = narrator.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
