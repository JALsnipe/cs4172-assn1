using UnityEngine;
using System.Collections;

public class Satellite : MonoBehaviour {

//	public float orbitSpeed;
	public float degreeSpin;
//	public float speedAroundPlanet;
	public GameObject origin;

//	public Material defaultMaterial;

	Material mat;

	// Use this for initialization
	void Start () {
		Material mat = new Material ("mat");
		mat = renderer.material;
//		Satellite.mat = renderer.material;
		//stored previous material
		//replace it with something else

	
	}
	
	// Update is called once per frame
	void Update () {

//		transform.RotateAround(Vector3.zero, Vector3.up, orbitSpeed * Time.deltaTime); //degrees/second

//		var degrees = 100;

		transform.RotateAround (origin.transform.position, Vector3.up, degreeSpin * Time.deltaTime);

		renderer.material = mat;


//		transform.RotateAround (Vector3.zero, Vector3.up, speedAroundPlanet * Time.deltaTime);
	
	}

	void OnMouseOver () {

//		print ("over satellite");
		
		if (Input.GetMouseButtonDown (0)) {
			
			print(renderer.material.color);
			
			if (renderer.material.color == Color.green) {
				
//				renderer.material = defaultMaterial;
				
			} else {
				
				renderer.material.color = Color.green;
				
			}
		}
	}
}
