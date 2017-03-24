using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance = null;
	
	void Awake(){
		if(instance != null){
			Destroy (gameObject);
			print("Duplicate Music Player destructing");
		}
	}
	void Start () {
		if(instance == null){
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
			Debug.Log ("Music Player initializing");
		}
	}
}
