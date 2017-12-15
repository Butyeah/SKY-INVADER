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

		if (Input.GetKey (KeyCode.A)) {

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}
		//Käännetään pelihahmo transformin avulla
		if (GetComponent<Rigidbody2D> ().velocity.x > 0) {

			//Suunta on oikea
			transform.localScale = new Vector3 (1f, 1f, 1f);
		} else if (GetComponent<Rigidbody2D> ().velocity.x < 0) {

			//suunta on vasemmalle
			transform.localScale = new Vector3 (-1f, 1f, 1f);
		}
		
	}
}
