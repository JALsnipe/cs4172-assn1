using UnityEngine;
using System.Collections;

public class EmptyPlanet1 : MonoBehaviour {

	public static float speed;

	// Use this for initialization
	void Start () {

		speed = 30.0f;
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.RotateAround (Vector3.zero, Vector3.up, speed * Time.deltaTime);
	
	}
}
