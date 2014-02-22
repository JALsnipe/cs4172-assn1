using UnityEngine;
using System.Collections;

public class Planet3 : MonoBehaviour {

	public float rotateSpeed;

	public Material defaultMaterial;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
	
	}

	void OnMouseOver () {
		
		//		print ("over planet1");
		
		if (Input.GetMouseButtonDown (0)) {
			
			//			print(renderer.material.color);
			
			if (renderer.material.color == Color.green) {
				
				renderer.material = defaultMaterial;
//				renderer.material = "//Assets/Materials/Planet001/Maps/Materials/40_040percentland,8winterspring.mat";
				
			} else {
				
				renderer.material.color = Color.green;
				
			}
		}
		
		
	}
}
