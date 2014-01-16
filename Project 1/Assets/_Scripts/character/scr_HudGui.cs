using UnityEngine;
using System.Collections;

public class scr_HudGui : MonoBehaviour {
	
	public GameObject Player;
	//private scr_char_tank_Cntrl playerControl;
	public scr_gameController gameControll;
	public float hudXOffset = .0f;
	public float hudYOffset = .8f;
	public float hudXSize = .25f;
	public float hudYSize = .2f;
	public float bar2XOffset = .25f;
	public float bar3XOffset = .75f;
	
	public Texture tankHealth;
	public Texture targetHealth;
	
	// Use this for initialization
	void Start () {
		gameControll = GetComponent<scr_gameController>();
		//playerControl = Player.GetComponent<scr_char_tank_Cntrl>();

	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
	void OnGUI () {

    // GUI.Button(new Rect(Screen.width * (1f/6.55f),Screen.height * (0.1f/6.3f),Screen.width * (4.8f/6.55f), Screen.height * (0.85f/6.3f)),"Click"); //c#
	
		
	GUI.Box(new Rect(Screen.width * hudXOffset,Screen.height * hudYOffset,Screen.width * hudXSize, Screen.height * hudYSize), "Health");
	GUI.DrawTexture(new Rect(Screen.width * hudXOffset,Screen.height * hudYOffset + 20,Screen.width * hudXSize, Screen.height * hudYSize -20), tankHealth, ScaleMode.ScaleToFit, true, 0);
	//GUI.Box(new Rect(Screen.width * (hudXOffset + bar2XOffset),Screen.height * hudYOffset,Screen.width * hudXSize, Screen.height * hudYSize), "Weapon");
		
	GUI.Box(new Rect(Screen.width * (hudXOffset + bar3XOffset),Screen.height * hudYOffset,Screen.width * hudXSize, Screen.height * hudYSize), "Target");
	if(targetHealth)
		{
	GUI.DrawTexture(new Rect(Screen.width * (hudXOffset + bar3XOffset),Screen.height * hudYOffset +20,Screen.width * hudXSize, Screen.height * hudYSize -20), targetHealth, ScaleMode.ScaleToFit, true, 0);
		}
	}

}
