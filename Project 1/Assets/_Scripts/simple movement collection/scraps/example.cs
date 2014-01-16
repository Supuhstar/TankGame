using UnityEngine;
using System.Collections;

public class example : MonoBehaviour {
    public scr_movement_ATC script;
 
	void Example() {
        script = GetComponent("scr_movement_ATC") as scr_movement_ATC;
      //  script.doSomething();
    }
}