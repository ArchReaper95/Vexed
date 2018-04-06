using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSetter : MonoBehaviour {
	public GameObject narrator;
	public AudioSource narratorVoice;
	public GameObject tracker;
	public AudioClip clip1;
	public AudioClip clip2;
	public AudioClip clip3;
	void Start () {
		tracker = GameObject.FindGameObjectWithTag ("Tracker");
		narrator = GameObject.FindGameObjectWithTag ("Narrator");
		narratorVoice = narrator.GetComponent<AudioSource> ();
		StartCoroutine (AudioPlay ());
	}
	IEnumerator AudioPlay () {
		if (tracker.GetComponent<WorkLoop>().getApartmentTracker() == 1)
			narratorVoice.clip = clip1;
		else if (tracker.GetComponent<WorkLoop>().getApartmentTracker() == 2)
			narratorVoice.clip = clip2;
		else
			narratorVoice.clip = clip3;
		
		narratorVoice.Play();
		yield return new WaitForSeconds(narratorVoice.clip.length);
	}
}
