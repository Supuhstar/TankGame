using UnityEngine;
using System.Collections;

public class ResizeGUI : MonoBehaviour {

	public dfGUIManager inGameUI;

	// Use this for initialization
	void Start () {
		inGameUI = gameObject.GetComponent<dfGUIManager>();
		inGameUI.FixedWidth = 1;
		inGameUI.FixedHeight = 1;
	}

	public float delay = 2;
	private float timeSinceLastUpdate = 0;
	// Update is called once per frame
	void Update () {
	}

	void OnGUI() {
		timeSinceLastUpdate += Time.deltaTime;
		if (timeSinceLastUpdate > delay)
		{
			timeSinceLastUpdate = 0;
			adjustGUISize ();
		}
	}

	void adjustGUISize()
	{
		inGameUI.FixedWidth = Screen.width;
		inGameUI.FixedHeight = Screen.height;
	}
}
