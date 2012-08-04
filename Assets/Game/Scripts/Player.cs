using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float speed=10.0f;
	public Transform spotLightTransform;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//have to play the character audio here!!!
		
		rigidbody.AddTorque(-speed*Input.GetAxis("Horizontal")*Vector3.forward);
		rigidbody.AddTorque(speed*Input.GetAxis("Vertical")*Vector3.right);
		
		Vector3 spotPosUpdate=spotLightTransform.position;
		spotPosUpdate.x=transform.position.x;
		spotPosUpdate.z=transform.position.z;
		spotLightTransform.position=spotPosUpdate;
	}
}
