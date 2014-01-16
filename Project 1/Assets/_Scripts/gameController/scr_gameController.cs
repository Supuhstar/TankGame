using UnityEngine;
using System.Collections;

public class scr_gameController : MonoBehaviour {

	public npc_Controller currentSelected = null;
	public string playerName = "tank base";
	public GameObject playerTank;
	public scr_char_tank_Cntrl playerControl;
	public scr_HudGui gameHud;
	//public GameObject playerTarget;
	public Texture tankHealth100;
	public Texture tankHealth90;
	public Texture tankHealth80;
	public Texture tankHealth70;
	public Texture tankHealth60;
	public Texture tankHealth50;
	public Texture tankHealth40;
	public Texture tankHealth30;
	public Texture tankHealth20;
	public Texture tankHealth10;
	public float targetHealthNumber;
	public float aNumber;
	public float anotherNumber;
	public float playerHealthNumber;
	public float playerNumber;
	public float playerAnotherNumber;
	public GameObject killThisToWin;
	public npc_Controller killTargetScript;
	// Use this for initialization
	void Start () {
	playerTank = GameObject.Find(playerName);
	playerControl = playerTank.GetComponent<scr_char_tank_Cntrl>();
	gameHud.tankHealth = tankHealth100;
	//killTargetScript = killThisToWin.GetComponent<npc_Controller>();
	}
	
	// Update is called once per frame
	void Update () {

		if(playerTank)
		{
			playerNumber = playerControl.myHealth;
			playerAnotherNumber = playerControl.myHealthMax;
			playerHealthNumber = playerNumber/playerAnotherNumber;
			playerHealthNumber = playerHealthNumber *100;
				
			if(playerHealthNumber >= 100)
			{
				gameHud.tankHealth = tankHealth100;
				//Debug.Log ("health at 100");
				
			}
			else if(playerHealthNumber >= 90)
			{
					gameHud.tankHealth = tankHealth90;
				//Debug.Log ("health at 90");
				
			}
			else if(playerHealthNumber >= 80)
			{
					gameHud.tankHealth = tankHealth80;
				//Debug.Log ("health at 80");
				
			}
			else if(playerHealthNumber >= 70)
			{
					gameHud.tankHealth = tankHealth70;
				//Debug.Log ("health at 70");
				
			}
			else if(playerHealthNumber >= 60)
			{
					gameHud.tankHealth = tankHealth60;
				//Debug.Log ("health at 60");
				
			}
			else if(playerHealthNumber >= 50)
			{
					gameHud.tankHealth = tankHealth50;
				//Debug.Log ("health at 50");
				
			}
			else if(playerHealthNumber >= 40)
			{
					gameHud.tankHealth = tankHealth40;
				//Debug.Log ("health at 40");
				
			}
			else if(playerHealthNumber >= 30)
			{
					gameHud.tankHealth = tankHealth30;
				//Debug.Log ("health at 30");
				
			}
			else if(playerHealthNumber >= 20)
			{
					gameHud.tankHealth = tankHealth20;
				//Debug.Log ("health at 20");
				
			}
			else if(playerHealthNumber >= 10)
			{
					gameHud.tankHealth = tankHealth10;
				//Debug.Log ("health at 10");
				
			}
			else
			{
				gameHud.tankHealth = tankHealth10;
				
				Debug.Log ("player Death!");
				
				
			}
			
		}
		
		if(currentSelected)	
		{
			aNumber = currentSelected.health;
			anotherNumber= currentSelected.maxHealth;
			targetHealthNumber = aNumber/anotherNumber;
			targetHealthNumber = targetHealthNumber * 100;
			
	
			if(targetHealthNumber >= 100)
			{
				gameHud.targetHealth = tankHealth100;
				//Debug.Log ("health at 100");
				
			}
			else if(targetHealthNumber >= 90)
			{
					gameHud.targetHealth = tankHealth90;
				//Debug.Log ("health at 90");
				
			}
			else if(targetHealthNumber >= 80)
			{
					gameHud.targetHealth = tankHealth80;
				//Debug.Log ("health at 80");
				
			}
			else if(targetHealthNumber >= 70)
			{
					gameHud.targetHealth = tankHealth70;
				//Debug.Log ("health at 70");
				
			}
			else if(targetHealthNumber >= 60)
			{
					gameHud.targetHealth = tankHealth60;
				//Debug.Log ("health at 60");
				
			}
			else if(targetHealthNumber >= 50)
			{
					gameHud.targetHealth = tankHealth50;
				//Debug.Log ("health at 50");
				
			}
			else if(targetHealthNumber >= 40)
			{
					gameHud.targetHealth = tankHealth40;
				//Debug.Log ("health at 40");
				
			}
			else if(targetHealthNumber >= 30)
			{
					gameHud.targetHealth = tankHealth30;
				//Debug.Log ("health at 30");
				
			}
			else if(targetHealthNumber >= 20)
			{
					gameHud.targetHealth = tankHealth20;
				//Debug.Log ("health at 20");
				
			}
			else if(targetHealthNumber >= 10)
			{
					gameHud.targetHealth = tankHealth10;
				//Debug.Log ("health at 10");
				
			}
			else
			{
				gameHud.targetHealth = tankHealth10;
				//Debug.Log ("health at 0");
				
			}
       }
		else
			{
			gameHud.targetHealth = tankHealth10;
			}
      			
	
		
		
		if(Input.GetButtonDown("Fire1"))
		{	

		//	Vector3 p = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit, Mathf.Infinity))
			{
					
				
				//npc_selectable npc_temp = hit.transform.GameObject.getComponent<npc_selectable>();
				npc_Controller npc_temp = hit.transform.gameObject.GetComponent<npc_Controller>(); 
				if(npc_temp != null)
				{
					
					//if we clickd on something do stuff\
					//see if its something different
					if(npc_temp != currentSelected)
					{
					if(currentSelected)
						{
						currentSelected.selected = false;	
						}
					currentSelected = npc_temp;
					currentSelected.selected = true;
					
					//playerTank.GetComponent<scr_char_tank_Cntrl>();	
					playerControl.turretTarget = currentSelected.gameObject;
				
					}
				}
			}
				
			
			
			
			
			
		}

		//when we let up on the left button what happens?
		if(Input.GetButtonUp ("Fire1"))
		{
			
		}
	
		if(Input.GetButtonUp ("Fire2"))
		{
			if(currentSelected)
			{
			currentSelected.selected = false;
			currentSelected = null;
			playerControl.turretTarget = null;
				
			}
		}
		
	}
}


	
