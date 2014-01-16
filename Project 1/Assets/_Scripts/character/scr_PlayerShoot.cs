using UnityEngine;
using System.Collections;

public class scr_PlayerShoot : MonoBehaviour {
	public GameObject playerBullet;
	public float refireDelay = 3f;
	public float lastShotTime = 0f;
	//public bool goodToShoot = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	if(Input.GetButtonDown("Jump"))
		{
			if(lastShotTime + refireDelay < Time.time)
			{
			Instantiate(playerBullet, gameObject.transform.position, gameObject.transform.rotation);
			lastShotTime = Time.time;
			}
		}
	}
}
