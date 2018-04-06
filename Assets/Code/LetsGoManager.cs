using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetsGoManager : MonoBehaviour {
    public GameObject narrator;
	public GameObject phone;
	public AudioSource phoneAudio;
	public AudioSource narratorVoice;
	public AudioClip clip1;
	public AudioClip clip2;
	public AudioClip clip3;
	public AudioClip clip4;
	bool phonePlayed = false;
	// Use this for initialization
	void Start () {
        narrator = GameObject.FindGameObjectWithTag("Narrator");
        narratorVoice = narrator.GetComponent<AudioSource>();
		phone = GameObject.Find("handy");
		phoneAudio = phone.GetComponentInChildren<AudioSource>();
		StartCoroutine(AudioPlay());
	}
	
	// Update is called once per frame
	IEnumerator AudioPlay () {
		yield return new WaitForSeconds(narratorVoice.clip.length);
			phoneAudio.Play ();
		yield return new WaitForSeconds (phoneAudio.clip.length);
			narratorVoice.clip = clip1;
		narratorVoice.Play ();
	}
}
