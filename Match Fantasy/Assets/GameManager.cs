using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class Tile
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
    Image tile1 = null;
    Image tile2 = null;
    public Image[] image;
    List<GameObject> tileBank = new List<GameObject>();
    static int rows = 8;
    static int cols = 8;
    Tile[,] tiles = new Tile[cols, rows];
    void Start() // Use this for initialization
    {
        int numCopies = (rows * cols) / 3;
        for (int i = 0; i < numCopies; i++)
        {
            for (int j = 0; j < tiles.Length; j++)
            {
                GameObject o = (GameObject) Instantiate(tiles[j], new Vector3(-10, -10, 0), tiles[j].transform.rotation);
            }
        }
        tileBank.Add(0);
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; r < cols; c++)
            {
                Vector3 tilePos = new Vector3(c, r, 0);
            }
        }
	}
	void Update () // Update is called once per frame
    {
		
	}
}
