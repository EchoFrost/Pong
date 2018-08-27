using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleMovement : MonoBehaviour {
	// Use this for initialization
	void Start () {
        //Set our rigidbody property. Might be worth null checking this in the future if for some reason this doesn't return as expected.
        _rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //Get the current velocity from our rigidbody property
        Vector2 velocity = _rigidbody.velocity;

        if (Input.GetKey(_moveUp))
        {
            velocity.y = _speed;
        }
        else if (Input.GetKey(_moveDown))
        {
            velocity.y = -_speed;
        }
        else
        {
            velocity.y = 0;
        }

        //Set the rigidbody property to our new velocity
        _rigidbody.velocity = velocity;

        //Transform is a property of our gameobject. Fetch our gameobject's position.
        Vector3 position = transform.position;

        if (position.y > _movementBound)
        {
            position.y = _movementBound;
        }
        else if (position.y < -_movementBound)
        {
            position.y = -_movementBound;
        }

        //Set our position so we can't go outside our defined bounds.
        transform.position = position;
    }

    [SerializeField]
    private KeyCode _moveUp = KeyCode.W;
    [SerializeField]
    private KeyCode _moveDown = KeyCode.S;
    [SerializeField]
    private float _speed = 10.0f;
    [SerializeField]
    private float _movementBound = 3.6f;

    private Rigidbody2D _rigidbody;
}
