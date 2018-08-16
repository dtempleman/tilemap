using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board{

	private Tile[,] tiles;

	public Board (int x, int y){
		tiles = new Tile[x, y];
		for (int i = 0; i < x; i++) {
			for (int j = 0; j < y; j++) {
				tiles [i, j] = new Tile (i, j, this);
			}
		}
	}


}
