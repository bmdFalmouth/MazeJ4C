using UnityEngine;
using System.Collections;

public class ScoreTimer : MonoBehaviour 
{
	public float tScore = 0;
	public float score = 0;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject.Find("Main Camera").GetComponent<GameGUI>().score =  (int)Mathf.Floor(Time.timeSinceLevelLoad + tScore);
	}
	
	public void GetTreasure(float tValue)
	{
		tScore += tValue;
	}
}
