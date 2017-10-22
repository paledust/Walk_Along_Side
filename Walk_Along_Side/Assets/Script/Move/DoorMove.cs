using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMove : MonoBehaviour {
	protected Vector3 StartDistance;
	protected Vector3 FixedDistance;
	[SerializeField] Transform player;
	// Use this for initialization
	void Start () {
		StartDistance = transform.position - player.position;
		FixedDistance = StartDistance;
	}
	
	// Update is called once per frame
	void Update () {
		MovingAlong();
	}
	protected void MovingAlong(){
		transform.position = player.position + FixedDistance;
	}
	public void SetNewDistance(Vector3 Distance){
		FixedDistance = Distance;
	}
	public void ResetDistance(){
		FixedDistance = StartDistance;
	}
	public void MinusDistance(){
		FixedDistance += Vector3.back * 10.0f;
	}
	public float Distance(){
		return FixedDistance.magnitude;
	}
}
