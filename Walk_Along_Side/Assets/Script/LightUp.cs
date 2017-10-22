using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightUp : MonoBehaviour {
	[Range(0,10)]
	[SerializeField] float changeRate;
	protected bool IF_IN;
	Color tempColor;
	void Start(){
		tempColor = Color.black;
	}
	void Update(){
		if(IF_IN){
			tempColor = Color.Lerp(tempColor,new Color(0.6f,0.6f,0.6f,1.0f), Time.deltaTime * changeRate);
		}
		else{
			tempColor = Color.Lerp(tempColor,Color.black, Time.deltaTime * changeRate);
		}
		GetComponent<Renderer>().material.SetColor("_EmissionColor", tempColor);
		GetComponent<Renderer>().material.color = tempColor;
	}
	void OnTriggerStay(Collider collider){
		if(collider.tag == "MainCamera" && !IF_IN){
			IF_IN = true;
		}
	}
	void OnTriggerExit(Collider collider){
		if(collider.tag == "MainCamera"){
			IF_IN = false;
		}
	}
}
