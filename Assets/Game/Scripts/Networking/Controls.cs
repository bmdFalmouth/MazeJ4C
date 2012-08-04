using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour 
{
	GameObject upVote;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{
		if(!this.gameObject.GetComponent<NetworkView>().viewID.ToString().Contains("1"))
		{
			if(GUI.Button(new Rect(20,100,50,50), "up"))
			{
				GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().GetVote(this.gameObject.GetComponent<NetworkView>().viewID.ToString(),"Up");
			}
			
			if(GUI.Button(new Rect(20,160,50,50), "down"))
			{
				GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().GetVote(this.gameObject.GetComponent<NetworkView>().viewID.ToString(),"Down");
			}
			
			if(GUI.Button(new Rect(20,210,50,50), "left"))
			{
				GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().GetVote(this.gameObject.GetComponent<NetworkView>().viewID.ToString(),"Left");
			}
			
			if(GUI.Button(new Rect(20,260,50,50), "right"))
			{
				GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().GetVote(this.gameObject.GetComponent<NetworkView>().viewID.ToString(),"Right");
			}
		}
		
		GUI.Label(new Rect(500,500,200,200),this.gameObject.GetComponent<NetworkView>().viewID.ToString());
	}
}
