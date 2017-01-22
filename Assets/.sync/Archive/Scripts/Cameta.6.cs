using UnityEngine;
using System.Collections;

public class Cameta : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void touch_totem(){
		foreach (Touch touch in Input.touches|| Input.anyKey(E)) {
			Debug.Log("Tocaste la pantalla ");
		}
	}
}
