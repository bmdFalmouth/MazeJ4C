using UnityEngine;
using System.Collections;

public class AnimatedPlayer : MonoBehaviour {
	
	public enum AnimationState
	{
		idleFront=0,
		idleBack,
		idleLeft,
		idleRight
	};
	
	public OTAnimatingSprite animatedSprite;              // gun sprite reference
	public AnimationState animationState=AnimationState.idleFront;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Horizontal")>0)
		{
			animationState=AnimationState.idleRight;
		}
		else if (Input.GetAxis("Horizontal")<0)
		{
			animationState=AnimationState.idleLeft;
		}
		else if (Input.GetAxis("Vertical")>0)
		{
			animationState=AnimationState.idleBack;
		}
		else if (Input.GetAxis("Vertical")<0)
		{
			animationState=AnimationState.idleFront;
		}		
		UpdateAnimation();
	}
	
	void UpdateAnimation()
	{
		
		switch(animationState)
		{
			case AnimationState.idleFront:
			{
				animatedSprite.Play("idleFront");
				break;
			}
			case AnimationState.idleBack:
			{
				animatedSprite.Play("idleBack");
				break;
			}
			case AnimationState.idleLeft:
			{
				animatedSprite.Play("idleLeft");
				break;
			}			
			case AnimationState.idleRight:
			{
				animatedSprite.Play("idleRight");
				break;
			}			
		}		
	}
}
