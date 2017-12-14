using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameObject pm;
	private void OnTriggerEnter2D(Collider2D collision)
    {
		//print ("Reached the end");
        SceneManager.LoadScene("End Scene");
    }
}