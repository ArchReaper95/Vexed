using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        gameObject.transform.position = other.transform.position;
    }
}
