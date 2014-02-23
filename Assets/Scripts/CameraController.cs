using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	GameObject sun;
	public static Vector3 offset;

	// Use this for initialization
	void Start () {
	
		offset = transform.position;

		sun = GameObject.Find ("Sun");

	}
	
	// Update is called once per frame
	void Update () {

//		transform.position = sun.transform.position + offset;
	
	}
}
