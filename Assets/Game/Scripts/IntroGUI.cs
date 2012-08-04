using UnityEngine;
using System.Collections;

public class IntroGUI : MonoBehaviour {
	
	private float startTime = 0.0f;
	private float currentTime = 0.0f;
	
	enum State {
		
		titleScreen,
		storyScreen,
		panel1,
		panel2,
		panel3,
		panel4,
		panel5,
		panel6,
		tutorialScreen2
	};
	
	private State introState = State.titleScreen;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		
		switch (introState) {
		
		case State.titleScreen:			
			//play sniffing sound
			
			if (Input.GetKeyDown ("space")) {
				introState = State.storyScreen;
			}
			break;
			
		case State.panel1:
			if (currentTime - startTime > 8) {
				introState = State.panel2;
				startTime = 0.0f;
				currentTime = 0.0f;
			}
			break;
			
		case State.panel2:
			if (currentTime - startTime > 8) {
				introState = State.panel3;
				startTime = 0.0f;
				currentTime = 0.0f;
			}
			break;
			
		case State.panel3:
			if (currentTime - startTime > 8) {
				 introState = State.panel4;
				startTime = 0.0f;
				currentTime = 0.0f;
			}
			break;
			
		case State.panel4:
			if (currentTime - startTime > 8) {
				introState = State.panel5;
				startTime = 0.0f;
				currentTime = 0.0f;
			}
			break;
			
		case State.panel5:
			if (currentTime - startTime > 8) {
				introState = State.panel6;
				startTime = 0.0f;
				currentTime = 0.0f;
			}
			break;
			
		case State.panel6:
			if (currentTime - startTime > 8) {
				introState = State.tutorialScreen2;
				startTime = 0.0f;
				currentTime = 0.0f;
			}
			break;
			
		case State.tutorialScreen2:
			if (currentTime - startTime > 8) {
				//start game
			}
			break;
		}
	}
	
	void OnGUI() {
		if (introState == State.titleScreen) {
			//Draw title screen
			
			GUI.Label (new Rect(Screen.width / 2 - 50, Screen.height - 20, 150, 20), "Press space to continue.");
		}
		
		else if (introState == State.storyScreen) {
			//display story text
			//image of Patch on the right
			
			if (GUI.Button (new Rect(20, 80, 100, 50), "How to play")) {
				introState = State.panel1;
			}
			if (GUI.Button (new Rect(140, 80, 100, 50), "Sniff it Out")) {
				//start game
			}
		}
		
		else if (introState == State.panel1) {
			GUI.Label (new Rect(Screen.width / 2 - 30, 30, 100, 20), "You are");
			//play ping sound & display picture of patch
			GUI.Label (new Rect(Screen.width / 2 - 30, Screen.height - 50, 100, 20), "P.A.T.C.H");
		}
		
		else if (introState == State.panel2) {
			GUI.Label (new Rect(Screen.width / 2 - 30, 30, 150, 20), "You want to be the best");
			//star appears behind patch, applause sound
		}
		
		else if (introState == State.panel3) {
			GUI.Label (new Rect(Screen.width / 2 - 30, 30 ,150 ,20), "By finding hidden treasure");
			//picture of chest and mound & *oooh* sound effect			
			GUI.Label (new Rect(Screen.width - 100, Screen.height - 50, 100, 20), "What is it?");
		}
		
		else if (introState == State.panel4) {
			GUI.Label (new Rect(Screen.width / 2 - 30, 30, 150, 20), "You friends can help");
			//arrow directing patch towards chest
			//ping sound
		}
		
		else if (introState == State.panel5) {
			GUI.Label (new Rect(Screen.width / 2 - 30, 30, 100, 20), "Hinder");
			//Same as above, but arrow pointing away
			//*mischievious laugh*
		}
		
		else if (introState == State.panel6) {
			GUI.Label (new Rect(Screen.width / 2 - 30, 30, 150, 20), "Let the best patch win");
			//picture of patch holding a trophy
			//cheers and whoops
		}
		
		else if (introState == State.tutorialScreen2) {
			
			GUI.Label (new Rect(Screen.width / 2 - 30, 30, 250, 20), "You control patch with the arrow keys");
			//arrows appear
			GUI.Label (new Rect(Screen.width / 2 - 30, 60, 250, 20), "Your \"friends\" direct you with theirs");
			GUI.Label (new Rect(Screen.width / 2 - 50, 120, 350, 20), "If anyone leaves the game, their score is shared with other players");
			GUI.Label (new Rect(Screen.width / 2 - 30, 180, 150, 20), "Time is limited");
			GUI.Label (new Rect(Screen.width / 2 - 30, 210, 100, 20), "Good luck");
		}
	}
}
<<<<<<< HEAD
=======

>>>>>>> a9226fecc74d19f6974a2dc0d5931973da593019
