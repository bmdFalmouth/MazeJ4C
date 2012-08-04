using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

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
		if(GUI.Button(new Rect(20,100,50,50), "up"))
		{
			Debug.Log("Support Player Up");
		}
		
		if(GUI.Button(new Rect(20,160,50,50), "down"))
		{
			Debug.Log("Support Player Down");
		}
		
		if(GUI.Button(new Rect(20,210,50,50), "left"))
		{
			Debug.Log("Support Player Left");
		}
		
		if(GUI.Button(new Rect(20,260,50,50), "right"))
		{
			Debug.Log("Support Player Right");
		}
	}
}
