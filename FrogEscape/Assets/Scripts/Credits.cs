//	<Credits>
//	Liane Carl Lumaya
//	</Credits>

using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {
	public AudioClip Click;
	public bool Play = true;

	void Start()
	{
		var scaleFactor = ScaleFactor.GetScaleFactor();

		var Credits = UIButton.create("BackNormal.psd", "BackActive.psd", 0, 0);
		Credits.setSize(Credits.width / scaleFactor, Credits.height / scaleFactor);
		Credits.positionFromBottomLeft(0.01f, 0.01f);
		Credits.touchDownSound = Click;
		Credits.onTouchUpInside += sender =>  Application.LoadLevel ("MainMenu");

	}

}
