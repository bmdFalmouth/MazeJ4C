#pragma strict
var Template : UnityEngine.Transform; 
 var playerIndex : int;
function Start () 
{

}

function Update () 
{

}

function OnNetworkLoadedLevel()
{
	Network.Instantiate(Template, transform.position, transform.rotation,0);
}

function OnPlayerDisconnected(player : NetworkPlayer)
{
	Network.RemoveRPCs(player,0);
	Network.DestroyPlayerObjects(player);
}