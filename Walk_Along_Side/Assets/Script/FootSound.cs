using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSound : MonoBehaviour {
	[SerializeField] AudioClip walkClip;
	// Use this for initialization
	void OnTriggerEnter(Collider collider){
		if(collider.tag == "MainCamera"){
			AudioSource audioSource = collider.GetComponent<AudioSource>();
			audioSource.pitch = Random.Range(0.8f, 1.2f);
			audioSource.PlayOneShot(walkClip);
		}
	}
}
