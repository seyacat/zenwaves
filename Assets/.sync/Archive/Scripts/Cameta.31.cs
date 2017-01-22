using UnityEngine;
using System.Collections;

public class Cameta : MonoBehaviour {

	public Vector3 token;
	//Change me to change the touch phase used.
	TouchPhase touchPhase = TouchPhase.Ended;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void touch_screen(){
		if(Input.touches>0 && Input.GetTouch(0).phase == touchPhase){
			token = camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			
		}
		for(int i = 0; i < Input.touchCount; ++i){

		}
	}


}
