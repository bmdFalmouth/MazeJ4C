using UnityEngine;
using System.Collections;

public class IntroGUI : MonoBehaviour {
	
	private float startTime = 0.0f;
	private float currentTime = 0.0f;
	
	enum State {
		
		scene1,
		scene2,
		scene3,
		scene4,
		scene5,
		scene6
	};
	
	private State introState = State.scene1;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		
		switch (introState) {
		
		case State.scene1:
			//draw scene 1
			
			if (currentTime - startTime > 8) {
				introState = State.scene2;
			}
			return;
			
		case State.scene2:
			//draw scene 2
			
			if (currentTime - startTime > 8) {
				introState = State.scene3;
			}
			return;
			
		case State.scene3:
			//draw scene 3
			
			if (currentTime - startTime > 8) {
				introScene = State.scene4;
			}
			return;
			
		case State.scene4:
			//draw scene 4
			
			if (currentTime - startTime > 8) {
				introScene = State.scene5;
			}
			return;
			
		case State.scene5:
			//draw scene 5
			
			if (currentTime - startTime > 8) {
				introScene = State.scene6;
			}
			return;
			
		case State.scene6:
			//draw scene 6
			
			if (currentTime - startTime > 8) {
				//Intro finished
			}
			return;
			
		}
	}
}
