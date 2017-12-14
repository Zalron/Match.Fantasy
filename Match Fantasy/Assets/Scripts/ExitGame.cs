using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ExitGame : MonoBehaviour 
{
	public Button exitButton;
	public void ExitTheGame()
	{
		Application.Quit();
	}
}
