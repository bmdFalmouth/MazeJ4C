#pragma strict
var Template : UnityEngine.Transform; 
 var playerIndex : int;
function Start () 
{
	playerIndex = 1;
}

function Update () 
{

}

function OnNetworkLoadedLevel()
{
	if(playerIndex == 1)
	{
		Network.Instantiate(Template, transform.position, transform.rotation,0);
		playerIndex++;
	}
}

function OnPlayerDisconnected(player : NetworkPlayer)
{
	Network.RemoveRPCs(player,0);
	Network.DestroyPlayerObjects(player);
}