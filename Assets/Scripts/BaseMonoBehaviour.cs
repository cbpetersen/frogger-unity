using UnityEngine;
using System.Collections;

public abstract class BaseMonoBehaviour : MonoBehaviour
{
	protected static GameConfig gameConfig;

	protected void Start () 
	{
		if (gameConfig == null) {
			gameConfig = GameObject.Find ("Game").GetComponent<GameConfig> ();
		}
	}
}
