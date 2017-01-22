using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;

public class totem : MonoBehaviour {
	public float amplitud = 0.0f;
	public float longitud = 1f;
	public float velocidad = -0.3f;
	public float damp = 15.0f;
	public float ds=0;
	public Boolean encendido=false;
	public Boolean ishover=false;
	public float amplitud_default=0.0f;




	// Use this for initialization
	void Start () {
		
		//longitud = 0.3f;
		amplitud_default=amplitud;
		amplitud = 0.0f;
	}

	// Update is called once per frame
	void Update () {
		if (this.tag == "Totem_repulsivo") {
			velocidad = -0.3f;
		} else {
			velocidad = 0.3f;
		}
		ds = ds + velocidad;
		/*while (amplitud <0.13 && amplitud >= 0.04 && ishover==false){
			amplitud -= 0.01f;
		}*/
		if(encendido==false){
			DOTween.To (() => amplitud, x => amplitud = x,amplitud_default, 3);
		}
	
	}
	void  OnMouseEnter(){
		if (ishover == false) {
			ishover = true;
			encendido = false;
		}

	}
	void OnMouseExit(){
		ishover = false;
		encendido = false;
		DOTween.To (() => amplitud, x => amplitud = x,amplitud_default, 3);
	}
	void OnMouseDown (){
		// Tween a Vector3 called myVector to 3,4,8 in 1 second

		if (ishover==true) {
			if( amplitud <1){
				amplitud = +0.1f;
			}
			encendido = true;
		}
			

			}
	}





