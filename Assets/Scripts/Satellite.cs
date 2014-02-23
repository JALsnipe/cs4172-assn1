using UnityEngine;
using System.Collections;

public class Satellite : MonoBehaviour {

//	public float orbitSpeed;
	public static float degreeSpin;
//	public float speedAroundPlanet;
	public GameObject origin;

	Material defaultMaterial;

//	public Material defaultMaterial;

	// Use this for initialization
	void Start () {
//		Material mat = new Material ("mat");
//		mat = renderer.material;

		defaultMaterial = new Material (renderer.material);

		degreeSpin = -40.0f;
//		Satellite.mat = renderer.material;
		//stored previous material
		//replace it with something else

	
	}
	
	// Update is called once per frame
	void Update () {

//		transform.RotateAround(Vector3.zero, Vector3.up, orbitSpeed * Time.deltaTime); //degrees/second

//		var degrees = 100;

		transform.RotateAround (origin.transform.position, Vector3.up, degreeSpin * Time.deltaTime);
		transform.Rotate (0, degreeSpin * Time.deltaTime, 0);


//		transform.RotateAround (Vector3.zero, Vector3.up, speedAroundPlanet * Time.deltaTime);
	
	}

	void OnMouseOver () {

//		print ("over satellite");
		
		if (Input.GetMouseButtonDown (0)) {
			
			print(renderer.material.color);

			renderer.material.color = Color.green;
			
//			if (renderer.material.color == Color.green) {
//				
//				renderer.material = defaultMaterial;
//				
//			} else {
//				
//				renderer.material.color = Color.green;
//				
//			}
		}
	}
}
