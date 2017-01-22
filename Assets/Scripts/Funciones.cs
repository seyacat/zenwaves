using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void changeScene(string str){		
		Application.LoadLevel(str);
		}

    public void changeDelayedScene(string str, int delay)
    {       
        StartCoroutine(changeDelayedSceneCR(str,delay));
    }
    IEnumerator changeDelayedSceneCR(string str,int delay) {
        yield return new WaitForSeconds(delay);       
        Application.LoadLevel(str);
    }
    public void changeDelayedNextScene(int delay)
    {       
        StartCoroutine(changeDelayedNextSceneCR(delay));
    }
     IEnumerator changeDelayedNextSceneCR(int delay)
    {
        yield return new WaitForSeconds(delay);
        Application.LoadLevel(Application.loadedLevel + 1);
    }

}
