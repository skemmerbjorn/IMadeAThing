using UnityEngine;
using System.Collections;

public class health : MonoBehaviour {
	float healthpoints = 100.0f;

	// Use this for initialization
	void Start () {
	
	}


	void OnGUI()
	{
		guiText.text = healthpoints.ToString();
		GUI.Window (0, new Rect (10, 10, 200, 100), MyWindow, "My Window");
	}

	void MyWindow(int WindowID)
	{
		if (GUI.Button(new Rect (10, 10, 50, 50), "Damage"))
			healthpoints -= 10;
	}
}
