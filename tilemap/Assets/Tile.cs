using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile {
	// the 2d coordinates of the tile
	private int x;
	private int y;
	// if a tile is "walkable", the pathfinding can use it for the path
	private bool walkable;
	//the board that the tile is a part of
	private Board board;

	// creates a tile with the coordinates of x,y
	// if walkable is not set it will default to true
	public Tile (int x, int y, Board board, bool walkable = true){
		this.x = x;
		this.y = y;
		this.board = board;
		this.walkable = walkable;
	
	}

	//returns a description of the tile
	public override string ToString(){
		if (walkable)
			return "tile[" + this.x + "," + this.y + "] is walkable.";
		return "tile[" + this.x + "," + this.y + "] is not walkable.";
	}
}
