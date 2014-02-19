using UnityEngine;
using System.Collections;

public class MessGet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	[RPC]
	void PrintText(string text)
	{
    	Debug.Log(text);
	} 
}
