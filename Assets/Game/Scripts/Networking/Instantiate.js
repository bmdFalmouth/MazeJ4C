#pragma strict
var Template : UnityEngine.Transform; 
var Support : UnityEngine.Transform; 
var playerIndex : int;

function Start () 
{

}

function Update () 
{

}

function OnNetworkLoadedLevel()
{
	if(Network.connections.Length == 0)
		Network.Instantiate(Template, transform.position, transform.rotation,0);
	else
		Network.Instantiate(Support, transform.position, transform.rotation,0);
}

function OnPlayerDisconnected(player : NetworkPlayer)
{
	Network.RemoveRPCs(player,0);
	Network.DestroyPlayerObjects(player);
}