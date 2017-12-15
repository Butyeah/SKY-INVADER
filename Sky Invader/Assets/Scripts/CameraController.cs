using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public float moveSpeed;
	public float tileSpeedZ;

	private Vector3 startPosition;

// Use this for initialization
void Start () {
		startPosition = transform.position;
}

// Update is called once per frame
void Update () {

	// Käännetään vihollinen
	//transform.localScale = new Vector3(1f, 1f, 1f);
	//GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

	float newPosition = Mathf.Repeat (Time.time * moveSpeed, tileSpeedZ);
	transform.position = startPosition + Vector3.up * newPosition;
}
}