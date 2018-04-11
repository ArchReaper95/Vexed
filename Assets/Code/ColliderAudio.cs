using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderAudio : MonoBehaviour {
    public GameObject narrator;
    public AudioSource narratorVoice;
    public AudioClip clip1;
    private void OnTriggerEnter(Collider other)
    {
        narrator = GameObject.FindGameObjectWithTag ("Narrator");
		narratorVoice = narrator.GetComponent<AudioSource> ();
        narratorVoice.clip = clip1;
        narratorVoice.Play();
        Destroy(gameObject);
    }
}
