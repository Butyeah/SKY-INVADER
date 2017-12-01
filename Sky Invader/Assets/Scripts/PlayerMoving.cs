using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour {

	public float MoveSpeed = 0;
	public float JumpHeight = 0;

	// maakosketus tranformed
	public Transform GroundCheck;
	public float groundCheckRadius = 0.1f;
	public LayerMask whatIsGround;
	private bool grounded;

	private bool doubleJumped;


	void FixedUpdate(){

		// grounded = true, kun ollaan maassa ja false kun ei olla maassa
		grounded = Physics2D.OverlapCircle (GroundCheck.position, groundCheckRadius, whatIsGround);
		//Debug.Log ("grounded = " + grounded);
	}



	
	// Update is called once per frame
	void Update () {

		//Debug.Log ("JumpHeight = " + JumpHeight);

		//ollaanko maassa?
		if (grounded) {
			//ollaan maassa, estetään tuplahyppy
			doubleJumped = false;
		}

		// Tarkistetaan voidaanko hypätä
		if (Input.GetKeyDown (KeyCode.Space) && grounded) {
			// Painettiin välilyöntinäppäintä , suoritetaan hyppy
			// velocity = nopeus
			// hyppy onnistuu jos ollaan maassa
			Jump ();


		}


		if (Input.GetKey (KeyCode.D)) {

			//liike oikealle
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (MoveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}

		if (Input.GetKey (KeyCode.A)) {

			//Liike vasemalle
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-MoveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}

		//Käännetään pelaaja sen transformin avulla
		if (GetComponent<Rigidbody2D> ().velocity.x > 0) {

			//Suunta oikea
			transform.localScale = new Vector3 (1f, 1f, 1f);
		} else if (GetComponent<Rigidbody2D> ().velocity.x < 0) {

			// suunta on vasemmalle
			transform.localScale = new Vector3 (-1f, 1f, 1f);
		}

	}

		void Jump(){
			GetComponent <Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}
