using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRPlayer_Movement : MonoBehaviour {
	
	public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public float speed = 3.0f;
    public bool moveForward;
	private CharacterController cc;
	
	// Use this for initialization
	void Start () {
		
		cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
