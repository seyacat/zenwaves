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
	Boolean ishover=false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ds = ds + velocidad;
	}
	void OnMouseOver(){
		ishover = true;

	}
	void OnMouseDown (){
		if (ishover == true) {
			Debug.Log ("tocaste");
			ishover = false;
			while(amplitud>=0 && amplitud <1){
				amplitud += 0.1f;
			}
			if(amplitud>=1){
				amplitud = 1f;
			}
		}
	}



}
