//	<Summary>
//	Audio Settings
//	</Summary>



using UnityEngine;
using System.Collections;

public class GameAudio : MonoBehaviour {

	private static GameAudio instance;

	void Awake()
	{
		if (instance != null && instance != this)
		{
			Destroy(this.gameObject);
			return;
		}
		else
		{
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}
	
	void Start()
	{
		if (!instance.audio.isPlaying)
		{
			audio.Play();
			audio.loop = true;
		}
	}
	
	public void turnMusicOff()
	{
		if (instance != null)
		{
			if (instance.audio.isPlaying)
			instance.audio.Stop();
			Destroy(this.gameObject);
			instance = null;
		}
	}



//	public AudioClip Click;
//	public AudioClip BMXA;
//	public AudioClip SFXA;
//	private AudioSource BG;
//	private AudioSource SF;
//	private AudioSource CL;
//
//	AudioSource AddAudio(AudioClip clip, bool loop, bool playAwake, float volume){
//		AudioSource newAudio = gameObject.AddComponent <AudioSource>();
//		newAudio.clip = clip;
//		newAudio.loop = loop;
//		newAudio.playOnAwake = playAwake;
//		newAudio.volume = volume;
//		return newAudio;
//
//	}
//
//	void Awake()
//	{
//		audio.clip = BMXA;
//		DontDestroyOnLoad(transform.gameObject);	
//		
//	}
//
//	void Update()
//	{
//	
//		Destroy (transform.gameObject);
//
//	}


}