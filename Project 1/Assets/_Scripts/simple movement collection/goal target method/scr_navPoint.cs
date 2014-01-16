using UnityEngine;
using System.Collections;

public class scr_navPoint : MonoBehaviour {

		
	public Vector3 myXYZ = new Vector3();
	//public float myY;
	//public float myZ;
	// Use this for initialization
	void Start () {
		myXYZ = gameObject.transform.position;

	}
	
	public Vector3 myPosition()
	{
		return myXYZ;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
