using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	private Vector3 cameraTarget;
	public Transform target;


	void Awake () {
	}

	void Start () {
		
	}


	void FixedUpdate () {

		cameraTarget = new Vector3 (target.position.x + 20f, transform.position.y, target.position.z);
		transform.position = Vector3.Lerp (transform.position, cameraTarget, Time.deltaTime * 2);

	}
}
