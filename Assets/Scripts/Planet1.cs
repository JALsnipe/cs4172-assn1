using UnityEngine;
using System.Collections;

public class Planet1 : MonoBehaviour {

	public static float rotateSpeed;
//	public float orbitSpeed; //degrees

	public Material defaultMaterial;

	bool paused;

	float planet1Orbit;
	float planet1Rotate;
	float satSpeed;
	
	// Use this for initialization
	void Start () {

		rotateSpeed = 10.0f;

		paused = false;
		
		//		renderer.material = new Material( shaderText );
	
		defaultMaterial = new Material( renderer.material );
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (0, rotateSpeed * Time.deltaTime, 0);

		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit) && hit.collider.gameObject.name == "P1") {
				
				if (paused == false) {
					paused = true;
					renderer.material.color = Color.green;
					PausePlanet ();
				}
				
				//				if (sunClicked == true) {
				else {
					paused = false;
					renderer.material = defaultMaterial;
					ResumePlanet ();
				}
				
			}
			
		}
	
	}

	void PausePlanet () {

		planet1Orbit = EmptyPlanet1.speed;
		planet1Rotate = rotateSpeed;
		satSpeed = Satellite.degreeSpin;

		EmptyPlanet1.speed = 0.0f;
		Planet1.rotateSpeed = 0.0f;
		Satellite.degreeSpin = 0.0f;


	}

	void ResumePlanet() {

		EmptyPlanet1.speed = planet1Orbit;
		rotateSpeed = planet1Rotate;
		Satellite.degreeSpin = satSpeed;
	}
}
