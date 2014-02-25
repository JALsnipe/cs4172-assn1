using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

//	void OnCollisionEnter(Collision collision) {
//		if (collision.gameObject.name == "P1") {
//			print ("hit planet1!");
//		}

	void OnCollisionEnter(Collision collision)	{
		Debug.Log("Collided with " + collision.gameObject.name);
	}
	
}
