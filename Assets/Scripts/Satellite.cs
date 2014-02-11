using UnityEngine;
using System.Collections;

public class Satellite : MonoBehaviour {

//	public float orbitSpeed;
	public float degreeSpin;
	public float speedAroundPlanet;
	public GameObject origin;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

//		transform.RotateAround(Vector3.zero, Vector3.up, orbitSpeed * Time.deltaTime); //degrees/second

//		var degrees = 100;

		transform.RotateAround (transform.position, Vector3.up, degreeSpin * Time.deltaTime);

		transform.RotateAround (origin.transform.position, Vector3.down, speedAroundPlanet * Time.deltaTime);
	
	}
}
