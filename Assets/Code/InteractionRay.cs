using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InteractionRay : MonoBehaviour {
    public Text textField;
    public Interaction colliderInteraction;
    // Use this for initialization   
    RaycastHit hit;
        
	void Start () {
       
        
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(gameObject.transform.position, transform.TransformDirection(Vector3.forward)*3, Color.red);
     if (Physics.Raycast(this.transform.position, this.transform.forward, out hit, 3.0f))
        {
            
            colliderInteraction = hit.collider.GetComponent<Interaction>();
            textField.text = (colliderInteraction.getText());
            if (Input.GetMouseButtonDown(0))
                hit.collider.GetComponent<Interaction>().doTriggerEvent();
        };
	}
}
