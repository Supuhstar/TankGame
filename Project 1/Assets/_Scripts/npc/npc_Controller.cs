using UnityEngine;
using System.Collections;

public class npc_Controller : MonoBehaviour {
	public bool destroyable = true;
	public bool winOnDeath = false;
	public int health = 50;
	public int maxHealth;
	public float deathDelay = 2f;
	public GameObject burnEffect;
	
	public bool selected = false;

	public Material startMat;
	public Material highlightMat;
	public GameObject myGameObjectSkin;
	
	// Use this for initialization
	void Start () {
		if(myGameObjectSkin)
		{
			
			if(myGameObjectSkin.renderer)
			{
				startMat = 	myGameObjectSkin.renderer.material;
			}
		}
		maxHealth = health;
	}

	// Update is called once per frame
	void Update () {
		if(winOnDeath && (health <= 0))
		{
			//Debug.Log("playerwin");	
			  Application.LoadLevel("playerWin");

		}
		if(destroyable && (health <= 0))
		{
			Instantiate(burnEffect, gameObject.transform.position, gameObject.transform.rotation);
			Destroy (gameObject, deathDelay);
			
		}
			
		   if(selected)
		{
			//gameObject.renderer.material=highlightMat;
			if(myGameObjectSkin.renderer)
			{
				myGameObjectSkin.renderer.material = highlightMat;
			}
		
			//	gameController.playerTarget = gameObject;
			

		}
		if(!selected)
		{			
			if(myGameObjectSkin)
			{
				if(myGameObjectSkin.renderer)
				{
				myGameObjectSkin.renderer.material = startMat;
				//gameController.playerTarget = null;
				}
			}
		}
	}
}
