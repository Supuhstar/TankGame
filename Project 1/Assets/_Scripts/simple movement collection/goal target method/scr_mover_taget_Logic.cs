using UnityEngine;
using System.Collections;

public class scr_mover_taget_Logic : MonoBehaviour {
	public scr_mover_target_ATC ATC;
  	public int currentCountDown = 100;
	public int maxCountDown = 100;
	public GameObject target1;
	public GameObject target2;
	public int stepper = 1;
	public int numberOfSteps = 2;
	
	// Use this for initialization
	void Start () {
				ATC = GetComponent("scr_mover_target_ATC") as scr_mover_target_ATC;
				target1 = GameObject.Find("pawn_Nav1");
				target2 = GameObject.Find("pawn_Nav2");
			 	ATC.moveToTarget = target1;
			
	}
	
	void step(){
		
		//step 2
				if(stepper == 2)
				{
					ATC.moveToTarget = target2;
					stepper++;
				}
		//step 1
				if(stepper == 1)
				{
					ATC.moveToTarget = target1;
					stepper++;
				}

		//step end
				if(stepper >= numberOfSteps +1)
				{
					stepper = 1;	
				}
			
		
		
	}
	
	
	// Update is called once per frame
	void Update () {
		
		if(currentCountDown <= 0)
		{
			currentCountDown = maxCountDown;
			step();
			currentCountDown--;
		}
		else
		{
			currentCountDown--;	
		}
		
	}
}
