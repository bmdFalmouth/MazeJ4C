using UnityEngine;
using System.Collections;

public class VoteScreenGUI : MonoBehaviour {
	
	public Texture2D avatar1;
	public Texture2D avatar2;
	public Texture2D avatar3;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		GUI.Label (new Rect(30, 30, 64, 64), avatar1);
		GUI.Label (new Rect(35, 10, 50, 20), "Player 2");
		
		GUI.Label (new Rect(30, 124, 64, 64), avatar2);
		GUI.Label (new Rect(35, 104, 50, 20), "Player 3");
		
		GUI.Label (new Rect(30, 218, 64, 64), avatar3);
		GUI.Label (new Rect(35, 198, 50, 20), "Player 4");
		
		if (GUI.Button (new Rect(100, 30, 50, 50), "positive")) {
			
		}
		if (GUI.Button (new Rect(170, 30, 50, 50), "neutral")) {
			
		}
		if (GUI.Button (new Rect(240, 30, 50, 50), "negative")) {
			
		}
		
		if (GUI.Button (new Rect(100, 124, 50, 50), "positive")) {
			
		}
		if (GUI.Button (new Rect(170, 124, 50, 50), "neutral")) {
			
		}
		if (GUI.Button (new Rect(240, 124, 50, 50), "negative")) {
			
		}
		
		if (GUI.Button (new Rect(100, 218, 50, 50), "positive")) {
			
		}
		if (GUI.Button (new Rect(170, 218, 50, 50), "neutral")) {
			
		}
		if (GUI.Button (new Rect(240, 218, 50, 50), "negative")) {
			
		}
	}
}
