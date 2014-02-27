using UnityEngine;
using System.Collections;

/**
 * Manages the player's network activities
 */
public class PlayerNet : MonoBehaviour {
	
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
	
	[RPC]
	void Move(string howToMove) {
		Debug.Log ("I've been told to move: " + howToMove);
	}

	/** Signifies how long to wait before sending a message */
	public float delay = .25f;
	float expiry = 0;
	public bool firedBefore = false, firedNow = false;
	public Type currentType = Type.CANNON;
	// Update is called once per frame
	void Update () {
		expiry += Time.deltaTime;
		if (expiry >= delay) // ensure messages aren't sent too often
		{
			expiry = 0;
			float fire1 = Input.GetAxis("Fire1");
			firedNow = fire1 != 0; // if there is input from the fire control, the weapon has been fired. Else, it hasn't
			if (currentType == Type.CANNON) // if the weapon fires like a cannon (slowly, one at a time)
			{
				if (firedBefore && firedNow) // if the weapon fired last update (control is still activated)
				{
					firedNow = false; // don't fire this time
					firedBefore = true;
				}
				else
					firedBefore = firedNow;
			}
			messtest = // build the message to send
				"left " + Input.GetAxis("LeftTread") +
				"; right " + Input.GetAxis("RightTread") +
				"; fire " + (firedNow ? 1 : 0);

			sendMessage(messtest);
		}	
	}

	void sendMessage(string message)
	{
		uLink.NetworkView.Get(this).RPC("PlayerInput", uLink.RPCMode.Server, message);
	}
}
