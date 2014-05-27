//	<Credits>
//	Christian Noel Mascariñas
//	</Credits>

//	<Summary>
//	Overpowers prime31's scaleFactor
//	</Summary>

using UnityEngine;
using System.Collections;

public class ScaleFactor : MonoBehaviour {

	public static float scaleFactor;

	private Matrix4x4 guiMatrix;
	private Vector3 guiScale;

	void Start ()
	{
		guiScale = new Vector3 (Screen.width/ 384, Screen.height / 512, 1.0f);

		guiMatrix = Matrix4x4.TRS (Vector3.zero, Quaternion.identity, guiScale);
	}

	public static float GetScaleFactor() {
		if (scaleFactor == 0) {
			int normalWidth = 384;
			int normalHeight = 512;


			var tempWidth = normalWidth * UI.scaleFactor;
			var tempHeight = normalHeight * UI.scaleFactor;

			float factorX = tempWidth / (float)Screen.width;
			float factorY = tempHeight / (float)Screen.height;

			
			scaleFactor = Mathf.Max(factorX, factorY);
		
		} 
		return scaleFactor;
	}

	Matrix4x4 GetGUIMatrix ()
	{
		return guiMatrix;

	}


	
}
