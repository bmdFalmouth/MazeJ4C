/*using UnityEngine;
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
		scene4,
		scene6,
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
			//draw title screen
			
			//play sniffing sound
			
			if (Input.GetKeyDown ("space")) {
				introState = State.storyScreen;
			}
			
		
		case State.storyScreen:
			//display story text
			
			//image of Patch on the right
			
		case State.panel1:
			//you are
			//play ping sound & display picture of patch
			//P.A.T.C.H
			
			if (currentTime - startTime > 8) {
				introState = State.panel2;
			}
			return;
			
		case State.panel2:
			//"you want to be the best"
			//star appears behind patch, applause sound
			
			if (currentTime - startTime > 8) {
				introState = State.panel3;
			}
			return;
			
		case State.panel3:
			//"By finding hidden treasure"
			//picture of chest and mound & *oooh* sound effect
			//"what is it?" < across bottom right corner
			
			if (currentTime - startTime > 8) {
				 introState = State.scene4;
			}
			return;
			
		case State.scene4:
			//"your friends can help"
			//arrow directing patch towards chest
			//ping sound
			
			if (currentTime - startTime > 8) {
				introState = State.panel5;
			}
			return;
			
		case State.panel5:
			//"Hinder"
			//Same as above, but arrow pointing away
			//*mischievious laugh*
			
			if (currentTime - startTime > 8) {
				introState = State.scene6;
			}
			return;
			
		case State.scene6:
			//"Let the best patch win"
			//picture of patch holding a trophy
			//cheers and whoops
			
			if (currentTime - startTime > 8) {
				introState = State.tutorialScreen2;
			}
			return;
			
		case State.tutorialScreen2:
			//"you control patch with the arrow keys
			//arrows appear
			//"your 'friends' direct you with theirs"
			//"If anyone leaves the game, their store is shared with other players
			//Time is limited
			//"good luck!
			
			if (currentTime - startTime > 8) {
				//start game
			}
		}
	}
	
	void OnGUI() {
		if (introState == State.storyScreen) {
			if (GUI.Button (new Rect(20, 80, 100, 50), "How to play")) {
				introState = State.panel1;
			}
			if (GUI.Button (new Rect(140, 80, 100, 50), "	Sniff it Out")) {
				//start game
			}
		}
	}
}
*/