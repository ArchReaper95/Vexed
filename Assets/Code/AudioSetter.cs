using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSetter : MonoBehaviour {
    public AudioSource narrator;
    public AudioClip nextClip;
    private void Awake()
    {
        GameObject character = GameObject.Find("Character");
        narrator = character.GetComponentInChildren<AudioSource>();
        narrator.clip = nextClip;
    }
}
