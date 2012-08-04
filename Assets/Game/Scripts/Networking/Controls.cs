using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour 
{
	GameObject upVote;
	public int PlayerID = 0;
	
	// Use this for initialization
	void Start () 
	{
		PlayerID = Network.connections.Length;
		PlayerID++;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{
		if(PlayerID != 1)
		{
			if(GUI.Button(new Rect(20,100,50,50), "up"))
			{
				GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().GetVote("Up",PlayerID);
			}
			
			if(GUI.Button(new Rect(20,160,50,50), "down"))
			{
				GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().GetVote("Down",PlayerID);
			}
			
			if(GUI.Button(new Rect(20,210,50,50), "left"))
			{
				GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().GetVote("Left",PlayerID);
			}
			
			if(GUI.Button(new Rect(20,260,50,50), "right"))
			{
				GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().GetVote("Right",PlayerID);
			}
		}
		
		GUI.Label(new Rect(500,500,200,200),PlayerID.ToString());
	}
}
