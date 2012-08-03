using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float speed=10.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		rigidbody.AddTorque(-speed*Input.GetAxis("Horizontal")*Vector3.forward);
		rigidbody.AddTorque(speed*Input.GetAxis("Vertical")*Vector3.right);
	}
}
