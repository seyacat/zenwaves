using UnityEngine;
using System.Collections;

public class Cameta : MonoBehaviour {

	public Vector3 token;
	//Change me to change the touch phase used.
	TouchPhase touchPhase = TouchPhase.Ended;
	public  float  number = 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		camera ();
	}
	void  camera(){
		const int orthographicSizeMin = 1;
		const int orthographicSizeMax = 6;
		if (Input.GetAxis("Mouse ScrollWheel") > 0) // forward
		{
			number = Camera.main.orthographicSize++;
		}
		if (Input.GetAxis("Mouse ScrollWheel") < 0) // back
		{
			number = Camera.main.orthographicSize--;
		}
		Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, orthographicSizeMin, orthographicSizeMax );
		//number = Input.GetAxis("Mouse ScrollWheel");
		//Camera.main.orthographicSize += number;

	}


}
