using UnityEngine;
using System.Collections;

public class scr_pointAtTarget : MonoBehaviour {
	
public scr_mover_target_ATC ATC;
  
	
//	public scr_navPoint navPoint;
 public Vector3 Position = new Vector3(0,0,0); 
	//public GameObject tempHolder; 
	
	// Use this for initialization
	void Start () {
				ATC = GetComponent("scr_mover_target_ATC") as scr_mover_target_ATC;
	}
	
	
	// Update is called once per frame
	void Update () {
		
		//scr_navPoint localNav = FindObjectOfType(typeof(scr_navPoint));
      //  Position = other.myPosition();
		
		//tempHolder = ATC.moveToTarget;
		
		
	   transform.LookAt(ATC.moveToTarget.transform.position);
	
		//rotation fix
		transform.Rotate(270,0,-90);
	}
}
