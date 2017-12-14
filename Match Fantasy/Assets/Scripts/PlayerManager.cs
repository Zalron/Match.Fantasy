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
    public string[] nsew = new string[4];
    void Start()
    {
        UpdateNsew();
    }
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    Red();
        //}
        //if (Input.GetKeyDown(KeyCode.B))
        //{
        //    Blue();
        //}
        //if (Input.GetKeyDown(KeyCode.G))
        //{
        //    Green();
        //}
        //if (Input.GetKeyDown(KeyCode.Y))
        //{
        //    Yellow();
        //}
        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    Cyan();
        //}
        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    Purple();
        //}
        //if (Input.GetKeyDown(KeyCode.O))
        //{
        //    Orange();
        //}
    }
    public void Red()
    {
        //print ("Red");
        //PlayerSprite.transform.position = DTiles[0].transform.position;
        //CheckPosition();
        Move("Red");

    }
    public void Blue()
    {
        //print ("Blue");
        //PlayerSprite.transform.position = DTiles[3].transform.position;
        //CheckPosition();
        Move("Blue");

    }
    public void Green()
    {
        //print ("Green");
        //PlayerSprite.transform.position = DTiles[1].transform.position;
        //CheckPosition();
        Move("Green");
    }
    public void Yellow()
    {
        //print ("Yellow");
        //PlayerSprite.transform.position = DTiles[5].transform.position;
        //CheckPosition();
        Move("Yellow");
    }
    public void Cyan()
    {
        //print ("Cyan");
        //PlayerSprite.transform.position = DTiles[6].transform.position;
        //CheckPosition();
        Move("Cyan");
    }
    public void Purple()
    {
        //print ("Purple");
        //PlayerSprite.transform.position = DTiles[4].transform.position;
        //CheckPosition();
        Move("Purple");
    }
    public void Orange()
    {
        //print ("Orange");
        //PlayerSprite.transform.position = DTiles[2].transform.position;
        //CheckPosition();
        Move("Orange");
    }
    void Move(string tileTag)
    {
        //print("Move(" + tileTag + ")");
        TryToMovePlayer(tileTag);
        UpdateNsew();
    }
    int CheckNsew(string tileTag)
    {
        if (nsew[0] == tileTag)
        {
            return 0;
        }
        if (nsew[1] == tileTag)
        {
            return 1;
        }
        if (nsew[2] == tileTag)
        {
            return 2;
        }
        if (nsew[3] == tileTag)
        {
            return 3;
        }
        return -1;
    }

    void TryToMovePlayer(string tileTag)
    {
        switch (CheckNsew(tileTag))
        {
            case 0:
                Debug.Log("PlayerManager.TryToMovePlayer() - Player moving north");
                transform.Translate(Vector2.up);
                break;
            case 1:
                Debug.Log("PlayerManager.TryToMovePlayer() - Player moving south");
                transform.Translate(Vector2.down);
                break;
            case 2:
                Debug.Log("PlayerManager.TryToMovePlayer() - Player moving east");
                transform.Translate(Vector2.right);
                break;
            case 3:
                Debug.Log("PlayerManager.TryToMovePlayer() - Player moving west");
                transform.Translate(Vector2.left);
                break;
            case -1:
                Debug.Log("PlayerManager.TryToMovePlayer() - Player cannot move this turn");
                break;
            default:
                Debug.LogError("PlayerManager.TryToMovePlayer() - invalid direction");
                break;
        }
    }
    void UpdateNsew()
    {
        nsew[0] = UpdateDirection(Vector2.up);
        nsew[1] = UpdateDirection(Vector2.down);
        nsew[2] = UpdateDirection(Vector2.right);
        nsew[3] = UpdateDirection(Vector2.left);
    }
    string UpdateDirection(Vector2 offset)
    {
        RaycastHit2D hit;
        hit = Physics2D.Raycast((Vector2)transform.position + offset, Vector2.zero);
        if (hit)
        {
            return hit.collider.tag;
        }
        else
        {
            return "";
        }
    }
    //public void CheckPosition()
    //{
    //    {
    //        Vector3 up = PlayerSprite.transform.TransformDirection(Vector3.up);
    //        Vector3 back = PlayerSprite.transform.TransformDirection(Vector3.down);
    //        Vector3 left = PlayerSprite.transform.TransformDirection(Vector3.left);
    //        Vector3 right = PlayerSprite.transform.TransformDirection(Vector3.right);
    //        if (Physics2D.Raycast(transform.position, up, 1))
    //        {
    //            print("There is something in front of the object!");
    //        }
    //        if (Physics2D.Raycast(transform.position, back, 1))
    //        {
    //            print("There is something back of the object!");
    //        }
    //        if (Physics2D.Raycast(transform.position, left, 1))
    //        {
    //            print("There is something to the left of the object!");
    //        }
    //        if (Physics2D.Raycast(transform.position, right, 1))
    //        {
    //            print("There is something to the right of the object!");
    //            if (CompareTag("Orange"))
    //            {
    //                Orange();
    //            }
    //            if (CompareTag("Red"))
    //            {

    //            }
    //            if (CompareTag("Blue"))
    //            {

    //            }
    //            if (CompareTag("Cyan"))
    //            {

    //            }
    //            if (CompareTag("Green"))
    //            {

    //            }
    //            if (CompareTag("Purple"))
    //            {

    //            }
    //            if (CompareTag("Yellow"))
    //            {

    //            }

    //        }
    //    }
    //}
}
