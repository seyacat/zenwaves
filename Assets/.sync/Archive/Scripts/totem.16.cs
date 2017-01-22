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
	public 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ds = ds + velocidad;
	}
	void OnMouseOver(){
		Debug.Log("ESTAS SELECCIONANDO EL OBJETO ");
	}
	void touch_screen(){
		for(int i = 0; i < Input.touchCount; ++i){
			
		}
	}

}
