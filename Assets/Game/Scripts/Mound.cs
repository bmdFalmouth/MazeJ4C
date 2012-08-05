using UnityEngine;
using System.Collections;

public class Mound : MonoBehaviour {
	
	public Transform chest;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		audio.Play ();
		Destroy(gameObject, audio.clip.length);
		Instantiate (chest, new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z), this.transform.rotation);
	}
}