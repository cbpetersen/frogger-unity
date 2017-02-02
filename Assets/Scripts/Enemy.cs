using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : BaseMonoBehaviour {
	private float movedAt = 0;
	private int moveDirection = 1;

	void Start () {
		base.Start ();
		moveDirection = Mathf.FloorToInt (Random.value) == 0 ? 1 : -1;
	}

	void Update () {
		if (Time.unscaledTime - gameConfig.TimeBetweenMoves > movedAt) {
			transform.Translate (new Vector2 (-gameConfig.EnemyMoveDistance, 0));
			movedAt = Time.unscaledTime;
		}
	}
}
