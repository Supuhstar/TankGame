using UnityEngine;
using System.Collections;

public class HealthDisplayManager : MonoBehaviour {

	public Color lowHealthColor = Color.red;
	public Color highHealthColor = Color.white;

	public dfProgressBar progressBar;
	public GameObject colorableModel;

	public float health = 1.0f;
	/*public float Health
	{
		get
		{
			return this.health;
		}
		set
		{
			this.health = value;
			if (progressBar)
				progressBar.Value = value;
			if (colorableModel)
				colorableModel.renderer.material.color =
					Color.Lerp(lowHealthColor, highHealthColor, value);
		}
	}*/

	// Use this for initialization
	void Start () {
		//Health = 1.0f;
		SetHealth (health);
	}

	void OnGUI()
	{
		SetHealth (health);
	}

	public void SetHealth(float newHealth)
	{
		this.health = newHealth;
		if (progressBar)
			progressBar.Value = newHealth;
		if (colorableModel)
			colorableModel.renderer.material.color =
				Color.Lerp(lowHealthColor, highHealthColor, newHealth);
	}
}