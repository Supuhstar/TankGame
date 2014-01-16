using UnityEngine;
using System.Collections;

public class scr_simpleMove : MonoBehaviour {
public float baseSpeedForward_Relative = 250;   //to fast breaks it	
//public float baseSpeedZ_Relative = 50;	
		
public float travelLimitX_Global = 200;         //edge of travelable area
public float travelLimitZ_Global = 200;			//edge of travelable area
public int checkFlagRecheckDelay = 10;				
private int checkFlagRecheckCountdown = 0;	
public bool checkflag = true;
public int afterTurnCheckDelay = 20;
public float turnAmount = 120;
public float turnSpeed = 250;
//private bool turning = false;
private float amntToTurn = 0;
		
		
//todo: Fig out how to account for drifting		
//public float travelHightValueFixer_Global = 0;   //not used 
//public float travelDriftValueFixer_Global = 0;		//not used
		
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//gameObject.transform.Translate (Time.deltaTime * baseSpeedForward_Relative, 0, 0);
		//gameObject.transform.Translate (Time.deltaTime * baseSpeedX, travelDriftValueFixer_Global, travelHightValueFixer_Global);
		
		//checkFlagRecheckDelay = checkFlagRecheckDelay -1;
		
		if( checkflag == false)    //if were not checking for out of bounds 
		{
			checkFlagRecheckCountdown = checkFlagRecheckCountdown + 1; //add to the out of bounds counter
		}
		
		if (checkFlagRecheckCountdown >= checkFlagRecheckDelay) //if the out of bounds counter gets to this amount
		{
			checkflag = true;    //start checking for out of bounds again
			checkFlagRecheckCountdown = 0; //reset the counter
		}
		

		if(((Mathf.Abs(gameObject.transform.position.x) > travelLimitX_Global) && (checkflag = true))||((Mathf.Abs(gameObject.transform.position.z) > travelLimitZ_Global) && (checkflag = true))) // hit the edge according to the numbers
		{
			checkflag = false;     //stop checking for out of bounds
			//gameObject.transform.Translate (0, 0, 0);  //stop the thing
			
			if(amntToTurn <= 0)   //if not turning
			{
				amntToTurn = turnAmount;   // set an amount to turn
			}
		}
		
		if(amntToTurn > 0)  // if there is an amount to turn
		{
			float currentTurnAmnt = Time.deltaTime * turnSpeed;   //figure how much we want to turn
			
			if (currentTurnAmnt > amntToTurn)						//see if thats too much
			{	
				currentTurnAmnt = amntToTurn;						//if it is change the amount to finish the turn
			}
			amntToTurn = amntToTurn - currentTurnAmnt;
			transform.Rotate(0, 0, currentTurnAmnt);  //do the turn
			
			checkFlagRecheckCountdown = afterTurnCheckDelay; //give us some time after a turn to move;
		}
		if(amntToTurn == 0) //if we have no turn
		{
			gameObject.transform.Translate (Time.deltaTime * baseSpeedForward_Relative, 0, 0); //Go forward again
		}

	}
}
