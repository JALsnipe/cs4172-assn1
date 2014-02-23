using UnityEngine;
using System.Collections;

public class Sun : MonoBehaviour {

	bool sunClicked;

	float planet1Orbit;
	float planet1Rotate;
	float satSpeed;
	
	float planet2Orbit;
	float planet2Rotate;
	
	float planet3Orbit;
	float planet3Rotate;

	Material defaultMaterial;

	// Use this for initialization
	void Start () {

		sunClicked = false;

		defaultMaterial = new Material (renderer.material);



//		defaultMaterial = renderer.material;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit) && hit.collider.gameObject.name == "Sun") {
			
				if (sunClicked == false) {
					sunClicked = true;
					renderer.material.color = Color.green;
					pausePlanets ();
				}

//				if (sunClicked == true) {
				else {
					sunClicked = false;
					renderer.material = defaultMaterial;
					resumePlanets ();
				}

			}
						
		}
	}

	void pausePlanets() {

		planet1Orbit = EmptyPlanet1.speed;
		planet1Rotate = Planet1.rotateSpeed;
		satSpeed = Satellite.degreeSpin;
		
		planet2Orbit = EmptyPlanet2.speed;
		planet2Rotate = Planet2.rotateSpeed;
		
		planet3Orbit = EmptyPlanet3.speed;
		planet3Rotate = Planet3.rotateSpeed;

		EmptyPlanet1.speed = 0.0f;
		Planet1.rotateSpeed = 0.0f;
		Satellite.degreeSpin = 0.0f;

		EmptyPlanet2.speed = 0.0f;
		Planet2.rotateSpeed = 0.0f;

		EmptyPlanet3.speed = 0.0f;
		Planet3.rotateSpeed = 0.0f;

	}

	void resumePlanets() {

		EmptyPlanet1.speed = planet1Orbit;
		Planet1.rotateSpeed = planet1Rotate;
		Satellite.degreeSpin = satSpeed;
		
		EmptyPlanet2.speed = planet2Orbit;
		Planet2.rotateSpeed = planet2Rotate;
		
		EmptyPlanet3.speed = planet3Orbit;
		Planet3.rotateSpeed = planet3Rotate;


	}

}