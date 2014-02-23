using UnityEngine;
using System.Collections;

public class Planet3 : MonoBehaviour {

	public static float rotateSpeed;

	public Material defaultMaterial;

	bool paused;
	
	float planet3Orbit;
	float planet3Rotate;

	// Use this for initialization
	void Start () {

		rotateSpeed = 10.0f;
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);

		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit) && hit.collider.gameObject.name == "P3") {
				
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
		
		planet3Orbit = EmptyPlanet3.speed;
		planet3Rotate = rotateSpeed;
		
		EmptyPlanet3.speed = 0.0f;
		Planet3.rotateSpeed = 0.0f;
		
	}
	
	void ResumePlanet() {
		
		EmptyPlanet3.speed = planet3Orbit;
		rotateSpeed = planet3Rotate;
	}

}
