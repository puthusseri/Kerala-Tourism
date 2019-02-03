using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScreenBackControllere : MonoBehaviour {

	// Use this for initialization
	int screenIndex;
	void Start () {
		screenIndex = SceneManager.GetActiveScene().buildIndex;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			//SceneManager.LoadScene( screenIndex - 1 );
			SceneManager.LoadScene("Demo");
		}
	}
}
