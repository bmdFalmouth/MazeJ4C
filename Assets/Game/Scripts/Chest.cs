using UnityEngine;
using System.Collections;

public class Chest : MonoBehaviour {
	
	public Texture2D up;
	public Texture2D down;
	public Texture2D left;
	public Texture2D right;
	public Transform[] pickups;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		int randomNumber = Random.Range (0, pickups.GetLength(0) - 1);
		Instantiate (pickups[randomNumber], new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z), this.transform.localRotation);
		Destroy (gameObject);
	}
}
