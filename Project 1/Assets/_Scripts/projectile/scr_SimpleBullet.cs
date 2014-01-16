using UnityEngine;
using System.Collections;

public class scr_SimpleBullet : MonoBehaviour {
	
public int speed = 200;
public float timeToLive = 10f;
public float timeLaunched;
public int damageAmount = 10;
public GameObject thingIHit;
public float destroyDelay = 1f;
	
	//public int updated = 2;
	// Use this for initialization
	void Start () {
		timeLaunched = Time.time;
	}
	

	void OnCollisionEnter(Collision other)
	{	
			
		thingIHit = other.transform.gameObject;
		npc_Controller npcScript = thingIHit.GetComponent<npc_Controller>();
		scr_char_tank_Cntrl playerScript = thingIHit.GetComponent<scr_char_tank_Cntrl>();
		if(npcScript != null)
		{
				//Debug.Log ("Hit Something with a npc controller");
				npcScript.health -= damageAmount;
		}
		else if(playerScript != null)
		{
				//Debug.Log ("Hit something with a Player controll script");
				playerScript.myHealth -= damageAmount;
		}
		else
		{
				//Debug.Log ("Hit Something without a npc controller or a character tank controller");
				
		}
		
		Destroy(gameObject.renderer);
		Destroy(gameObject.rigidbody);
		Destroy(gameObject.collider);
		Destroy (gameObject, destroyDelay);
		

		speed = 50;


		
	}
	// Update is called once per frame
	void Update () {
			
			
		
		gameObject.transform.Translate (0, 0, Time.deltaTime * speed); //Go forward 

		if(Time.time >= timeLaunched + timeToLive)
			{
			Destroy(gameObject);
			}
	

	}
}
