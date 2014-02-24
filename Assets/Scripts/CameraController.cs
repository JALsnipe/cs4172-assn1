using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

//		transform.position = sun.transform.position + offset;
	
	}

	public void OnGUI() {

		GUI.skin.label.fontSize = 20;

//		GUI.matrix = Matrix4x4.TRS (Vector3.zero, Quaternion.AngleAxis (0, new Vector3 (0, 1, 0)), new Vector3 (FloatXSize, FloatYSize, 1));

		// Make a background box
//		GUI.Box(new Rect(10,10,100,90), "Loader Menu");
		GUI.Label (new Rect (10, 10 + 10, 200, 20), "Camera Controller");
		
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
//		if(GUI.Button(new Rect(20,40,80,20), "X + 5")) {
		if(GUI.Button(new Rect(20,40,320,80), "X + 5")) {
			print ("increasing camera X value by 5");
			print (transform.position);
//			rigidbody.AddForce(XPositiveFive);
//			rigidbody.AddRelativeForce(XPositiveFive);
			transform.position += new Vector3(5, 0, 0);
		}
		
		// Make the second button.
//		if(GUI.Button(new Rect(20,70,80,20), "X - 5")) {
		if(GUI.Button(new Rect(20,140,320,80), "X - 5")) {
			print ("decreasing camera X value by 5");
//			rigidbody.AddForce(XNegativeFive);
			transform.position += new Vector3(-5, 0, 0);
		}

		if(GUI.Button(new Rect(20,240,320,80), "Z + 5")) {
			print ("increasing camera Z value by 5");
			//			rigidbody.AddForce(XNegativeFive);
			transform.position += new Vector3(0, 0, 5);
		}

		if(GUI.Button(new Rect(20,340,320,80), "Z - 5")) {
			print ("decreasing camera Z value by 5");
			//			rigidbody.AddForce(XNegativeFive);
			transform.position += new Vector3(0, 0, -5);
		}

	}
}
