using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cumstom_Event;
using Event = Cumstom_Event.Event;

public class DoorManager : MonoBehaviour {
	DoorMove doorMove;
	public void Start(){
		doorMove = FindObjectOfType<DoorMove>();
		EventManager.Instance.Register<DoorMoveEvent>(MoveDoorHandler);
		EventManager.Instance.Register<DoorResetEvent>(ResetDoorHandler);
	}
	public void MoveDoorHandler(Event e){
		doorMove.MinusDistance();
	}
	public void ResetDoorHandler(Event e){
		doorMove.ResetDistance();
	}
	public void UnregisterDoorReset(){
		EventManager.Instance.UnRegister<DoorResetEvent>(ResetDoorHandler);
	}
	public void UnregisterDoorMove(){
		EventManager.Instance.UnRegister<DoorMoveEvent>(MoveDoorHandler);
	}
}
