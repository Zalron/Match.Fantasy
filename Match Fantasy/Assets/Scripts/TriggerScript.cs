using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameObject pm;
	void Start () // Use this for initialization
    {
		
	}
	void Update () // Update is called once per frame
    {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EditorSceneManager.LoadScene("Main Scene");
    }
}
