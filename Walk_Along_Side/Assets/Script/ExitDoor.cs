using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : MonoBehaviour {
	IsDoorVisible doorVisible;
	FPS_Control_Move control_Move;
	DoorMove doorMove;
	public void Start(){
		doorVisible = FindObjectOfType<IsDoorVisible>();
		control_Move = FindObjectOfType<FPS_Control_Move>();
		doorMove = FindObjectOfType<DoorMove>();
	}
	void OnTriggerEnter(Collider collider){
		if(collider.tag == "MainCamera"){
			if(doorVisible.IF_CONDITION_MEET){
				doorMove.enabled = false;
				control_Move.enabled = false;
				transform.position += Vector3.forward * 2.0f;
				StartCoroutine(ExitGame());
			}
		}
	}
	IEnumerator ExitGame(){
		yield return new WaitForSeconds(2.0f);
		Debug.Log("Exit");
		Application.Quit();
		UnityEditor.EditorApplication.isPlaying = false;
		yield return null;
	}
}
