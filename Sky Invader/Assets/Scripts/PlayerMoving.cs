using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour {

	public float moveSpeed = 0;

	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.D)){

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}

		//Jatka TÄSTÄ
		
	}
}
