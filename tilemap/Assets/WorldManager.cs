using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour {

	World world;

	public int boards_wide = 10;
	public int boards_high = 10; 
	public int board_size = 10;

	public Sprite tile_sprite;

	// Use this for initialization
	void Start () {
		world = new World (boards_wide, boards_high, board_size);
		InitializeWorld ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void InitializeWorld(){
	
		for (int i = 0; i < boards_wide*board_size; i++) {
			for (int j = 0; j < boards_high*board_size; j++) {
				InitializeTile(i, j);
			}
		}

	}


	void InitializeTile(int x, int y){
		Tile tile = world.GetTileAt (x, y);
		GameObject tile_go = new GameObject ("Tile[" + x + "," + y + "]");
		tile_go.transform.position = new Vector3 (x, y, 0);

		//this is going to get very messy
		tile_go.transform.SetParent (this.transform);

		SpriteRenderer spriteRenderer = tile_go.AddComponent<SpriteRenderer> ();
		spriteRenderer.sprite = tile_sprite;

		int rand_val = Random.Range (0, 32);
		spriteRenderer.color = new Color (rand_val, rand_val, rand_val);
	}

}
