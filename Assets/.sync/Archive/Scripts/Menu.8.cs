﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
	public GameObject menu;
	public Button pause;
	public bool ispause = false;

	// Use this for initialization
	void Start () {
		menu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		pause.onClick.AddListener (show_menu);
	}
	void show_menu(){
		ispause = true;
		if (ispause) {
			
		} else {
			
		}
		if (pause == true) {
			menu.SetActive (true);
		}
	}
}
