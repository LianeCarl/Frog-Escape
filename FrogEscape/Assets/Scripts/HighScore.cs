//	<Credits>
//	Liane Carl Lumaya
//	</Credits>

using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {

	public AudioClip Click;
	public bool Play = true;
	private int AudioState;
	public UIToolkit buttonsManager;
	public UIToolkit textManager;
	
	private string highScoreText = "0";
	private UITextInstance text1;

	
	// Use this for initialization
	void Start () 
	{
		var scaleFactor = ScaleFactor.GetScaleFactor();


//		GameAudio mute = gameObject.GetComponent<GameAudio>();
//		mute.turnMusicOff();
	
		// A U D I O   S E T T I N G S
//		var AudioAll = UIToggleButton.create ("BGMNormal.psd", "BGMActive.psd", "BGMClicked.psd", 0, 0);
//		AudioAll.setSize(AudioAll.width / scaleFactor, AudioAll.height / scaleFactor);
//		AudioAll.positionFromTopLeft (0.4f, 0.20f);
//		AudioAll.onToggle += (sender, selected) => AudioListener.volume = selected ? 0.0f : 1.0f;
////		AudioAll.onToggle += (sender, turnOff) => AudioAll.selected = turnOff;
//		AudioAll.selected = false;
//		AudioAll.highlightedTouchOffsets = new UIEdgeOffsets (20);
//
//		//Displays current highscore
//		var text = new UIText( textManager, "VogueCyrBold_60_ffffff", "VogueCyrBold_60_ffffff.png" );
//		highScoreText = " " +destroy.Instance.highScore;
//		text1 = text.addTextInstance( highScoreText.ToString(), 0, 0, 1.5f, 2, Color.green);
//
////		var text = new UIText(textManager, "VogueCyrBold_60_ffffff", "VogueCyrBold_60_ffffff.png" );
////		text1 = text.addTextInstance("0", 0, 0, 3f, 2, Color.green);
//		text1.positionFromTopLeft (0.36f, 0.45f);



		// S C O R E   R E S E T T E R
		var Reset = UIButton.create (buttonsManager, "ResetScoreNormal.psd", "ResetScoreActive.psd", 0, 0);
		Reset.setSize(Reset.width / scaleFactor, Reset.height /scaleFactor);
		Reset.positionFromTopLeft (0.55f, 0.22f);
		Reset.onTouchDown += OnButtonSelect;
		Reset.touchDownSound = Click;
		


		// R E T U R N  /  H O M E
		var Home = UIButton.create(buttonsManager, "BackNormal.psd", "BackActive.psd", 0, 0);
		Home.setSize(Home.width / scaleFactor, Home.height / scaleFactor);
		Home.positionFromTopLeft(0.70f, 0.02f);
		Home.onTouchUpInside += sender => Application.LoadLevel ("MainMenu");
		Home.touchDownSound = Click;

		
	}
	
	void OnButtonSelect(UIButton obj)
	{
		PlayerPrefs.DeleteAll();
		
	}

	void OnToggleSelect(UIToggleButton sender)
	{
		if (sender.selected == false)
			AudioState = 1;
		else
			AudioState = 0;

		PlayerPrefs.SetInt("Audio State", AudioState);
	}

//	soundButton.onToggle += (sender, selected) => AudioListener.volume = selected ? 1.0f : 0.0f;


//
//	void OnMute()
//	{
//		AudioState = 1;
//		if (AudioState == 1)
//
//
//
//	}

}
