//	<Credits>
//	Liane Carl Lumaya
//	</Credits>

using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{

	public AudioClip Click;
//	public AudioClip BG;
//	public AudioSource Yah;
	public bool Play = true;
	
	public UIToolkit NewManager;



	// Use this for initialization
	void Start () 
	{
		var scaleFactor = ScaleFactor.GetScaleFactor();

		// Checks if the audio volume is set at 50%
		if (AudioListener.volume == 0.5f)		
			AudioListener.volume = 1.0f;
		
		//		GUI.matrix = Get
//		var Play = UIButton.create(buttonsManager, "PlayNormal.png", "PlayActive.png", 0, 0);
//		Play.setSize(Play.width / scaleFactor -80 , Play.height / scaleFactor - 50);
//		Play.positionFromTopLeft(0.56f, 0.37f);
//		Play.touchDownSound = Click;
//		Play.onTouchUpInside += sender =>  Application.LoadLevel ("GamePlay");



		//Proceeds to GamePlay Scene
		var Play = UIButton.create(NewManager, "PlayNormal.psd", "PlayActive.psd", 0, 0);
		Play.setSize(Play.width / scaleFactor , Play.height / scaleFactor);
		Play.positionFromTopLeft(0.56f, 0.37f);
		Play.touchDownSound = Click;
		Play.onTouchUpInside += sender =>  Application.LoadLevel ("GamePlay");

	
		var HighScore = UIButton.create (NewManager, "HighScoreNormal.psd", "HighScoreActive.psd", 0, 0);
		HighScore.setSize(HighScore.width / scaleFactor, HighScore.height /scaleFactor);
		HighScore.positionFromTopLeft(0.586f, 0.235f);
		HighScore.onTouchUpInside += sender => Application.LoadLevel ("HighScore");
		HighScore.touchDownSound = Click;

	
		var Credits = UIButton.create (NewManager, "CreditsNormal.psd", "CreditsActive.psd", 0, 0);
		Credits.setSize (Credits.width / scaleFactor, Credits.height / scaleFactor );
		Credits.positionFromTopLeft(0.586f, 0.635f);
		Credits.onTouchUpInside += sender => Application.LoadLevel ("Credits");

		var AudioAll = UIToggleButton.create (NewManager,"BGMNormal.psd", "BGMActive.psd", "BGMClicked.psd", 0, 0);
		AudioAll.setSize(AudioAll.width / scaleFactor, AudioAll.height / scaleFactor);
		AudioAll.positionFromBottomRight(0.015f, 0.15f);
		AudioAll.onToggle += (sender, selected) => AudioListener.volume = selected ? 0.0f : 1.0f;
		AudioAll.selected = false;
		AudioAll.highlightedTouchOffsets = new UIEdgeOffsets (20);

		var _Help = UIButton.create (NewManager, "HelpNormal.psd", "HelpActive.psd", 0, 0);
		_Help.setSize (_Help.width / scaleFactor, _Help.height / scaleFactor );
		_Help.positionFromBottomRight(0.015f, 0.02f);
		_Help.onTouchUpInside += sender => Application.LoadLevel ("Tutorial");

	}

	void OnButtonSelect(UIButton obj)
	{
		//Resets the highscore recorded in the game
		PlayerPrefs.DeleteAll();

	}


	
	
	
}
