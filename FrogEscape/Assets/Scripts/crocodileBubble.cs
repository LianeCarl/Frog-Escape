//	<Credits>
//	Jan Kenny Gomez
//	</Credits>


using UnityEngine;
using System.Collections;

public class crocodileBubble : MonoBehaviour {
	
	float startTime;
	// Use this for initialization
	void Start () {
		startTime = Time.time;
//		gameObject.transform.renderer.material.color = Color.red;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if((startTime + 3.0f) < Time.time){
			this.gameObject.SetActive(false);
		}
	}
}
