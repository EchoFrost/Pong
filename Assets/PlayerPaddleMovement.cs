using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleMovement : MonoBehaviour {

    public KeyCode moveUp = KeyCode.W;
    public KeyCode movedown = KeyCode.S;
    public float speed = 10.0f;
    public float boundY = 2.25f;
    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
