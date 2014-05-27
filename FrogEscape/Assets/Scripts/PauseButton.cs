using UnityEngine;
using System.Collections;

public class PauseButton : MonoBehaviour {

	public UIToolkit buttonsManager;

	// Use this for initialization
	void Start () {
	
		var scaleFactor = ScaleFactor.GetScaleFactor();

		var Pause = UIButton.create (buttonsManager, "PauseNormal.psd", "PauseActive.psd", 0, 0);
		Pause.setSize (Pause.width / scaleFactor, Pause.height / scaleFactor);
		Pause.positionFromTopRight (0.02f, 0.02f);
		Pause.onTouchUpInside += sender =>  Application.LoadLevel ("HighScore");


	}
	

}
