using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolManager : MonoBehaviour {
	public GameObject narrator;
	public AudioSource narratorVoice;
	public AudioClip clip1;
	public AudioClip clip2;
	public AudioClip clip3;
	void Start () {
		narrator = GameObject.FindGameObjectWithTag ("Narrator");
		narratorVoice = narrator.GetComponent<AudioSource> ();
		StartCoroutine (AudioPlay ());
	}
	IEnumerator AudioPlay () {
		narratorVoice.clip = clip1;
		narratorVoice.Play();
		yield return new WaitForSeconds(clip1.length);
	}
}
