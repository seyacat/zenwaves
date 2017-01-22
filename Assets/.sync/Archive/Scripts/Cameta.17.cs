using UnityEngine;
using System.Collections;

public class Cameta : MonoBehaviour {

	public GameObject[] tokens;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		touch_totem ();
	}
	void touch_totem(){
		foreach (Touch touch in Input.touches) {
			
				Debug.Log("Tocaste la pantalla ");


		}
		if(Input.GetKeyDown(KeyCode.Space)){
			Debug.Log("Tocaste la pantalla ");
		}
	}
}
