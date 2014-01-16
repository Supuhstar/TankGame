using UnityEngine;
using System.Collections;

public class scr_pointAtCenter : MonoBehaviour {
   
//	public Transform target = .;	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
       // transform.LookAt(Vector3.zero);
	   Vector3 navPoint1 = new Vector3 (0f, 0f, 0f);
	   Vector3 anchorPoint = new Vector3 (0f, 0f, 0f);
	   transform.LookAt(navPoint1,anchorPoint);
	
		//rotation fix
		transform.Rotate(270,0,-90);
	}
}
