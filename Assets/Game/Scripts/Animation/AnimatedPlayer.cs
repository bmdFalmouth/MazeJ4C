using UnityEngine;
using System.Collections;

public class AnimatedPlayer : MonoBehaviour {
	
	public enum AnimationState
	{
		idleFront=0,
		idleBack,
		idleLeft,
		idleRight,
		walkFront,
		walkBack,
		walkLeft,
		walkRight
	};
	
	public OTAnimatingSprite animatedSprite;              // gun sprite reference
	public AnimationState animationState=AnimationState.idleFront;
	public float idleTime=0.5f;
	public float currentIdleTime=0.0f;
	public bool startIdleTime=false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Horizontal")>0)
		{
			animationState=AnimationState.walkRight;
			currentIdleTime=0.0f;
			startIdleTime=true;
		}
		else if (Input.GetAxis("Horizontal")<0)
		{
			animationState=AnimationState.walkLeft;
			currentIdleTime=0.0f;
			startIdleTime=true;
		}
		else if (Input.GetAxis("Vertical")>0)
		{
			animationState=AnimationState.walkBack;
			currentIdleTime=0.0f;
			startIdleTime=true;
		}
		else if (Input.GetAxis("Vertical")<0)
		{
			animationState=AnimationState.walkFront;
			currentIdleTime=0.0f;
			startIdleTime=true;
		}		
		if (startIdleTime)
		{
			UpdateToIdleAnimations();
		}
		UpdateAnimation();
	}
	
	void UpdateToIdleAnimations()
	{
		currentIdleTime+=Time.deltaTime;
		if (currentIdleTime>idleTime)
		{
			startIdleTime=false;
		switch(animationState)
		{
			case AnimationState.walkFront:
			{
				animationState=AnimationState.idleFront;
				break;
			}
			case AnimationState.walkBack:
			{
				animationState=AnimationState.idleBack;
				break;
			}
			case AnimationState.walkLeft:
			{
				animationState=AnimationState.idleLeft;
				break;
			}			
			case AnimationState.walkRight:
			{
				animationState=AnimationState.idleRight;
				break;
			}				
		}			
		}
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
			case AnimationState.walkFront:
			{
				animatedSprite.PlayLoop("walkFront");
				break;
			}
			case AnimationState.walkBack:
			{
				animatedSprite.PlayLoop("walkBack");
				break;
			}
			case AnimationState.walkLeft:
			{
				animatedSprite.PlayLoop("walkLeft");
				break;
			}			
			case AnimationState.walkRight:
			{
				animatedSprite.PlayLoop("walkRight");
				break;
			}				
		}		
	}
}
