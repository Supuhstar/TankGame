using UnityEngine;
using System.Collections;

public class npc_burn : MonoBehaviour {
public float timeToLive = 10f;
public float timeLaunched;
	
	// Use this for initialization
	void Start () {
		timeLaunched = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time >= timeLaunched + timeToLive)
		{
			Destroy(gameObject.renderer);
			Destroy(gameObject.rigidbody);
			Destroy(gameObject.collider);
			Destroy (gameObject, 0.5f);
		}
	}
}
