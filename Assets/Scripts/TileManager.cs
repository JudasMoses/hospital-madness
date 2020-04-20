using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileManager : MonoBehaviour
{
	public static TileManager instance;

	private void Awake()
	{
		if (instance == null)
		{
			instance = gameObject.GetComponent<TileManager>();
		}
	}




	public int difficulty;


	// Tilemaps
	public Tilemap Corridor;
	public Tilemap Props;

	// Tiles
	public Tile floorTile;
}
