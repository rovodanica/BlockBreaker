using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public void LoadLevel(string name){
	//start = LevelManager.FindObjectOfType<>
	Debug.Log("Level load requested for:" + name);
	Application.LoadLevel(name);
	}
	
	public void QuitGame(string name){
	Debug.Log("Quit request");
	Application.Quit();
	}
	
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
