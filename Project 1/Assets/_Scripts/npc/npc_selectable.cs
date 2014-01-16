using UnityEngine;
using System.Collections;

[RequireComponent (typeof (BoxCollider))]

public class npc_selectable : MonoBehaviour {
public bool selected = false;

public Material startMat;
public Material highlightMat;
public GameObject myGameObjectSkin;
//public scr_gameController gameController;
	
	// Use this for initialization
	void Start () {
		//startMat = gameObject.renderer.material;
		//gameController = (gameController)GetComponent(typeof(gameController));
		//gameController = GetComponent<scr_gameController>();
		startMat = 	myGameObjectSkin.renderer.material;
	}
	
	// Update is called once per frame
	void Update () {
		if(selected)
		{
			//gameObject.renderer.material=highlightMat;

				myGameObjectSkin.renderer.material = highlightMat;
			//	gameController.playerTarget = gameObject;
			

		}
		if(!selected)
		{
				myGameObjectSkin.renderer.material = startMat;
				//gameController.playerTarget = null;
		}
	
	}

}
