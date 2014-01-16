using UnityEngine;
using System.Collections;

public class scr_mover_target_ATC : MonoBehaviour {

public float travel_Turning_Rate = 1;
public float travel_Forward_Rate = 75;
public bool travel_STOP_Forward = false;
public bool turning_willTurnRight = true;
	
public float currentHeading = 0;
public float goalHeading = 0;
public float rightOrLeft = 1;
	
//public float turning_amountRemainingInTurn = 0;	
	
//public float movement_Alert_Distance = 200;
	
//public bool inRecovery = false;

public GameObject moveToTarget;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		
	}
	
}
