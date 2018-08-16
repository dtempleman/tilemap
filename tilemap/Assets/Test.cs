using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Tile t = new Tile (0, 0, new Board(1,1));
		Board b = new Board (10, 10);
		Debug.Log (t);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
