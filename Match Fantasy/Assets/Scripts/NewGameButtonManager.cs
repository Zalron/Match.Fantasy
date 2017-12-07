using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;
public class NewGameButtonManager : MonoBehaviour 
{
	public Button newGameButton;
	public void LoadScene()
	{
		EditorSceneManager.LoadScene ("Main Scene");
	}
}
