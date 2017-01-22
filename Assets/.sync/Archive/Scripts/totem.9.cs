using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class totem : MonoBehaviour {
	public float amplitud = 0f;
	public float longitud = 0.1f;
	public float velocidad = -0.3f;
	public float damp = 0.0f;
	public float ds=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ds = ds + velocidad;
	}
	void interaction(){
		foreach(Touch touch in Input.touches){

				if (touch.phase == TouchPhase.Began)
				{
					Debug.Log(touch.position);

			
		}
			
		}
		
	}
}
