using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromotedManager : MonoBehaviour {
    public GameObject narrator;
    public AudioSource narratorVoice;
public AudioClip clip1;

    void Start()
    {
       
        narrator = GameObject.FindGameObjectWithTag("Narrator");
        narratorVoice = narrator.GetComponent<AudioSource>();
        StartCoroutine(AudioPlay());
    }
    IEnumerator AudioPlay()
    {

        narratorVoice.clip = clip1;
        yield return new WaitForSeconds(narratorVoice.clip.length);

    }
}
