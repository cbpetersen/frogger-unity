using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Player : BaseMonoBehaviour {
	public Sprite[] sprites;
	public Vector2 HorizontalBoundery;
	public Vector2 VerticalBoundery;
	public float lastMove = 0f;

	private SpriteRenderer render;
	private bool alive;
	private int spriteIndex;

	private void Jump(int moveDirection) {
		this.spriteIndex = moveDirection;
	}

	void Start () {
		base.Start ();
		render = GetComponent<SpriteRenderer> ();
		alive = true;
	}

	void Update () {
		if (alive && Time.unscaledTime - gameConfig.TimeBetweenMoves > lastMove) {


			Vector3 v = Vector3.left * Input.GetAxisRaw ("Horizontal") * Time.deltaTime;
			if (v.x > 0) {
				if (transform.position.x > -3) {
					lastMove = Time.unscaledTime;
					transform.Translate (new Vector2 (-gameConfig.PlayerMoveDistance, v.y));
					render.sprite = sprites [7];
					spriteIndex = 7;
					return;
				}
			} else if (v.x < 0) {
				if (transform.position.x < 3) {
					transform.Translate (new Vector2 (gameConfig.PlayerMoveDistance, v.y));
					lastMove = Time.unscaledTime;
					render.sprite = sprites [3];
					spriteIndex = 3;
					return;
				}
			}

			v = Vector3.left * Input.GetAxisRaw ("Vertical") * Time.deltaTime;
			if (v.x > 0) {
				if (transform.position.y > -2) {
					lastMove = Time.unscaledTime;		
					transform.Translate (new Vector2 (v.x, -gameConfig.PlayerMoveDistance));
					render.sprite = sprites [5];
					spriteIndex = 5;
					return;
				}
			} else if (v.x < 0) {
				if (transform.position.y < 2) {
					transform.Translate (new Vector2 (v.x, gameConfig.PlayerMoveDistance));
					lastMove = Time.unscaledTime;
					render.sprite = sprites [1];
					spriteIndex = 1;
					return;
				}
			}

			if (spriteIndex % 2 == 1) {
				render.sprite = sprites [--spriteIndex];
			}
		}
	}
}
