using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnder :Interaction {
	public GameObject narrator;
	public AudioSource narratorVoice;
	public AudioClip clip1;
	public string sceneToLoad;

	void Start () {
		narrator = GameObject.FindGameObjectWithTag ("Narrator");
		narratorVoice = narrator.GetComponent<AudioSource> ();
	}

	IEnumerator AudioPlay () {
		narratorVoice.clip = clip1;
		narratorVoice.Play();
		yield return new WaitForSeconds(clip1.length);
	}

	public override void doTriggerEvent()
	{
		StartCoroutine(AudioPlay());
		Debug.Log("Loading scene " + sceneToLoad);
		SceneManager.LoadScene(sceneToLoad);
	}
}
