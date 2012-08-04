using UnityEngine;
using System.Collections;

public class AnimatedPlayer : MonoBehaviour {
	
	public OTAnimatingSprite gun;              // gun sprite reference
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			gun.PlayOnce("shoot");
		}
		else
		{
			gun.PlayLoop("idle");
		}
	}
}
