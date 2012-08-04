using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour 
{
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
		if(Network.player.ToString() != "0")
		{
			if(GUI.Button(new Rect(20,100,50,50), "up"))
			{
				GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().GetVote("Up",Network.player.ToString());
			}
				
			if(GUI.Button(new Rect(20,160,50,50), "down"))
			{
				GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().GetVote("Down",Network.player.ToString());
			}
			
			if(GUI.Button(new Rect(20,210,50,50), "left"))
			{
				GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().GetVote("Left",Network.player.ToString());
			}
			
			if(GUI.Button(new Rect(20,260,50,50), "right"))
			{
				GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().GetVote("Right",Network.player.ToString());
			}
		
			GUI.Label(new Rect(100,500,200,200),Network.player.ToString());
		}
	}
}
