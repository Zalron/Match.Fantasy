using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class dTile // used by the tiles to point to the same tiles when matching
{
	public GameObject tileObj;
	public string type;
	public dTile(GameObject obj, string t)
	{
		tileObj = obj;
		type = t;
	}
}
public class DungeonGameManager : MonoBehaviour 
{
	GameObject[] dungeonTiles;
	void Start()
	{
		
	}
	void Update () // Update is called once per frame
	{
		
	}
	void MoveCharacterOnGrid () // moves the character on the grid to the matching colour (not tutorial code block)
	{
		
	}
}
