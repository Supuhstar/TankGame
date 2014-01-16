using UnityEngine;
using System.Collections;

public class scr_cameraFollow : MonoBehaviour {
//public float highY = 200;
public Transform player;
public Vector3 offset = new Vector3(0, 800, 0);


	// Use this for initialization
	void Start () {
		//followTarget = GetComponent("player") as GameObject;
		
	}
	
	// Update is called once per frame
	void Update () {
		 transform.position = player.position + offset;
	 //transform.position = new Vector3(followTarget.transform.x, LockedY, followTarget.transform.z);
	}
}


//Transform target; // drag the target here (or find it at Start)

//void LateUpdate(){
 
  // you can also force the camera to look at the target:
  //transform.LookAt(target);
