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
		settings_text.SetActive (true);
		creditos_text.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
		if(ispause == false){pause.onClick.AddListener (show_menu);}
		creditos.onClick.AddListener (show_credits);
		settings.onClick.AddListener (show_settings);
		if(ispause==true){settings.onClick.AddListener (hide_menu);}
	}
	void show_menu(){
		
		if (ispause) {
			ispause != pause;
			menu.SetActive (true);
				
		} else {
			ispause != pause;
			menu.SetActive (false);
		}
	

	}
	void hide_menu(){

			menu.SetActive (false);


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
