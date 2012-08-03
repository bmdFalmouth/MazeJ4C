using UnityEngine;
using System.Collections;

public class ScoreScreenGUI : MonoBehaviour {
	
	public Texture2D avatar1;
	public Texture2D avatar2;
	public Texture2D avatar3;
	public Texture2D avatar4;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		GUI.Label (new Rect(30, 30, 64, 64), avatar1);
		GUI.Label(new Rect(30, 124, 64, 64), avatar2);
		GUI.Label (new Rect(30, 218, 64, 64), avatar3);
		GUI.Label (new Rect(30, 312, 64, 64), avatar4);
	}
}
