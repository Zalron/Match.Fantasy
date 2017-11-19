using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerManager : GameManager
{
    public GameObject[] duegeonTiles;
    public string type = "";
	void Start () // Use this for initialization
	{
		
	}
	void Update () // Update is called once per frame
	{

	}
	public void SetType(string type)
	{
        if (duegeonTiles[0].name == type)
        {

        }
	}
}
