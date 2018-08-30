using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		Invoke("GoBall", 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GoBall(){
		rb2d.AddForce(new Vector2(-20, 0));
	}

	void ResetBall(){
		rb2d.velocity = Vector2.zero;
		transform.position = Vector2.zero;
	}

	void RestartGame(){
		ResetBall();
		Invoke("GoBall", 1);
	}

	void OnCollisionEnter2D (Collision2D coll) {
		if(coll.collider.CompareTag("Player")){
			Vector2 vel;
			vel.x = rb2d.velocity.x;
			vel.y = (rb2d.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
			rb2d.velocity = vel;
		}
	}
}
