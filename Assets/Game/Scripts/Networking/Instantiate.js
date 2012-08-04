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
	if(Network.connections.Length == 0)
		Network.Instantiate(Template, transform.position, transform.rotation,0);
	else
		Debug.Log("P2 Connected");
}

function OnPlayerDisconnected(player : NetworkPlayer)
{
	Network.RemoveRPCs(player,0);
	Network.DestroyPlayerObjects(player);
}