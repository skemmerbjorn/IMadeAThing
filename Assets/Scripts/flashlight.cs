using UnityEngine;
using System.Collections;

public class flashlight : MonoBehaviour {
	public bool on = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if(Input.GetKeyDown(KeyCode.F))
			on = !on;
		if(on)
			light.enabled = true;
		else if(!on)
			light.enabled = false;

	}
}
