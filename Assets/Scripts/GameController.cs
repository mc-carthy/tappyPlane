using UnityEngine;

public class GameController : MonoBehaviour {

	[HideInInspector] // Hides var below
	/// <summary>
	/// Affects how fast objects with the
	/// RepeatingBackground script move.
	/// </summary>
	public static float speedModifier;

	// Use this for initialization
	void Start ()
	{
		speedModifier = 1.0f;
	}

}