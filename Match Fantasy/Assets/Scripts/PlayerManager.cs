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
	public GameObject[] DTiles;
	public GameObject PlayerSprite = null;
	public void Red()
	{
		print ("Red");
		PlayerSprite.transform.position = DTiles[0].transform.position;
	}
	public void Blue()
	{
		print ("Blue");
		PlayerSprite.transform.position = DTiles[3].transform.position;
	}
	public void Green()
	{
		print ("Green");
		PlayerSprite.transform.position = DTiles[1].transform.position;
	}
	public void Yellow()
	{
		print ("Yellow");
		PlayerSprite.transform.position = DTiles[5].transform.position;
	}
	public void Cyan()
	{
		print ("Cyan");
		PlayerSprite.transform.position = DTiles[6].transform.position;
	}
	public void Purple()
	{
		print ("Purple");
		PlayerSprite.transform.position = DTiles[4].transform.position;
	}
	public void Orange()
	{
		print ("Orange");
		PlayerSprite.transform.position = DTiles[2].transform.position;
	}
}
