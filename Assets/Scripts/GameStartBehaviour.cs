using UnityEngine;

public class GameStartBehaviour : MonoBehaviour {

	private GameObject player;

	void Start() {
		player = GameObject.FindGameObjectWithTag("Player");
		player.GetComponent<Rigidbody2D> ().isKinematic = true;
	}

	void Update() {
		if ((Input.GetKeyUp (KeyCode.Space) || Input.GetMouseButtonDown (0))) {
			GameController controller = GetComponent<GameController> ();
			controller.InvokeRepeating ("CreateObstacle", 1.5f, 1.0f);

			player.GetComponent<Rigidbody2D> ().isKinematic = false;
			Destroy (this);
		}
	}
}
