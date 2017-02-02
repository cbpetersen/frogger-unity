using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
	public int lvl;
	public Enemy[] EnemyTypes;
	public GameObject Croc;
	// Use this for initialization
	void Start () {
		Instantiate(Croc, new Vector3(1, 0.5f, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
