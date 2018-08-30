using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddleMovement : MonoBehaviour {

	private GameObject ball;
	private Vector2 ballPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}

	void Move () {
		if (!ball)
			ball = GameObject.FindGameObjectWithTag ("Ball");
        /*
		if (ball.GetComponent<BallControl> ().ballDirection == Vector2.right) {
			ballPosition = ball.transform.localPosition;

			if (transform.localPosition.y > bottomBounds && ballPosition.y < transform.localPosition.y) {
				transform.localPosition += new Vector3 (0, -moveSpeed * Time.deltaTime, 0);
			}

			if (transform.localPosition.y < topBounds && ballPosition.y > transform.localPosition.y) {
				transform.localPosition += new Vector3 (0, moveSpeed * Time.deltaTime, 0);
			}
		}
        */
	}
}
