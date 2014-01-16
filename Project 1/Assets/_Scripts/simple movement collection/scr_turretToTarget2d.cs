using UnityEngine;
using System.Collections;

public class scr_turretToTarget2d : MonoBehaviour {
	public Transform from;
   // public Transform to;
    public float speed = 1.1F;
	public Transform target;
	
	

	public string playerName = "tank base";
	public GameObject thisTank;
	public scr_char_tank_Cntrl thisControl;

	
	
	// Use this for initialization
	void Start () {
		
		thisTank = GameObject.Find(playerName);
		thisControl = thisTank.GetComponent<scr_char_tank_Cntrl>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if(thisControl.turretTarget)
		{
			target = thisControl.turretTarget.transform;
		}
		else
		{
			target = null;
		}
		
		if(target)
		{
		 from = gameObject.transform;
	 	Vector3 relativePos = new Vector3(target.position.x,transform.position.y, target.position.z ) - transform.position;
		  Quaternion rot = Quaternion.LookRotation(relativePos);
		 transform.rotation = Quaternion.Slerp(from.rotation, rot, Time.deltaTime * speed);
		}
	}
}



  
  
