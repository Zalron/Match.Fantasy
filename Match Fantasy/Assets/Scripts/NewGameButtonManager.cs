using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NewGameButtonManager : MonoBehaviour 
{
	public Button newGameButton;
	public void LoadScene()
	{
		SceneManager.LoadScene ("Main Scene");
	}
}
