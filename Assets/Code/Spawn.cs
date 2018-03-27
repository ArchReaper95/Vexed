using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private void Awake()
    {
        GameObject character = GameObject.Find("Character");
        character.transform.SetPositionAndRotation(gameObject.transform.position, gameObject.transform.rotation);
    }
}