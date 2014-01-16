using UnityEngine;
using System.Collections;

public class scr_movement_ATC : MonoBehaviour {


public float travel_Turning_Rate = 100;
public float travel_Forward_Rate = 75;
public bool travel_STOP_Forward = false;
public bool turning_willTurnRight = true;
	
public float turning_amountRemainingInTurn = 0;	
	
public float movement_Alert_Distance = 200;
	
public bool inRecovery = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		
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
	
}
