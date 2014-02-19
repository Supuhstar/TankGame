using UnityEngine;
using System.Collections;

public class MessSend : MonoBehaviour {
	
	public string messtest = "NOTHING";
	public bool test = true;
	
	// Use this for initialization
	void Start () {
	
	}
	
	[RPC]
	void PrintText(string text)
	{
    	Debug.Log(text);
	}
	
	
	// Update is called once per frame
	void Update () {		
		if (Input.GetKeyDown("space"))
		{
			if (Input.GetKey(KeyCode.W))
			{
				messtest = "W";
			}
			if (Input.GetKey(KeyCode.A))
			{
				messtest = "A";	
			}
			if (Input.GetKey(KeyCode.S))
			{
				messtest = "S";	
			}
			if (Input.GetKey(KeyCode.D))
			{
				messtest = "D";	
			}
			
			uLink.NetworkView.Get(this).RPC("PrintText", uLink.RPCMode.Server, messtest);
		}	
	}
		
}
