using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Tile // used by the tiles to point to the same tiles when matching
{
    public GameObject tileObj;
    public string type;
    public Tile(GameObject obj, string t)
    {
        tileObj = obj;
        type = t;
    }
}
public class GameManager : MonoBehaviour
{
    GameObject tile1 = null; // variales used to keep the first clicked tile
    GameObject tile2 = null; // variable used to keep the second clicked tile
	public GameObject[] tile; // array called tile
    List<GameObject> tileBank = new List<GameObject>();
	static int rows = 8; // how many rows in the match 3 (tutorial code)
	static int cols = 8; // how many columns in the match 3 (tutorial code)
	bool renewBoard = false;
	Tile[,] tiles = new Tile[cols, rows]; // A Array of objects for the tiles for the match 3 (tutorial code)
	void ShuffleList() // shuffles the list of tiles (tutorial code)
	{
		System.Random rand = new System.Random ();
		int r = tileBank.Count;
		while (r > 1) 
		{
			r--;
			int n = rand.Next(r + 1);
			GameObject val = tileBank [n];
			tileBank [n] = tileBank [r];
			tileBank [r] = val;
		}
	}
    void Start() // Use this for initialization
    {
        int numCopies = (rows * cols)/3;
        for (int i = 0; i < numCopies; i++) // creating copies so that we don't run out of copies 
        {
            for (int j = 0; j < tile.Length; j++)
            {
                GameObject o = (GameObject) Instantiate(tile[j], new Vector3(-10, -10, 0), tile[j].transform.rotation);
				o.SetActive (false);
				tileBank.Add(o);
            }
        }
		ShuffleList ();
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                Vector3 tilePos = new Vector3(c, r, 0);
				for (int n = 0; n < tileBank.Count; n++) 
				{
					GameObject o = tileBank [n];
					if (!o.activeSelf) 
					{
						o.transform.position = new Vector3 (tilePos.x, tilePos.y, tilePos.z);
						o.SetActive (true);
						tiles [c, r] = new Tile (o, o.name);
						n = tileBank.Count + 1;
					}
				}
            }
        }
	}
	void Update () // Update is called once per frame
    {
		CheckGrid ();
		if (Input.GetMouseButtonDown (0)) // casting a ray into the scene if the mouse was clicked for a hit on the first tile 
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D hit = Physics2D.GetRayIntersection (ray, 1000);
			if (hit) // makes the hit tile in the variable
			{
				tile1 = hit.collider.gameObject;
			}
		}
		else if(Input.GetMouseButtonUp(0)&& tile1) // casting a ray into the scene if the mouse was clicked for a hit on the second tile 
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D hit = Physics2D.GetRayIntersection (ray, 1000);
			if (hit) // makes the hit tile in the variable tile2
			{
				tile2 = hit.collider.gameObject;
			}
			if (tile1 && tile2) // runs if their are two tiles clicked
			{
				int horzDist = (int)Mathf.Abs (tile1.transform.position.x - tile2.transform.position.x);
				int vertDist = (int)Mathf.Abs (tile1.transform.position.y - tile2.transform.position.y);
				if (horzDist == 1 & vertDist == 0 || horzDist == 0 & vertDist == 1) // swaps the position of the tow hit tiles
				{
					Tile temp = tiles [(int)tile1.transform.position.x, (int)tile1.transform.position.y];
					tiles [(int)tile1.transform.position.x, (int)tile1.transform.position.y] = tiles [(int)tile2.transform.position.x, (int)tile2.transform.position.y];
					tiles [(int)tile2.transform.position.x, (int)tile2.transform.position.y] = temp; // code block is keeping track of the temp positions of the tiles in memory
					Vector3 tempPos = tile1.transform.position;
					tile1.transform.position = tile2.transform.position;
					tile2.transform.position = tempPos; // moves the second tile to the first position
					tile1 = null; // Resets the touched tile variable
					tile2 = null; // Resets the touched tile variable
				} 
				else 
				{
					GetComponent<AudioSource> ().Play (); // for audio, will add in second assessment
				}
			}
		}
	}
	void CheckGrid() // function for checking the grid for matches 
	{
		int counter = 1;
		for(int r = 0; r < rows; r++) // checks for coloums
		{
			counter = 1;
			for(int c = 1; c < cols; c++)
			{
				if (tiles [c, r] != null && tiles [c - 1, r] != null) // finds if they exist
				{
					if (tiles [c, r].type == tiles [c - 1, r].type) 
					{
						counter++;
					} 
					else // resets counter
					{
						counter = 1;	
					}
					if(counter == 3) // removes three in a row
					{
						if(tiles[c,r] != null)
						{
							tiles [c, r].tileObj.SetActive (false);
						}
						if(tiles[c-1,r] != null)
						{
							tiles [c-1, r].tileObj.SetActive (false);
						}
						if(tiles[c-2,r] != null)
						{
							tiles [c-2, r].tileObj.SetActive (false);
						}
						tiles [c, r] = null; //resets first tile reference
						tiles [c - 1, r] = null; //resets second tile reference
						tiles [c - 2, r] = null; //resets third tile reference
						renewBoard = true;
					}
				}
			}
		}
		for(int r = 1; r < cols; r++) // checks for rows
		{
			counter = 1;
			for(int c = 1; c < rows; c++)
			{
				if (tiles [c, r] != null && tiles [c - 1, r] != null) // finds if they exist
				{
					if (tiles [c, r].type == tiles [c - 1, r].type) {

					} 
					else // resets counter
					{
						counter = 1;	
					}
					if(counter == 3) // removes three in a row
					{
						if(tiles[c,r] != null)
						{
							tiles [c, r].tileObj.SetActive (false);
						}
						if(tiles[c-1,r] != null)
						{
							tiles [c-1, r].tileObj.SetActive (false);
						}
						if(tiles[c-2,r] != null)
						{
							tiles [c-2, r].tileObj.SetActive (false);
						}
						tiles [c, r] = null;
						tiles [c - 1, r] = null;
						tiles [c - 2, r] = null;
						renewBoard = true;
					}
				}
			}
		}
		if(renewBoard) // renews the board
		{
			RenewGrid ();
			renewBoard = false;
		}
	}
	void MoveCharacterOnGrid () // moves the character on the grid to the matching colour
	{
		
	}
	void RenewGrid() // renews the grid after a pair of three is taked away
	{
		bool anyMoved = false;
		ShuffleList ();
		for (int r = 1; r < rows; r++) 
		{
			for (int c = 0; c < cols; c++) 
			{
				if(r == rows-1 && tiles[c,r] == null)
				{
					Vector3 tilePos = new Vector3 (c, r, 0);
					for(int n = 0; n < tileBank.Count; n++)
					{
						GameObject o = tileBank [n];
						if(!o.activeSelf)
						{
							o.transform.position = new Vector3 (tilePos.x, tilePos.y, tilePos.z);
							o.SetActive (true);
							tiles [c, r] = new Tile (o, o.name);
							n = tileBank.Count + 1;
						}
					}
				}
				if (tiles [c, r] != null) 
				{
					if (tiles [c, r - 1] == null) 
					{
						tiles [c, r - 1] = tiles [c, r];
						tiles [c, r - 1].tileObj.transform.position = new Vector3 (c, r - 1, 0);
						tiles [c, r] = null;
						anyMoved = true;
					}
				}
			}
		}
		if (anyMoved) 
		{
			Invoke ("RenewGrid", 0.5f);
		}
	}
}