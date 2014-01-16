using UnityEngine;
using System.Collections;

public class scr_simple_turnToTarget : MonoBehaviour {

public GameObject targetObject;
	public Transform target;
	public float turnSpeed = 1.0f;
	public Transform from;
	
   // public Transform to;
    public float speed = 0.01F;
	//public Transform target;
	
	void Start () {

	//ATC = GetComponent("scr_mover_target_ATC") as scr_mover_target_ATC;
				
	}
	

	void Update () {
				//Transform newRot = to.transform.position - from.transform.position;
			  from = gameObject.transform;
			  target = target.transform;
		      Vector3 relativePos = new Vector3(target.position.x,transform.position.y, target.position.z ) - transform.position;
        	  Quaternion rot = Quaternion.LookRotation(relativePos);
       		  //transform.rotation = rotation;
		      transform.rotation = Quaternion.Slerp(from.rotation, rot, Time.deltaTime * turnSpeed);
	}
}


  
  
