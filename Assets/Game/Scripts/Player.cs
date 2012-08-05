using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public string support2Vote = "";
	public float speed=10.0f;
	public Transform spotLightTransform;
	public AudioClip stepOne;
	public AudioClip stepTwo;
	bool leftRight = false;
	
	public GameObject leftArrow;
	public GameObject rightArrow;
	public GameObject upArrow;
	public GameObject downArrow;
	
	public enum ArrowState
	{
		Up,
		Down,
		Left,
		Right,
		None=10,
	};
	
	public ArrowState arrowState;
	

	// Use this for initialization
	void Start () 
	{
		//Remember to add in code to check for audiosource
		spotLightTransform = GameObject.Find("Spotlight").transform;
		arrowState=ArrowState.None;
		leftArrow=GameObject.Find("Arrows/leftArrow");
		rightArrow=GameObject.Find("Arrows/rightArrow");
		upArrow=GameObject.Find("Arrows/upArrow");
		downArrow=GameObject.Find("Arrows/downArrow");
	}
	
	// Update is called once per frame
	void Update () 
	{
		//have to play the character audio here!!!
		
		rigidbody.AddForce(speed*Input.GetAxis("Vertical")*Vector3.forward);
		rigidbody.AddForce(speed*Input.GetAxis("Horizontal")*Vector3.right);
		
		//rigidbody.AddTorque(-speed*Input.GetAxis("Horizontal")*Vector3.forward);
		//rigidbody.AddTorque(speed*Input.GetAxis("Vertical")*Vector3.right);
		
		//transform.Translate(speed*Input.GetAxis("Vertical")*Vector3.forward*Time.deltaTime,Space.World);
		//transform.Translate(speed*Input.GetAxis("Horizontal")*Vector3.right*Time.deltaTime,Space.World);
		
		//speed*Input.GetAxis("Horizontal")*Vector3.forward
			
		if((Input.GetAxis("Horizontal") != 0 ||Input.GetAxis("Horizontal") != 0 )&&!this.gameObject.GetComponent<AudioSource>().isPlaying)
		{
			if(leftRight)
				this.gameObject.GetComponent<AudioSource>().clip = stepOne;
			else
				this.gameObject.GetComponent<AudioSource>().clip = stepTwo;
			this.gameObject.GetComponent<AudioSource>().Play();
		}

		Vector3 spotPosUpdate=spotLightTransform.position;
		spotPosUpdate.x=transform.position.x;
		spotPosUpdate.z=transform.position.z;
		spotLightTransform.position=spotPosUpdate;
		
		
		UpdateArrowStates();	
	}
	
	void HideAllArrows()
	{
		leftArrow.active=false;
		rightArrow.active=false;
		upArrow.active=false;
		downArrow.active=false;				
	}
	
	void UpdateArrowStates()
	{
		switch(arrowState)
		{
			case ArrowState.None:
			{
				HideAllArrows();	
				break;
			}
			
			case ArrowState.Left:
			{
				HideAllArrows();
				leftArrow.active=true;
				break;
			}
			
			case ArrowState.Right:
			{
				HideAllArrows();
				rightArrow.active=true;
				break;
			}
			
			case ArrowState.Up:
			{
				HideAllArrows();
				upArrow.active=true;
				break;
			}	
			
			case ArrowState.Down:
			{
				HideAllArrows();
				downArrow.active=true;	
				break;
			}			
		}
	}

	
	void OnGUI()
	{
		GUI.Label(new Rect(500,500,100,100), support2Vote);
		
		foreach(GameObject support in GameObject.FindGameObjectsWithTag("Support"))
			GUI.Label(new Rect(500,700,100,100), support.GetComponent<Controls>().x.ToString());
	}
}
