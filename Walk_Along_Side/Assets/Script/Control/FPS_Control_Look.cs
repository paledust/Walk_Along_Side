using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Control_Look : MonoBehaviour {
	float Yaw;
	float Pitch;
	private Quaternion tempRotation;
	protected Quaternion startRotation;
	[Range(0,100.0f)]
	[SerializeField] float SmoothSpeed;
	// Use this for initialization
	void Start () {
		Yaw = 0.0f;
		Pitch = 0.0f;
		startRotation = transform.rotation;
		tempRotation = transform.rotation;
		
	}
	
	// Update is called once per frame
	void Update () {
		Yaw +=  Input.GetAxis("Mouse X");
		Pitch +=  Input.GetAxis("Mouse Y");

		RotateControl(Yaw,Pitch,SmoothSpeed);
	}

	public void RotateControl(float AngleX, float AngleY, float _Speed){
		Quaternion CamRotationAngle = FromAxisToRotate(AngleX, Vector3.up) * FromAxisToRotate(AngleY, Vector3.right);
		tempRotation = Quaternion.Lerp(tempRotation, CamRotationAngle, Time.deltaTime * _Speed);
		if(Quaternion.Angle(tempRotation, CamRotationAngle) <= 0.01f)
			tempRotation = CamRotationAngle;

		transform.rotation = startRotation * Quaternion.Euler(tempRotation.eulerAngles.x, tempRotation.eulerAngles.y, transform.rotation.eulerAngles.z);
	}
	protected Quaternion FromAxisToRotate(float AngleAxis, Vector3 RotateAxis){
		return Quaternion.AngleAxis(AngleAxis,RotateAxis);
	}
}
