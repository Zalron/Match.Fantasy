using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DTiles // used by the tiles to point to the same tiles when matching (Not tutorial code)
{
    public GameObject tileObj;
    public string type;
    public DTiles(GameObject dobj, string t)
    {
        tileObj = dobj;
        type = t;
    }
}
public class PlayerManager : MonoBehaviour //(Not tutorial code)
{
    public GameObject[] DTiles;
	public GameObject PlayerSprite = null;
	string[] nsew = new string[4];

	int contains(string value)
	{
		if (nsew [0] == value) 
		{
			return 0;
		}
		if (nsew [1] == value) 
		{
			return 1;
		}
		if (nsew [2] == value) 
		{
			return 2;
		}
		if (nsew [3] == value) 
		{
			return 3;
		}
		return -1;
	}
	public void Red()
	{
		print ("Red");
		PlayerSprite.transform.position = DTiles[0].transform.position;
        CheckPosition();
    }
	public void Blue()
	{
		print ("Blue");
		PlayerSprite.transform.position = DTiles[3].transform.position;
        CheckPosition();
    }
	public void Green()
	{
		print ("Green");
		PlayerSprite.transform.position = DTiles[1].transform.position;
        CheckPosition();
    }
	public void Yellow()
	{
		print ("Yellow");
		PlayerSprite.transform.position = DTiles[5].transform.position;
        CheckPosition();
    }
	public void Cyan()
	{
		print ("Cyan");
		PlayerSprite.transform.position = DTiles[6].transform.position;
        CheckPosition();
    }
    public void Purple()
	{
		print ("Purple");
		PlayerSprite.transform.position = DTiles[4].transform.position;
        CheckPosition();
    }
	public void Orange()
	{
		print ("Orange");
		PlayerSprite.transform.position = DTiles[2].transform.position;
        CheckPosition();
    }
    public void CheckPosition()
    {
        {
            Vector3 up = PlayerSprite.transform.TransformDirection(Vector3.up);
            Vector3 back = PlayerSprite.transform.TransformDirection(Vector3.down);
            Vector3 left = PlayerSprite.transform.TransformDirection(Vector3.left);
            Vector3 right = PlayerSprite.transform.TransformDirection(Vector3.right);
            if (Physics2D.Raycast(transform.position, up, 1))
            {
                print("There is something in front of the object!");
				nsew [0] = RaycastHit2D;
            }
            if (Physics2D.Raycast(transform.position, back, 1))
            {
                print("There is something back of the object!");
				nsew [1] = RaycastHit2D;
            }
            if (Physics2D.Raycast(transform.position, left, 1))
            {
                print("There is something to the left of the object!");
				nsew [2] = RaycastHit2D;
            }
            if (Physics2D.Raycast(transform.position, right, 1))
            {
				print ("There is something to the right of the object!");
				nsew [3] = RaycastHit2D;
            }
        }
    }
}
