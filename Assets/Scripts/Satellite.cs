﻿using UnityEngine;
using System.Collections;

public class Satellite : MonoBehaviour {

//	public float orbitSpeed;
	public float degreeSpin;
//	public float speedAroundPlanet;
	public GameObject origin;

	public Material defaultMaterial;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

//		transform.RotateAround(Vector3.zero, Vector3.up, orbitSpeed * Time.deltaTime); //degrees/second

//		var degrees = 100;

		transform.RotateAround (origin.transform.position, Vector3.up, degreeSpin * Time.deltaTime);

//		transform.RotateAround (Vector3.zero, Vector3.up, speedAroundPlanet * Time.deltaTime);
	
	}

	void OnMouseOver () {
		
		if (Input.GetMouseButtonDown (0)) {
			
//			print(renderer.material.color);
			
			if (renderer.material.color == Color.green) {
				
				renderer.material = defaultMaterial;
				
			} else {
				
				renderer.material.color = Color.green;
				
			}
		}
	}
}
