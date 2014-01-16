using UnityEngine;
using System.Collections;

public class scr_movement_turning : MonoBehaviour {
 public scr_movement_ATC ATC_script;
  
	
	// Use this for initialization
	void Start () {
	ATC_script = GetComponent("scr_movement_ATC") as scr_movement_ATC;
	}
	
	// Update is called once per frame
	void Update () {
	
	
		if(ATC_script.turning_amountRemainingInTurn < 0)
		{
			ATC_script.turning_amountRemainingInTurn=0;
		}
		if(ATC_script.turning_amountRemainingInTurn > 0)
		{
			float amntToTurn = Time.deltaTime * ATC_script.travel_Turning_Rate;
			//"clean" amntToTurn
			//amntToTurn = Mathf.Round(amntToTurn * 10f) / 10f;
			if(amntToTurn > ATC_script.turning_amountRemainingInTurn)
			{
				
				amntToTurn = ATC_script.turning_amountRemainingInTurn;
				//amntToTurn = Mathf.Round(amntToTurn * 100f) / 100f;
				//ATC_script.turning_amountRemainingInTurn = 0;
			}
			else
				
			{
				amntToTurn = Mathf.Round(amntToTurn * 100f) / 100f;
				
			}
		    ATC_script.turning_amountRemainingInTurn = ATC_script.turning_amountRemainingInTurn - amntToTurn;
			
			
			if(ATC_script.turning_willTurnRight == true) //if turn right flag yes
			{
			transform.Rotate(0, 0, amntToTurn); //turn right
				
			//ATC_script.turning_amountRemainingInTurn = ATC_script.turning_amountRemainingInTurn - amntToTurn;
			}
			else
			{
			transform.Rotate(0, 0, -amntToTurn); //turn left
				
			//ATC_script.turning_amountRemainingInTurn = ATC_script.turning_amountRemainingInTurn - amntToTurn;
			}
		}	
		
			
	}
}
