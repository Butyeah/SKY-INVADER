using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	// Nykyinen tarkistuspiste
	public GameObject currentCheckPoint;

	// Referenssi pelihahmon koodiin
	private PlayerController player;

	// Alirutiinin viive
	public float respawnDelay;

	// Use this for initialization
	void Start () {

		// Haetaan PlayerController-luokka
		player = FindObjectOfType<PlayerController>();

	}

	public void RespanPlayer()
	{
		// Kutsutaan alirutiinia
		StartCoroutine("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo()
	{

		player.enabled = false;
		player.GetComponent<Renderer>().enabled = false;

		// Alirutiini pysähtyy tässä kohtaa
		yield return new WaitForSeconds(respawnDelay);

		// Siirretään pelihahmo viimeisempääm tarkistuspisteeseen
		player.transform.position = currentCheckPoint.transform.position;
		player.enabled = true;
		player.GetComponent<Renderer>().enabled = true;

	}
}
