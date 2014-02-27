using UnityEngine;
using System.Collections;
/**
 * Manages the server's network activities
 */
public class ServerNet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	[RPC]
	void PlayerInput(string inputMessage)
	{
    	Debug.Log(inputMessage);
		uLink.NetworkView.Get(this).RPC("Move", uLink.RPCMode.Owner, "You must move like: " + inputMessage);
	} 
}
