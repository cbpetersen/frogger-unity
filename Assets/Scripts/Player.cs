using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Player : BaseMonoBehaviour {
	public Vector2 HorizontalBoundery;
	public Vector2 VerticalBoundery;

	private bool alive;
	public float lastMove = 0f;

	private void Move() {
	
	}

	void Start () {
		base.Start ();
		alive = true;
	}

	void Update () {
		if (alive && Time.unscaledTime - gameConfig.TimeBetweenMoves > lastMove) {
			Vector3 v = Vector3.left * Input.GetAxisRaw ("Horizontal") * Time.deltaTime;
			if (v.x > 0) {
				if (transform.position.x > -2) {
					lastMove = Time.unscaledTime;		
					transform.Translate (new Vector2 (-gameConfig.PlayerMoveDistance, v.y));
				}
			} else if (v.x < 0) {
				if (transform.position.x < 2) {
					transform.Translate (new Vector2 (gameConfig.PlayerMoveDistance, v.y));
					lastMove = Time.unscaledTime;
				}
			}

			v = Vector3.left * Input.GetAxisRaw ("Vertical") * Time.deltaTime;
			if (v.x > 0) {
				if (transform.position.x > -2) {
					lastMove = Time.unscaledTime;		
					transform.Translate (new Vector2 (v.x, -gameConfig.PlayerMoveDistance));
				}
			} else if (v.x < 0) {
				if (transform.position.x < 2) {
					transform.Translate (new Vector2 (v.x, gameConfig.PlayerMoveDistance));
					lastMove = Time.unscaledTime;
				}
			}
		}
	}
}
