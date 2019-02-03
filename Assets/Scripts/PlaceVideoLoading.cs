using System.Collections;
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
	public void place_Wayanad() {
		SceneManager.LoadScene("SceneWayanad");
	}
	public void place_Ramakalmedu() {
		
		SceneManager.LoadScene("SceneRamakalmedu");
	}
	public void place_Boating() {
		
		SceneManager.LoadScene("SceneBoating");
	}
	public void place_Athirapally() {
		
		SceneManager.LoadScene("SceneAthirapally");
	}
	public void place_BekalFort() {
		
		SceneManager.LoadScene("SceneBekalFort");
	}
	public void place_Kochi() {
		
		SceneManager.LoadScene("SceneKochi");
	}
	public void place_Kottayam() {
		
		SceneManager.LoadScene("SceneKottayam");
	}
	public void place_TempleLake() {
		
		SceneManager.LoadScene("SceneTempleLake");
	}


	public void quitTheApplication () {
		Application.Quit ();
	}
	
}
