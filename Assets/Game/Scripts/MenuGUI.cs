using UnityEngine;
using System.Collections;

public class MenuGUI : MonoBehaviour {
	
	
	static public Texture2D playerAvatar;	
	static public string playerName;
	public Texture2D[] avatar = new Texture2D[8];
	public Texture2D tickImage;
	private string name = "";
	private int selectedAvatar = -1;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		GUI.Label (new Rect(30, 20, 250, 20), "Please enter your name, and choose an avatar");
		name = GUI.TextArea (new Rect(30, 50, 150, 20), name);
		for (int i = 0; i < 8; i++) {
			if (GUI.Button (new Rect(30 + 60 * i, 80, 50, 50), avatar[i])) {
				selectedAvatar = i;
			}
			if (i == selectedAvatar) {
				GUI.Label (new Rect(30 + 60 * i, 80, 30, 30), tickImage);
			}
		}
		
		if (name.Equals(string.Empty) || selectedAvatar < 0) {
			GUI.Box (new Rect(30, 150, 100, 50), "");
		}
		else {
			if (GUI.Button (new Rect(30, 150, 100, 50), "Client")) {
				playerAvatar = avatar[selectedAvatar];
				playerName = name;
				Application.LoadLevel ("RichSupportNetworkTest");
			}
			if (GUI.Button (new Rect(150, 150, 100, 50), "Server" )) {
				playerAvatar = avatar[selectedAvatar];
				playerName = name;
				Application.LoadLevel ("RichLeadNetworkTest");
			}
			
//			if (GUI.Button (new Rect(30, 150, 100, 50), "Continue")) {
//			playerAvatar = avatar[selectedAvatar];
//			playerName = name;
//			//start game
		}
		
		if (GUI.Button (new Rect(270, 150, 100, 50), "Exit")) {
			Application.Quit();
		}
	}
}
