using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerBehaviour : MonoBehaviour {

	[Tooltip("The force which is added when the player jumps")]
	public Vector2 jumpForce = new Vector2(0, 300);

	/// <summary>
	/// If we've been hit, we can no longer jump
	/// </summary>

	private bool beenHit;
	private Rigidbody2D rigidBody2d;

	void Start() {
		beenHit = false;
		rigidBody2d = GetComponent<Rigidbody2D> ();
	}

	void LateUpdate() {
		// Check to see if we should jump
		if ((Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonDown(0)) && !beenHit) {
			// Reset velocity & jump up
			rigidBody2d.velocity = Vector2.zero;
			rigidBody2d.AddForce (jumpForce);
		}
	}

	/// <summary>
	/// If we collide with any other collider, then we crash
	/// </summary>
	/// <param name="other">Who we collided with</param>

	void OnCollisionEnter2D(Collision2D other) {
		// We've now been hit
		beenHit = true;
		GameController.speedModifier = 0.0f;

		// The animation should no longer play
		GetComponent<Animator>().speed = 0.0f;
	}
}
