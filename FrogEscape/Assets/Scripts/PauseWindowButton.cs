using UnityEngine;
using System.Collections;

public class PauseWindowButton : MonoBehaviour {

	public GameObject PauseWindow;

	public UIToolkit buttonsManager;

	// Use this for initialization
	void Start () {
		var scaleFactor = ScaleFactor.GetScaleFactor();
		
		var Resume = UIButton.create (buttonsManager, "RefreshNormal.psd", "RefreshActive.psd", 0, 0);
		Resume.setSize (Resume.width / scaleFactor, Resume.height / scaleFactor);
		Resume.positionFromTopLeft (0.5f, 0.31f);
		Resume.onTouchUpInside += sender => Application.LoadLevel ("GamePlay");

		var Replay = UIButton.create (buttonsManager, "PlaySmallNormal.psd", "PlaySmallActive.psd", 0, 0);
		Replay.setSize (Replay.width / scaleFactor, Replay.height / scaleFactor);
		Replay.positionFromTopLeft (0.5f, 0.44f);
//		Replay.onTouchUpInside += sender => destroy.Instance.enabled = true;

		var Home = UIButton.create (buttonsManager, "HomeNormal.psd", "HomeActive.psd", 0, 0);
		Home.setSize (Home.width / scaleFactor, Home.height / scaleFactor);
		Home.positionFromTopLeft (0.5f, 0.57f);
		Home.onTouchUpInside += sender =>  Application.LoadLevel ("MainMenu");
	}

}
