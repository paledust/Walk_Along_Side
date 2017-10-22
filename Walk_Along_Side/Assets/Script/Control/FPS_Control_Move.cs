using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Control_Move : MonoBehaviour {
	[Range(0.0f, 10.0f)]
	[SerializeField] float MaxSpeed = 0.0f;
	[Range(0.0f, 10.0f)]
	[SerializeField] float accelaration = 1.0f;
	float tempSpeed;
	// Update is called once per frame
	void Start(){
		tempSpeed = 0.0f;
	}
	void Update () {
		if(Input.GetKey(KeyCode.Space)){
			tempSpeed = Mathf.Lerp(tempSpeed, MaxSpeed, Time.deltaTime * accelaration);
		}
		else{
			tempSpeed = Mathf.Lerp(tempSpeed, 0.0f, Time.deltaTime * accelaration);
		}

		transform.position += Vector3.forward * tempSpeed * 0.1f;

	}
}
