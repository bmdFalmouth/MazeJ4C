using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour 
{
	public int x = -1;
	private Player player;
	// Use this for initialization
	void Start () 
	{
		this.gameObject.GetComponent<NetworkView>().observed = this.gameObject.GetComponent<Controls>();	
		
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{
		if(Network.isClient)
		{			
			if(GUI.Button(new Rect(20,110,50,50), "up"))
			{
				x = 0;
			}
				
			if(GUI.Button(new Rect(20,160,50,50), "down"))
			{				
				x = 1;
			}
			
			if(GUI.Button(new Rect(20,260,50,50), "right"))
			{
				x = 3;
			}
			
			
			if(GUI.Button(new Rect(20,210,50,50), "left"))
			{
				x = 2;
			}
			
			GUI.Label(new Rect(100,500,200,200),Network.player.ToString());
		}
	}
	

	void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info)
	{
		if(stream.isWriting)
		{
			stream.Serialize(ref x);
		}
		else
		{
			stream.Serialize(ref x);
			if (x<10){
				
				switch(info.sender.ToString())
				{
					case "1":
					player=GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
					player.arrowState1 = (Player.ArrowState)x;
					break;
					case "2":
					player=GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
					player.arrowState2 = (Player.ArrowState)x;
					break;
					case "3":
					player=GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
					player.arrowState3 = (Player.ArrowState)x;
					break;
				}
			}
		}
	}
	
	 void OnDisconnectedFromServer(NetworkDisconnection info) 
	{
        if (Network.isClient)
            Application.LoadLevel("ScoreScreen");
    }
}