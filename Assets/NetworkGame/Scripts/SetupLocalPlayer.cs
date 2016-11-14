using UnityEngine;
using System.Collections;
using UnityEngine.Networking; // added


public class SetupLocalPlayer : NetworkBehaviour { // sun classed from network

	string pname = "player";

	void onGUI()
	{
		pname = GUI.TextField(new Rect (25, Screen.height - 40, 100, 30), pname);
	}

	// Use this for initialization
	void Start () {
		if(isLocalPlayer) // localPlayer from NetworkBehavior
		{
			GetComponent<DriverControl>().enabled = true;
		
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(isLocalPlayer)
		{
			TextMesh[] tMesh = this.GetComponentsInChildren<TextMesh>();
			tMesh[0].text = pname;

		}
	}
}
