using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionManager : MonoBehaviour {
	List<DoorMoveCondition> DoorConditions = new List<DoorMoveCondition>();
	// Update is called once per frame
	void Start(){
		DoorConditions.AddRange(FindObjectsOfType<DoorMoveCondition>());
	}
	void Update () {
		foreach(DoorMoveCondition condition in DoorConditions){
			condition.CheckCondition();
			if(condition.IF_CONDITION_MEET){
				condition.AfterPass();
			}
		}
	}
}
