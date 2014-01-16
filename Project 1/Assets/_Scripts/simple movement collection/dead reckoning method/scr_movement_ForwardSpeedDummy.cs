using UnityEngine;
using System.Collections;

public class scr_movement_ForwardSpeedDummy : MonoBehaviour {
   public scr_movement_ATC ATC_script;
  
	

	
	
	
	
 
	void Start () {	
	  			ATC_script = GetComponent("scr_movement_ATC") as scr_movement_ATC;
	   			}
		
	

	

	void Update () {
		//scr_movement_ATC ATC_Script = GetComponent<gameobject.scr_movement_ATC>();	

	

	//	if(scr_movement_ATC. == 0) //if we have no turn
		if(!ATC_script.travel_STOP_Forward)
		{
			gameObject.transform.Translate (Time.deltaTime * ATC_script.travel_Forward_Rate, 0, 0); //Go forward 
		}

	}
}
