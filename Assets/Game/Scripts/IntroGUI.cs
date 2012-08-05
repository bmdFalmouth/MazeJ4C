using UnityEngine;
using System.Collections;

public class IntroGUI : MonoBehaviour {
	
	public Texture2D titleCard;
	public AudioClip sniffing;
	public Texture2D story;
	public Texture2D panel1;
	public Texture2D panel2;
	public AudioClip cheer;
	public Texture2D panel3;
	public Texture2D panel4;
	public Texture2D panel5;
	public Texture2D panel6;
	public AudioClip yay;
	private float startTime = 0.0f;
	private float currentTime = 0.0f;
	private const int timeOut = 3;
	
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
			if (Input.GetKeyDown ("space")) {
				introState = State.storyScreen;
			}
			break;
			
		case State.panel1:
			if (currentTime - startTime > timeOut) {
				introState = State.panel2;
				startTime = 0.0f;
				currentTime = 0.0f;
			}
			break;
			
		case State.panel2:
			if (currentTime - startTime > timeOut) {
				introState = State.panel3;
				startTime = 0.0f;
				currentTime = 0.0f;
			}
			break;
			
		case State.panel3:
			if (currentTime - startTime > timeOut) {
				 introState = State.panel4;
				startTime = 0.0f;
				currentTime = 0.0f;
			}
			break;
			
		case State.panel4:
			if (currentTime - startTime > timeOut) {
				introState = State.panel5;
				startTime = 0.0f;
				currentTime = 0.0f;
			}
			break;
			
		case State.panel5:
			if (currentTime - startTime > timeOut) {
				introState = State.panel6;
				startTime = 0.0f;
				currentTime = 0.0f;
			}
			break;
			
		case State.panel6:
			if (currentTime - startTime > timeOut) {
				introState = State.tutorialScreen2;
				startTime = 0.0f;
				currentTime = 0.0f;
			}
			break;
		}
	}
	
	void OnGUI() {
		if (introState == State.titleScreen) {
			if (!audio.isPlaying) {
				this.gameObject.GetComponent<AudioSource>().clip = sniffing;
				audio.Play ();
			}
			
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), titleCard, ScaleMode.StretchToFill);
			GUI.Label (new Rect(Screen.width / 2 - 50, Screen.height - 20, 150, 20), "Press space to continue.");
		}
		
		else if (introState == State.storyScreen) {
			GUI.Label (new Rect(Screen.width / 2 - 200, 0, 400, 400), story);
			if (GUI.Button (new Rect(Screen.width / 2 - 110, 350, 100, 50), "How to play")) {
				startTime = 0.0f;
				currentTime = 0.0f;
				introState = State.panel1;
			}
			if (GUI.Button (new Rect(Screen.width / 2 + 110, 350, 100, 50), "Sniff it Out")) {
				Application.LoadLevel ("MainMenu");
			}
		}
		
		else if (introState == State.panel1) {
			GUI.DrawTexture (new Rect(0, 0, Screen.width, Screen.height), panel1, ScaleMode.StretchToFill);
			//play ping sound
		}
		
		else if (introState == State.panel2) {
			GUI.DrawTexture (new Rect(0, 0, Screen.width, Screen.height), panel2, ScaleMode.StretchToFill);
			
			if (!audio.isPlaying) {
				this.gameObject.GetComponent<AudioSource>().clip = cheer;
				audio.Play ();
			}
		}
		
		else if (introState == State.panel3) {
			GUI.DrawTexture (new Rect(0, 0, Screen.width, Screen.height), panel3, ScaleMode.StretchToFill);
			//*oooh* sound effect
		}
		
		else if (introState == State.panel4) {
			GUI.DrawTexture (new Rect(0, 0, Screen.width, Screen.height), panel4, ScaleMode.StretchToFill);
			//ping sound
		}
		
		else if (introState == State.panel5) {
			GUI.DrawTexture (new Rect(0, 0, Screen.width, Screen.height), panel5, ScaleMode.StretchToFill);
			//*mischievious laugh*
		}
		
		else if (introState == State.panel6) {
			GUI.DrawTexture (new Rect(0, 0, Screen.width, Screen.height), panel6, ScaleMode.StretchToFill);
			
			if (!audio.isPlaying) {
				this.gameObject.GetComponent<AudioSource>().clip = yay;
				audio.Play ();
			}
		}
		
		else if (introState == State.tutorialScreen2) {
			GUI.color = Color.black;
			GUI.Label (new Rect(Screen.width / 2 - 96, 30, 250, 20), "You control patch with the arrow keys");
			GUI.Label (new Rect(Screen.width / 2 - 89, 60, 250, 20), "Your \"friends\" direct you with theirs");
			GUI.Label (new Rect(Screen.width / 2 - 155, 120, 350, 20), "If anyone leaves the game, their score is shared with other players");
			GUI.Label (new Rect(Screen.width / 2 - 19, 180, 150, 20), "Time is limited");
			GUI.Label (new Rect(Screen.width / 2 - 10, 210, 100, 20), "Good luck");
			
			if (GUI.Button (new Rect(Screen.width / 2 - 50, Screen.height - 60, 100, 50), "Continue")) {
				Application.LoadLevel ("MainMenu");
			}
		}
	}
}