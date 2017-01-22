using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;
using UnityEngine.UI;


public class totem : MonoBehaviour {
	public float amplitud = 0.0f;
    float max_amplitud = 0.6f;
	public float longitud = 0.9f;
	public float velocidad = 0.3f;
	public float damp = 15.0f;
	public float ds=0;
	public Boolean ishover=false;
	public float amplitud_default=0.0f;
	
	
	public GUIText perdiste_mesaje;
	public GameObject text;
    public AudioSource ohmsound;

	// Use this for initialization
	void Start () {	
		
		amplitud_default=amplitud;
		amplitud = 0.0f;
	}

	// Update is called once per frame
	void FixedUpdate () {
		
		ds = ds + velocidad;	

		amplitud -= (0.003f);
		amplitud = Mathf.Clamp (amplitud, 0, 0.6f);

        if (amplitud > 0)
        {
            if (!ohmsound.isPlaying) { 
            ohmsound.Play(); }
            ohmsound.volume = amplitud / max_amplitud;

        }
        else {
            ohmsound.Stop();
        }
        		
		
	}
	void  OnMouseEnter(){
		if (ishover == false) {
			ishover = true;
		}

	}
	void OnMouseExit(){
		ishover = false;
	}
	void OnMouseDown (){	
				amplitud +=0.1f;
			}
	
	}





