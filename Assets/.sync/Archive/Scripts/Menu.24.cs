using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
	public GameObject menu;
	public Button pause;
	public Button start;
	public Image pause_image;
	public Button settings;
	public Button creditos;
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
		if (ispause == false) {
			ispause = true;
		} else {
			ispause = false;
		}
//		pause.GetComponent<Image>().sprite =pause_image;
		if (ispause == true) {
			menu.SetActive (true);
		} else {
			menu.SetActive (false);
		}
	

	}
}
