using UnityEngine;
using System.Collections;

public class Planet2 : MonoBehaviour {

	public static float rotateSpeed;

	public Material defaultMaterial;

	bool paused;

	float planet2Orbit;
	float planet2Rotate;

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
			if (Physics.Raycast (ray, out hit) && hit.collider.gameObject.name == "P2") {
				
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
		
		planet2Orbit = EmptyPlanet2.speed;
		planet2Rotate = rotateSpeed;

		EmptyPlanet2.speed = 0.0f;
		Planet2.rotateSpeed = 0.0f;
		
	}
	
	void ResumePlanet() {
		
		EmptyPlanet2.speed = planet2Orbit;
		rotateSpeed = planet2Rotate;
	}
	
}