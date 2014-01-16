using UnityEngine;
using System.Collections;
[RequireComponent (typeof (CharacterController))]
public class scr_char_Controll_2 : MonoBehaviour {
	
public CharacterController controller;
//controller = gameObject.GetComponent(CharacterController);
 
private Vector3 moveDirection = Vector3.zero;
private Vector3  forward = Vector3.zero;
private Vector3 right = Vector3.zero;
public float momentum = 0;
public float momentumMAX = 10;
public float momentumFalloff = .01f;
public float momentumBreaking = .05f;	
public float momentumGain = .1f;
//public float minSpeedStop = .05f;
	
public float turnSpeed = .05f;
public float slowTurnSpeed = 0.01f;
public float slowTurnMinSpeed = .5f;
public float minTurningSpeed = .1f;
//public bool canTurn = true;
//private float currentTurnSpeed = 0f;

	
public bool canReverse = false;	
	
	// Use this for initialization
	void Start () {
	controller = (CharacterController)GetComponent(typeof(CharacterController));
	}
	
	// Update is called once per frame
	void Update () {
	
	forward = transform.forward;
	right = new Vector3(forward.z, 0, -forward.x);
 
	float horizontalInput = Input.GetAxisRaw("Horizontal");
	float verticalInput = Input.GetAxisRaw("Vertical");
	
	if(momentum < minTurningSpeed)
		{
		horizontalInput = 0f;
		}
		else if(momentum < slowTurnMinSpeed)
		{
		horizontalInput = horizontalInput * slowTurnSpeed;
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
		
	if (targetDirection != Vector3.zero)
	{
	transform.rotation = Quaternion.LookRotation(moveDirection);
	}
	}

}

