using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cumstom_Event;
using Event = Cumstom_Event.Event;
public class DoorCount : MonoBehaviour {
	[SerializeField] int Step = 0;
	[SerializeField] int LastStep;
	IsDoorVisible doorVisible;
	void Start(){
		doorVisible = FindObjectOfType<IsDoorVisible>();
		EventManager.Instance.Register<DoorSeenEvent>(DoorSeenClear);
	}
	void OnTriggerEnter(Collider collider){
		if(collider.tag == "Floor"){
			Step += doorVisible.IF_CONDITION_MEET?0:1;
		}
	}
	public void ClearStep(){
		Step = 0;
	}
	public int CurrentStep(){
		return Step;
	}
	public void DoorSeenClear(Event e){
		CompaireStep();
		ClearStep();
	}
	public void CompaireStep(){
		if(Step > LastStep){
			LastStep = Step;
			DoorMoveEvent tempEvent = new DoorMoveEvent();
			EventManager.Instance.FireEvent(tempEvent);
		}
		else{
			LastStep = 0;
			DoorResetEvent tempEvent = new DoorResetEvent();
			EventManager.Instance.FireEvent(tempEvent);
		}
	}
}
