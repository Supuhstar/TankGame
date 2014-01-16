using UnityEngine;
using System.Collections;

public class npc_autoShoot : MonoBehaviour {
	public GameObject bullet;
	public float refireDelay = 2f;
	public float lastShotTime = 0f;
	//public bool goodToShoot = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

			if(lastShotTime + refireDelay < Time.time)
			{
			Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
			lastShotTime = Time.time;
			}
	
	}
}
