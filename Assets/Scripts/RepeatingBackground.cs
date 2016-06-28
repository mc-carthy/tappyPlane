using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

	[Tooltip("How fast should the object move?")]
	public float scrollSpeed;

	/// <summary>
	/// How far to move until the image is off-screen.
	/// </summary>
	public const float scrollWidth = 8; // bgWidth / pixelsPerUnit

	private void FixedUpdate() {
		Vector3 pos = transform.position;

		// Move the object to the left
		pos.x -= scrollSpeed * Time.fixedDeltaTime;

		// Check if the object is off-screen
		if (transform.position.x < -scrollWidth) {
			Offscreen (ref pos);
		}

		// If not destroyed, set new position
		transform.position = pos;
	}

	/// <summary>
	/// Called when the object this is attached to is completely off-screen
	/// </summary>
	protected virtual void Offscreen(ref Vector3 pos) {
		// Move object to be off-screen on the right
		pos.x += 2 * scrollWidth;
	}
}
