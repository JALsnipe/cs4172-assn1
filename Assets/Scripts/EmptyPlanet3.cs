using UnityEngine;
using System.Collections;

public class EmptyPlanet3 : MonoBehaviour {

	public static float speed;

	// Use this for initialization
	void Start () {

		speed = 10.0f;
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.RotateAround (Vector3.zero, Vector3.up, speed * Time.deltaTime);
	
	}
}
