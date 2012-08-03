using UnityEngine;
using System.Collections;

public class SupportGUI : MonoBehaviour {
	
	public string arrow;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		if (GUI.Button(new Rect(Screen.width / 2 - 210, Screen.height - 50, 100, 50), "Up")) {
			arrow = "up";
			Debug.Log("up");
		}
		
		if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height - 50, 100, 50), "Down")) {
			arrow = "down";
			Debug.Log("down");
		}
		
		if (GUI.Button(new Rect(Screen.width / 2 + 10, Screen.height - 50, 100, 50), "Left")) {
			arrow = "left";
			Debug.Log("left");
		}
		
		if (GUI.Button(new Rect(Screen.width / 2 + 120, Screen.height - 50, 100, 50), "Right")) {
			arrow = "right";
			Debug.Log("right");
		}
	}
}
