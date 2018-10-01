using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbol : MonoBehaviour {
    AudioSource audioSource;

    
	// Use this for initialization
	void Start () {

        audioSource= GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
        Destroy(other.gameObject);
    }
}
