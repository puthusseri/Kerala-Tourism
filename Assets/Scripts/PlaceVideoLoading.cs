﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlaceVideoLoading : MonoBehaviour {

	public void palce_Kannur() {
		SceneManager.LoadScene("Scene1");
	}
	public void place_Waterfall() {
		SceneManager.LoadScene("Scene2Waterfall");
	}
	public void quitTheApplication () {
		Application.Quit ();
	}
	
}
