using UnityEngine;
using System.Collections;

public class Planet2 : MonoBehaviour {

	public float rotateSpeed;

	public GameObject origin;

	public Material defaultMaterial;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
	
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