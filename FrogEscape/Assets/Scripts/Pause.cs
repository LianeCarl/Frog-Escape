using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	//
	public int PauseBoolean = 0;
	public GameObject GamePause;
	public GameObject CrocBubble;
	public GameObject FrogBubble;
	public GameObject GamePauseButton;
	public GameObject window;

	public destroy destinstance;

//	public UIToolkit buttonsManager;

	public AudioClip Click;

	public static Pause Instance;
	void Start () {

//		var scaleFactor = ScaleFactor.GetScaleFactor();
//		var Reset = UIButton.create (buttonsManager, "RefreshNormal.psd", "RefreshActive.psd", 0, 0);
//		Reset.setSize(Reset.width / scaleFactor, Reset.height /scaleFactor);
//		Reset.positionFromTopLeft (0.55f, 0.22f);
//		//		Reset.onTouchDown += OnButtonSelect;
//		Reset.touchDownSound = Click;
	
	}

	void Awake(){
		Instance = this;
	}
	// Update is called once per frame


	void Update(){

		if(Input.GetKeyDown("p")){
			if(PauseBoolean == 0){
				Time.timeScale = 0;
				GamePause.SetActive(true);	//set the black screen active
				PauseBoolean = 1;
				destroy.Instance.enabled = false;

//				button.SetActive(false);
//				window.SetActive(true);


			}
			else if(PauseBoolean == 1){
				Time.timeScale = 1;
				GamePause.SetActive(false);	// inactivate the black screen
				PauseBoolean = 0;
				destroy.Instance.enabled = true;
//				button.SetActive(true);
//				window.SetActive(false);
			}
		}
	Debug.Log(PauseBoolean);

	}
}
