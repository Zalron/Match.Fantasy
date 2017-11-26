using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DTiles // used by the tiles to point to the same tiles when matching (Not tutorial code)
{
    public GameObject tileObj;
    public string type;
    public DTiles(GameObject obj, string t)
    {
        tileObj = obj;
        type = t;
    }
}
public class PlayerManager : MonoBehaviour //(Not tutorial code)
{
    public GameObject[] DTiles;
	public GameObject PlayerSprite = null;
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
            }
            if (Physics2D.Raycast(transform.position, back, 1))
            {
                print("There is something back of the object!");
            }
            if (Physics2D.Raycast(transform.position, left, 1))
            {
                print("There is something to the left of the object!");
            }
            if (Physics2D.Raycast(transform.position, right, 1))
            {
                print("There is something to the right of the object!");
                if (CompareTag("Orange"))
                {
                    //Orange();
                }
                if (CompareTag("Red"))
                {

                }
                if (CompareTag("Blue"))
                {

                }
                if (CompareTag("Cyan"))
                {

                }
                if (CompareTag("Green"))
                {

                }
                if (CompareTag("Purple"))
                {

                }
                if (CompareTag("Yellow"))
                {

                }

            }
        }
    }
}
