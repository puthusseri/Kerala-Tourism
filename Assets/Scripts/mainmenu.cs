﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour {
		
		public void playGame() {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
		public void quitTheApplication () {
			Application.Quit ();
		}
		void Start () {
		
		}
		void Update () {
			if(Input.GetKeyDown(KeyCode.Escape)){
				Application.Quit ();
			}
		}
}
