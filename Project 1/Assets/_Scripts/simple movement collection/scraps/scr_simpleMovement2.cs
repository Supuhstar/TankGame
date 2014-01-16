using UnityEngine;
using System.Collections;

public class scr_simpleMovement2 : MonoBehaviour {
	
public float baseSpeedForward_Relative = 250;   

	
public float travelLimitX_Global = 200;         //edge of travelable area
public float travelLimitZ_Global = 200;			//edge of travelable area
private Vector3 worldPosition;
	
public int checkFlagRecheckDelay = 10;				
private int checkFlagRecheckCountdown = 0;	
public bool checkflag = true;
public int afterTurnCheckDelay = 20;
public float turnAmount = 120;
public float turnSpeed = 250;
private bool turning = false;
private float amntToTurn = 0;
public float roundingPrecision = 100;		
		
//todo: Fig out how to account for drifting		
//public float travelHightValueFixer_Global = 0;   //not used 
//public float travelDriftValueFixer_Global = 0;		//not used
		
	// Use this for initialization
	void Start () {
	
	worldPosition.x = 0;
	worldPosition.y = 0;
    worldPosition.z = 0;
		
	}
		
	
	public float myRound(float numToRound, float precision)
	{
	     //(float)precision;
		numToRound = numToRound * precision;
		numToRound = Mathf.Round(numToRound);
		numToRound = numToRound / precision;
		return numToRound;	
	//	return ((Mathf.Round(numToRound * precision)) / precision);
	}
	
	// Update is called once per frame
	void Update () {
		
		gameObject.transform.Translate (worldPosition.x, worldPosition.z, 0); //translate drift fix

		
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
			
			
			//currentTurnAmnt = myRound (currentTurnAmnt, roundingPrecision);   //fix it
			
			
			if (currentTurnAmnt > amntToTurn)						//see if thats too much
			{	
				currentTurnAmnt = amntToTurn;						//if it is change the amount to finish the turn
				
				currentTurnAmnt = myRound (currentTurnAmnt, roundingPrecision);   //fix it
			
				//amntToTurn = 0; //remove anything thats leftover
				
			}
			amntToTurn = amntToTurn - currentTurnAmnt;
			transform.Rotate(0, 0, currentTurnAmnt);  //fix it and //do the turn
			
			checkFlagRecheckCountdown = afterTurnCheckDelay; //give us some time after a turn to move;
		}
		if(amntToTurn == 0) //if we have no turn
		{
			gameObject.transform.Translate (Time.deltaTime * baseSpeedForward_Relative, 0, 0); //Go forward again
			worldPosition.y = 0;
		}

	}
}
