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
    public void Red()
    {
        Move("Red");
    }
    public void Blue()
    {
        Move("Blue");
    }
    public void Green()
    {
        Move("Green");
    }
    public void Yellow()
    {
        Move("Yellow");
    }
    public void Cyan()
    {
        Move("Cyan");
    }
    public void Purple()
    {
        Move("Purple");
    }
    public void Orange()
    {
        Move("Orange");
    }
    void Move(string tileTag)
    {
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
}
