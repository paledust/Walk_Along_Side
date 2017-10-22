using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMoveCondition : MonoBehaviour {
	protected bool if_Condition_Meet;
	public bool IF_CONDITION_MEET{get {return if_Condition_Meet;}}
	public virtual void Pass(){
		if_Condition_Meet = true;
	}
	public virtual void Failed(){
		if_Condition_Meet = false;
	}
	public virtual void CheckCondition(){
	}
	public virtual void AfterPass(){
	}
}
