using UnityEngine;
using System.Collections;


public class MessSend : MonoBehaviour {
	
	public string messtest = "NOTHING";

	public enum Type
	{
		/** Represents a slow-shot cannon */
		CANNON,
		/** Represents a rapid-shot gun */
		RAPID
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	/*[RPC]
	void PrintText(string text)
	{
    	Debug.Log(text);
	}*/
	
	public float expiry = 0;
	bool fired = false;
	public Type currentType = Type.CANNON;
	// Update is called once per frame
	void Update () {
		expiry += Time.deltaTime;
		if (expiry >= .1) // every tenth of a second, or ten times a second
		{
			expiry = 0;
			float fire1 = Input.GetAxis("Fire1");
			if (fire1 != 0)
				fired = true;
			if (currentType == Type.CANNON)
			{
				if (fired)
					fired = 
			}
			messtest =
				"left " + Input.GetAxis("LeftTread") +
				"; right " + Input.GetAxis("RightTread") +
				"; fire " + fire1;
			
			uLink.NetworkView.Get(this).RPC("PrintText", uLink.RPCMode.Server, messtest);
		}	
	}
		
}
