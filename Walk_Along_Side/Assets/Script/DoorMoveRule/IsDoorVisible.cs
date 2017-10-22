using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsDoorVisible : DoorMoveCondition {
	[SerializeField] GameObject Door;
	Renderer m_renderer;
	void Start(){
		m_renderer = Door.GetComponent<Renderer>();
	}
	public override void CheckCondition(){
		if(m_renderer.IsVisibleFrom(Camera.main)){
			if(!if_Condition_Meet) {
				Pass();
			}
		}
		else{
			if(if_Condition_Meet) {
				Failed();
			}
		}
	}
	public override void Pass(){
		base.Pass();
		Cumstom_Event.DoorSeenEvent tempEvent = new Cumstom_Event.DoorSeenEvent();
		EventManager.Instance.FireEvent(tempEvent);
	}

}
