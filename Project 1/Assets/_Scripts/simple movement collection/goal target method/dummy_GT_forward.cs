using UnityEngine;
using System.Collections;

public class dummy_GT_forward : MonoBehaviour {
	public scr_mover_target_ATC ATC;
  

 
	void Start () {	
	  			ATC = GetComponent("scr_mover_target_ATC") as scr_mover_target_ATC;
	   			}
		
	

	

	void Update () {
		//scr_movement_ATC ATC_Script = GetComponent<gameobject.scr_movement_ATC>();	

	

	//	if(scr_movement_ATC. == 0) //if we have no turn
		if(!ATC.travel_STOP_Forward)
		{
			gameObject.transform.Translate (0, 0, Time.deltaTime * ATC.travel_Forward_Rate); //Go forward 
		}

	}
}
