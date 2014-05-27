using UnityEngine;
using System.Collections;

public class GuiScale : MonoBehaviour {

	private float nativeWidth = 1536;
	private float nativeHeight = 2048;

	
	private Matrix4x4 guiMatrix;
	private Vector3 guiScale;

	void Start ()
	{
		guiScale = new Vector3 (Screen.width/ nativeWidth, Screen.height / nativeHeight, 1.0f);
		
		guiMatrix = Matrix4x4.TRS (Vector3.zero, Quaternion.identity, guiScale);
	}
	
	Matrix4x4 GetGUIMatrix ()
	{
		return guiMatrix;
		
	}
	

}
