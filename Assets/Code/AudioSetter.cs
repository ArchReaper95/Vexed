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
    public AudioClip clip4;
    public AudioClip clip5;
    public GameObject phone;
    public AudioSource phoneAudio;
    void Start () {
		tracker = GameObject.FindGameObjectWithTag ("Tracker");
		narrator = GameObject.FindGameObjectWithTag ("Narrator");
		narratorVoice = narrator.GetComponent<AudioSource> ();
		StartCoroutine (AudioPlay ());
	}
    IEnumerator AudioPlay() {
        if (tracker.GetComponent<WorkLoop>().getApartmentTracker() == 1)
        {
            narratorVoice.clip = clip1;
        narratorVoice.Play();
        yield return new WaitForSeconds(narratorVoice.clip.length);
        }
		else if (tracker.GetComponent<WorkLoop>().getApartmentTracker() == 2)
        {
            narratorVoice.clip = clip2;
            narratorVoice.Play();
            yield return new WaitForSeconds(narratorVoice.clip.length);
        }
        else
            narratorVoice.clip = clip3;
		narratorVoice.Play();
		yield return new WaitForSeconds(narratorVoice.clip.length);
        phoneAudio = phone.GetComponent<AudioSource>();
        phoneAudio.Play();
        yield return new WaitForSeconds(narratorVoice.clip.length);
        phoneAudio.clip = clip4;
        phoneAudio.Play();
        yield return new WaitForSeconds(narratorVoice.clip.length);
        narratorVoice.clip = clip5;
        narratorVoice.Play();
}
}


