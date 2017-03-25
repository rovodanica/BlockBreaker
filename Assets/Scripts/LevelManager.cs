using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public void LoadLevel(string name){
		Debug.Log("Level load requested for:" + name);
		Application.LoadLevel(name);
	}
	
	public void QuitGame(string name){
		Debug.Log("Quit request");
		Application.Quit();
	}
	
	public void LoadNextLevel(){
		OneHitBrick.breakableCount = 0;
		Application.LoadLevel(Application.loadedLevel + 1);
		print ("LoadNextLevel called");
	}
	
	public void BrickDestroyed(){
		if(OneHitBrick.breakableCount <= 0){
			LoadNextLevel();
		}
	}
}
