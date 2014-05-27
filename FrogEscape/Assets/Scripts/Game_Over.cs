//<Credits>
//
//	Liane Carl Lumaya
//	UI - Text and Buttons
//	Audio
//	
//
//	Jan Kenny Gomez
//	Score Display from previous scene
//
//</Credits>

using UnityEngine;
using System.Collections;

public class Game_Over : MonoBehaviour {
	
	//	private destroy instance;
	public UIToolkit buttonsManager;
	public UIToolkit textManager;
	private UITextInstance text1;
	private UITextInstance text2;
	private UITextInstance text3;
	private UITextInstance text4;
	private UITextInstance text5;
	private string scoreText = "0";
	private string highScoreText = "0";
	public AudioClip Horn;
	public AudioSource Sound;

	public int checkHighScore;
	
	// Use this for initialization
	void Start () 
	{



		audio.clip = Horn;
		audio.Play ();

		checkHighScore = PlayerPrefs.GetInt("Check High Score");

		if (AudioListener.volume == 0.5f)		
			AudioListener.volume = 1.0f;
		
		//		<Summary>
//		Display high score and score from game
//		Check if current score is higher than the recorded highscore
//		Blue for high score
//		Black for current score
//		</Summary>


		var text = new UIText( textManager, "VogueCyrBold_60_ffffff", "VogueCyrBold_60_ffffff.png" );
		scoreText = "" +destroy.Instance.score;
		highScoreText = " " +destroy.Instance.highScore;
		//text1.clear();
		if(destroy.Instance.highScore>checkHighScore){
			checkHighScore = destroy.Instance.highScore;
			PlayerPrefs.SetInt("Check High Score", checkHighScore);
			text3 = text.addTextInstance( "New", 0, 0, .5f, 2, Color.red);
			text3.positionFromTopLeft (0.53f, 0.185f);
//			text3.pixelsFromTop( 180, -94);
		}


		text1 = text.addTextInstance( scoreText.ToString(), 0, 0, 2f , 2, Color.black);
		text1.positionFromTopLeft (0.38f, 0.45f);
//		text1.pixelsFromTop( 150, 80);
		text2 = text.addTextInstance( highScoreText.ToString(), 0, 0, 1.5f, 2, Color.blue);
		text2.positionFromTopLeft (0.53f, 0.55f);
//		text2.pixelsFromTop( 190, 77);
//		text4 = text.addTextInstance( "High Score", 0, 0, 1.5f, 2, Color.blue);
//		text4.positionFromTopLeft (0.45f, 0.234f);
////		text4.pixelsFromTop(190, -15);
//		text5 = text.addTextInstance( "Score", 0, 0, 1.5f, 2, Color.black);
//		text5.positionFromTopLeft (0.38f, 0.235f);
////		text5.pixelsFromTop(150, -50);



		var scaleFactor = ScaleFactor.GetScaleFactor ();
		var PlayAgain = UIButton.create (buttonsManager, "RefreshNormal.psd", "RefreshActive.psd", 0, 0);
		PlayAgain.positionFromTopLeft (0.60f, 0.38f);
		PlayAgain.setSize (PlayAgain.width / scaleFactor, PlayAgain.height / scaleFactor);
		PlayAgain.onTouchUpInside += sender => Application.LoadLevel ("GamePlay");
		
		
		var Home = UIButton.create (buttonsManager, "HomeNormal.psd", "HomeActive.psd", 0, 0);
		Home.positionFromTopLeft (0.60f, 0.52f);
		Home.setSize (Home.width / scaleFactor, Home.height / scaleFactor);
		Home.onTouchUpInside += sender => Debug.Log("Touched!");
		Home.onTouchUpInside += sender => Application.LoadLevel ("MainMenu");
		Debug.Log(destroy.Instance.score + " " + destroy.Instance.highScore);
	}

	
}
