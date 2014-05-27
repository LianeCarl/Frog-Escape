//	<Credits>
//	Jan Kenny Gomez
//	Liane Carl Lumaya - UI, audio
//	</Credits>


using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {
	RaycastHit hit;
	public int score = 0;
	public int highScore;
	private string scoreText = "0";
	private UITextInstance text1;
	public UIToolkit buttonsManager;
	float screenIdleCounter = 0;
	float countDownTimer = 5;
	public AudioClip Pop;
	public AudioSource Sound;

	public GameObject PauseWindow;

	public static destroy Instance;

	void Start () {
		var scaleFactor = ScaleFactor.GetScaleFactor();
		var text = new UIText( "VogueCyrBold_60_ffffff", "VogueCyrBold_60_ffffff.png" );
		text1 = text.addTextInstance( scoreText.ToString(), 0, 0, 2.5f , 2, Color.black);
		text1.positionFromTopLeft( 0.065f, 0.1f);

		highScore = PlayerPrefs.GetInt("High Score");

		if (AudioListener.volume == 1.0f)		
			AudioListener.volume = 0.5f;

	}

	void Awake(){
		Instance = this;
	}


	void Update () {
		var text = new UIText( "VogueCyrBold_60_ffffff", "VogueCyrBold_60_ffffff.png" );

		screenIdleCounter+=.01f;
		if(screenIdleCounter>=5f){
			countDownTimer-=0.01f;
		}
		if(countDownTimer<=0f)
			Application.LoadLevel("Game_Over");

		if(Input.GetMouseButtonDown(0)){
			screenIdleCounter = 0;
			countDownTimer = 5;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast (ray, out hit)){
				hit.collider.gameObject.SetActive(false);
				if(hit.collider.gameObject.tag == "frogBubble")
				{
					audio.clip = Pop;
					audio.Play ();
					score++;
				}
				if(hit.collider.gameObject.tag == "obstacleBubble"){
					if(score>highScore){
						highScore = score;
						PlayerPrefs.SetInt("High Score", highScore);
					}
					Application.LoadLevel("Game_Over");
				}
				scoreText = "" +score;
				text1.clear();
				text1 = text.addTextInstance( scoreText.ToString(), 0, 0, 2.5f, 2, Color.black);
				text1.positionFromTopLeft( 0.065f, 0.1f);
				}

			}


		if(Input.touchCount>0&&Input.GetTouch(0).phase == TouchPhase.Ended){
			
			screenIdleCounter = 0;
			countDownTimer = 5;

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast (ray, out hit)){
				hit.collider.gameObject.SetActive(false);
				if(hit.collider.gameObject.tag == "frogBubble")
				{
					audio.clip = Pop;
					audio.Play ();
					score++;
				}
				if(hit.collider.gameObject.tag == "obstacleBubble"){
					if(score>highScore){
						highScore = score;
						PlayerPrefs.SetInt("High Score", highScore);
					}
					Application.LoadLevel("Game_Over");
				}
				scoreText = "" +score;
				text1.clear();
				text1 = text.addTextInstance( scoreText.ToString(), 0, 0, 2.5f, 2, Color.black);
				
				text1.positionFromTopLeft(0.065f, 0.1f);
			}
			
		}

		Debug.Log (screenIdleCounter + " " + countDownTimer);
	}



	public int getScore(){
		return score;
	}


}

