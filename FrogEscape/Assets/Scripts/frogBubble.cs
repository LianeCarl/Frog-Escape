//	<Credits>
//	Jan Kenny Gomez
//	</Credits>

using UnityEngine;
using System.Collections;

public class frogBubble : MonoBehaviour {

	float startTime;
	// Use this for initialization
	void Start () {
		startTime = Time.time;

	}
	
	// Update is called once per frame
	void Update () {
	
		if((startTime + 5.0f) < Time.time){
			this.gameObject.SetActive(false);

		}
	}
}
