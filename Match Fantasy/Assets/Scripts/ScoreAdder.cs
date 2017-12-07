using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAdder : MonoBehaviour //(Not tutorial code)
{
    public Text scoreCounter = null;
    public Text moveCounter = null;
    
	void Start () // Use this for initialization
    {
		
	}

	void Update () // Update is called once per frame
    {
		scoreCounter.text = "Score: " + GameManager.scoreCounterNumber.ToString();
		moveCounter.text = "Moves: " + GameManager.moveCounterNumber.ToString ();
	}
//    public void ScoreCounter(int scoreCounterNumber)
//    {
//    }
}
