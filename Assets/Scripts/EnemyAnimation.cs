using UnityEngine;
using System.Collections;

public class EnemyAnimation : BaseMonoBehaviour
{
	private SpriteRenderer render;
	private int spriteIndex;
	private float movedAt = 0;
	public Sprite[] sprites;

	void Start ()
	{
		render = GetComponent<SpriteRenderer> ();
	}

	void Update ()
	{
		if (Time.unscaledTime - gameConfig.TimeBetweenMoves > movedAt) {
			spriteIndex = ++spriteIndex % sprites.Length;
			movedAt = Time.unscaledTime;
			render.sprite = sprites [spriteIndex];
		}
	}
}

