using UnityEngine;

public class GameController : MonoBehaviour {

	[HideInInspector] // Hides var below
	/// <summary>
	/// Affects how fast objects with the
	/// RepeatingBackground script move.
	/// </summary>
	public static float speedModifier;

	[Header("Obstacle Information")]

	[Tooltip("The obstacle that we will spawn")]
	public GameObject obstacleReference;

	[Tooltip("Minimum Y value used for obstacle")]
	public float obstacleMinY = -1.3f;

	[Tooltip("Maximum Y value used for obstacle")]
	public float obstacleMaxY = 1.3f;

	// Use this for initialization
	void Start ()
	{
		speedModifier = 1.0f;
		gameObject.AddComponent<GameStartBehaviour> ();
	}

	/// <summary>
	/// Creates the obstacle an initializes its position.
	/// </summary>
	void CreateObstacle()
	{
		// Spawn offscreen with a random Y
		Instantiate(obstacleReference,
			new Vector3(RepeatingBackground.scrollWidth, 
				Random.Range(obstacleMinY, obstacleMaxY), 0.0f), 
			Quaternion.identity);
	}

}