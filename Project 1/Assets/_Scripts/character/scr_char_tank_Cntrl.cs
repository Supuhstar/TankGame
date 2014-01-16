
using UnityEngine;
using System.Collections;
[RequireComponent (typeof (CharacterController))]

public class scr_char_tank_Cntrl : MonoBehaviour {
	
public CharacterController controller;
//controller = gameObject.GetComponent(CharacterController);
 
private Vector3 moveDirection = Vector3.zero;
private Vector3  forward = Vector3.zero;
private Vector3 right = Vector3.zero;
public float momentum = 0;
public float momentumMAX = 15;
public float momentumFalloff = .1f;
public float momentumBreaking = .5f;	
public float momentumGain = .5f;
public float hightFor2dMovement;
public int myHealth = 100;
public int myHealthMax = 100;
public GameObject deathBurn;

//public float minSpeedStop = .05f;
	
public float turnSpeed = .05f;
//public float slowTurnSpeed = 0.01f;
public float minTurningSpeed = 3f;  // how fast before we can turn
//public float spinSpeed = .0001f;
//public bool canTurn = true;
//private float currentTurnSpeed = 0f;

	
public bool canReverse = false;	

	
public GameObject turretTarget;		
	// Use this for initialization
	void Start () {
		
	controller = (CharacterController)GetComponent(typeof(CharacterController));
	hightFor2dMovement = transform.position.y;
	
	}

	// Update is called once per frame
	void Update () {

	if(myHealth <= 0)
	{
		Debug.Log("player death!");
		
					Application.LoadLevel("playerDeath");

	}
		
	forward = transform.forward;
	right = new Vector3(forward.z, 0, -forward.x);
 
	float horizontalInput = Input.GetAxisRaw("Horizontal");
	float verticalInput = Input.GetAxisRaw("Vertical");
	
	//if(horizontalInput != 0 && momentum <= minTurningSpeed)
	//	{
	//		momentum = momentumGain/2;
	//	}
		
	if(myHealth <= 0)
	{
	momentumMAX = 0;
	Instantiate(deathBurn, gameObject.transform.position, gameObject.transform.rotation);		
	}
		
	
	if(momentum < minTurningSpeed && horizontalInput != 0)  // not fast enough for normal turn
		{
			momentum += momentumGain; //accel slowly
			horizontalInput = 0; //dont turn
			
		}
		
	if(verticalInput > 0 )  //accel
		{
			momentum += momentumGain;
		}
	else if(verticalInput < 0) //break
		{
			momentum -= momentumBreaking;
		}
	else
		{
			momentum -= momentumFalloff;
		}
	if(momentum > momentumMAX)
		{
			momentum = momentumMAX;
		}
	if(!canReverse && momentum < 0)
		{
		momentum = 0;
		}
		

		

	Vector3 targetDirection = horizontalInput*turnSpeed * right + momentum * forward;	
	
	
		
	moveDirection = Vector3.RotateTowards(moveDirection, targetDirection, 200 * Mathf.Deg2Rad * Time.deltaTime, 1000);
	
	Vector3 movement = moveDirection  * Time.deltaTime * momentum;
	controller.Move(movement);
	gameObject.transform.position = new Vector3(gameObject.transform.position.x, hightFor2dMovement,gameObject.transform.position.z);
	//	position = Vector3.up * 10.0;
//	transform.position.y = 0f;
	//controller.transform.position.y = hightFor2dMovement;	
	
		if (targetDirection != Vector3.zero)
	{
	transform.rotation = Quaternion.LookRotation(moveDirection);
	}
	
	}

}

