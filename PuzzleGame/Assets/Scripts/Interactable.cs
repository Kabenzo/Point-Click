using UnityEngine;

public class Interactable : MonoBehaviour {
	
	public float radius = 6f;

	bool isFocus = false;
	Transform player;

	bool hasInteracted = false;

	public virtual void Interact() {
		//This is where the interaction code goes
		Debug.Log ("Interacting with " + transform.name);
	}


	void Update () {

		if (isFocus && !hasInteracted) {

			float distance = Vector3.Distance (player.position, transform.position);

			if (distance <= radius) {
				Interact ();
				hasInteracted = true;
			}
		}
	}

	public void OnFocus (Transform playerTransform) {
		isFocus = true;
		player = playerTransform;
		hasInteracted = false;
	}

	public void OnDeFocus () {
		isFocus = false;
		player = null;
		hasInteracted = false;

	}


}
