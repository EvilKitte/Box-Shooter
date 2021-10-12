using UnityEngine;
using System.Collections;

public class PlayAgain : MonoBehaviour {

	// respond on collisions
	void OnCollisionEnter(Collision newCollision)
	{
		if (newCollision.gameObject.tag == "Projectile") {
			GameManager.gm.RestartGame();
		}
	}
}
