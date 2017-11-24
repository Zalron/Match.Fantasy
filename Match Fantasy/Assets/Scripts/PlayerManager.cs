using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DTiles
{
	public GameObject dTileObj;
	public string dType;
	public DTiles(GameObject dObj, string dT)
	{
		dTileObj = dObj;
		dType = dT;
	}
}
public class PlayerManager : MonoBehaviour
{
	static int rows = 8; // how many rows in the match 3 (tutorial code)
	static int cols = 8; // how many columns in the match 3 (tutorial code)
	public GameObject[] DTiles;
	public GameObject PlayerSprite = null;
	public void RedTriangle()
	{
		print ("Red");
		//PlayerSprite.transform.position = new Vector3 (-2,1,0);
		PlayerSprite.transform.position = DTiles[0].transform.position;
	}
	public void BlueSquare()
	{
		print ("Blue");
		PlayerSprite.transform.position = new Vector3 (-3,0,0);
		PlayerSprite.transform.position = DTiles[2].transform.position;
	}
	public void GreenCircle()
	{
		print ("Green");
		PlayerSprite.transform.position = new Vector3 (-2,0,0);
		PlayerSprite.transform.position = DTiles[1].transform.position;
	}
	public void Yellow()
	{
		print ("Yellow");
		PlayerSprite.transform.position = new Vector3 (-3,1,0);
		PlayerSprite.transform.position = DTiles[0].transform.position;
	}
	public void Cyan()
	{
		print ("Cyan");
		PlayerSprite.transform.position = new Vector3 (-2,2,0);
		PlayerSprite.transform.position = DTiles[0].transform.position;
	}
	public void Purple()
	{
		print ("Purple");
		PlayerSprite.transform.position = new Vector3 (-3,3,0);
		PlayerSprite.transform.position = DTiles[0].transform.position;
	}
	public void Orange()
	{
		print ("Orange");
		PlayerSprite.transform.position = new Vector3 (-2,3,0);
		PlayerSprite.transform.position = DTiles[0].transform.position;
	}
}
