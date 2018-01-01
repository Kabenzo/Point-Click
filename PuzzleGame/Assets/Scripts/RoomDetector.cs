using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomDetector : MonoBehaviour {

	public int roomID;
	public GameObject player;
	private CameraController cam;
	public int Roomsize;


	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		cam = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<CameraController> ();
	}
	

	void Update () {
		float distance = Vector3.Distance(player.transform.position,transform.position);

		if (distance < Roomsize) {
			cam.target = gameObject.transform;
		}
	
	}
}
