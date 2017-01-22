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
		if(Input.touchCount>0 && Input.GetTouch(0).phase == touchPhase){
			token = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			Vector2 token2D = new Vector2(token.x, token.y);
			RaycastHit2D hitInformation = Physics2D.Raycast(token2D, Camera.main.transform.forward);
			
		}
		for(int i = 0; i < Input.touchCount; ++i){
			if (hitInformation.collider != null) {
				//We should have hit something with a 2D Physics collider!
				GameObject touchedObject = hitInformation.transform.gameObject;
				//touchedObject should be the object someone touched.
				Debug.Log("Touched " + touchedObject.transform.name);
			}
		}
	
	}


}
