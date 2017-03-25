using UnityEngine;
using System.Collections;

public class OneHitBrick : MonoBehaviour {
	
	public Sprite[] hitSprites;
	static public int breakableCount = 0;
	private int timesHit;
	private LevelManager levelManager;
	private bool isBreakable;
	
	
	void Start () {
		isBreakable = (this.tag == "Breakable");
		if(isBreakable){
			breakableCount++;
		}
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		timesHit = 0;
	}
	
	void OnCollisionEnter2D(Collision2D collision){
		if(isBreakable) {
		HandleHits ();
		}
	}
	
	void HandleHits (){
		timesHit++;
		int maxHits = hitSprites.Length + 1;
		if(timesHit >= maxHits){
			breakableCount--;
			levelManager.BrickDestroyed();
			Destroy (gameObject);
		} else {
		LoadSprites();
		}
	}
	
	void LoadSprites(){
		int spriteIndex = timesHit -1;
		if(hitSprites[spriteIndex]) {
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}
	
	void SimulateWin(){
		levelManager.LoadNextLevel();
	}
}
