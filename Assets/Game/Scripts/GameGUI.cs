using UnityEngine;
using System.Collections;

public class GameGUI : MonoBehaviour {
	
	public int score = 0;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		GUI.Label (new Rect (Screen.width - 100, 10, 100, 20), "Score: " + score);
	}
}
