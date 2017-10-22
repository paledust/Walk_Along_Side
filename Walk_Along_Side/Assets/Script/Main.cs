using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
	[SerializeField] bool Hide_Cursor_Mode;

	// Use this for initialization
	void Awake(){
		Cursor.visible = Hide_Cursor_Mode;
		if(Hide_Cursor_Mode) Cursor.lockState = CursorLockMode.Locked;
	}
}
