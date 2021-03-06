using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarehouseManager : MonoBehaviour {
	public GameObject tracker;
	public GameObject narrator;
	public AudioSource narratorVoice;
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
		if (tracker.GetComponent<WorkLoop>().getCounter() == 1)
			narratorVoice.clip = clip1;
		else if (tracker.GetComponent<WorkLoop>().getCounter() == 2)
			narratorVoice.clip = clip2;
		else
			narratorVoice.clip = clip3;
			narratorVoice.Play();
			yield return new WaitForSeconds(clip1.length);
	}
}
