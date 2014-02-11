using UnityEngine;
using System.Collections;

public class Planet1 : MonoBehaviour {

	public float rotateSpeed;
	public float orbitSpeed; //degrees

	public Material defaultMaterial;

	public GameObject rotateAroundObject;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

//		var RotateSpeedAlongY = -10.0;
//		var RotateSpeedAlongZ = 0.0;
//		var RotateSpeedAlongX = 0.0;

		// Slowly rotate the object around its axis at 1 degree/second * variable.
//		transform.Rotate(Vector3.up * Time.deltaTime * RotateSpeedAlongY);
		transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
//		transform.Rotate(Vector3.forward * Time.deltaTime * RotateSpeedAlongZ);
//		transform.Rotate(Vector3.right * Time.deltaTime * RotateSpeedAlongX);

		// rotate around origin w/ a radius of 2? (Vector3.up)
//		transform.RotateAround(rotateAroundObject.transform.position, Vector3.up, orbitSpeed * Time.deltaTime); //degrees/second
	
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
