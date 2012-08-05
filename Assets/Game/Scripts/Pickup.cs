using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {
	
	public int scoreValue = 5;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag.Equals("Player")) {
			audio.Play ();
			Destroy(gameObject, audio.clip.length);
			GameGUI.score += scoreValue;
		}
	}
}
