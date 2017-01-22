using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
	public GameObject menu;
	public Button pause;
	public Button settings;
	public Button creditos;
	public GameObject creditos_text;
	public GameObject settings_text;
	public bool ispause = false;

	// Use this for initialization
	void Start () {
		menu.SetActive (false);
		settings_text.SetActive (false);
		creditos_text.SetActive (true);

	}
	
	// Update is called once per frame
	void Update () {
		if(ispause == false){pause.onClick.AddListener (show_menu);}
		creditos.onClick.AddListener (show_credits);
		settings.onClick.AddListener (show_settings);
		if(ispause==true){pause.onClick.AddListener (hide_menu);}
	}
	void show_menu(){
		ispause = true;
		if (ispause == true) {
			menu.SetActive (true);
				
		} else {
			menu.SetActive (false);
		}
	

	}
	void hide_menu(){
		
			menu.SetActive (false);
			ispause = false;


	}
	void show_credits(){
		creditos_text.SetActive (true);
		creditos_text.SetActive (false);
		Debug.Log("");
	}
	void show_settings(){
		settings_text.SetActive (true);
		creditos_text.SetActive (false);
	}
}
