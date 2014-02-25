using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// GUI
//	private bool render = false;
//	private Rect cameraRect = new Rect (10, 20, 340, 1000);
	private GUIStyle cameraStyle;

	GameObject planet1;
	GameObject planet2;
	GameObject planet3;
	GameObject ship;

	bool defaultCamera = true;
	bool followPlanet1 = false;
	bool followPlanet2 = false;
	bool followPlanet3 = false;
	bool followShip = false;

	Vector3 offset;

	Quaternion originalRotation = new Quaternion(0,0,0,0);
	
	// Use this for initialization
	void Start () {

		planet1 = GameObject.Find ("P1");
		planet2 = GameObject.Find ("P2");
		planet3 = GameObject.Find ("P3");
		ship = GameObject.Find ("ship");

		offset = transform.position;

	}
	
	// Update is called once per frame
	void Update () {

//		transform.position = sun.transform.position + offset;
	
	}

	void LateUpdate() {
		if (followPlanet1) {
			transform.eulerAngles = (new Vector3 (90, 0, 0));
			transform.position = planet1.transform.position + offset;
		}

		if (followPlanet2) {
			transform.eulerAngles = (new Vector3 (90, 0, 0));
			transform.position = planet2.transform.position + offset;
		}

		if (followPlanet3) {
			transform.eulerAngles = (new Vector3 (90, 0, 0));
			transform.position = planet3.transform.position + offset;
		}

		if (defaultCamera) {
			transform.eulerAngles = (new Vector3 (90, 0, 0));
			transform.position = new Vector3 (0, 90, 0);
		}

		if (followShip) {
//			
//			transform.position = ship.transform.position;
//			transform.position = new Vector3 (-20, 0, 0);
//			transform.Rotate (new Vector3 (-90, 90, 0) * 0);
			transform.eulerAngles = (new Vector3 (0, 90, 0));


			transform.position = ship.transform.position + new Vector3(5, 0, 0);
//			transform.Rotate (new Vector3 (-90, 90, 0) * 0);
//			transform.position = new Vector3 (0, 0, 0);
//			transform.Rotate (new Vector3 (90, 0, 0) * 0);
//			transform.Rotate (new Vector3 (-90, 0, 90) * 0);
		}
	}

	public void OnGUI() {
		//		if (GUI.Button (new Rect (10,20,100,20), "Show Window"))
		//			ShowWindow();
		//		
		//		if (GUI.Button (new Rect (10,60,100,20), "Hide Window"))
		//			HideWindow();
		
		GUI.skin.label.fontSize = 30;
		cameraStyle = new GUIStyle(GUI.skin.button);
		cameraStyle.fontSize = 30;

		if (GUI.Button (new Rect (10, 20, 280, 120), "X + 5", cameraStyle)) {
			transform.position += new Vector3(5, 0, 0);
		}
		
		if (GUI.Button (new Rect (10, 150, 280, 120), "X - 5", cameraStyle)) {
			transform.position += new Vector3(-5, 0, 0);
			
		}
		
		if (GUI.Button (new Rect (10, 280, 280, 120), "Z + 5", cameraStyle)) {
			transform.position += new Vector3(0, 0, 5);
		}
		
		if (GUI.Button (new Rect (10, 410, 280, 120), "Z - 5", cameraStyle)) {
			transform.position += new Vector3(0, 0, -5);
		}
		
		if (GUI.Button (new Rect (10, 540, 280, 120), "Pitch + 5", cameraStyle)) {
			
			//			if (paused == false) {
			//				PausePlanet();
			//				paused = true;
			//			}
			//			
			//			else {
			//				ResumePlanet();
			//				paused = false;
			//			}
		}
		
		if (GUI.Button (new Rect (10, 670, 280, 120), "Pitch - 5", cameraStyle)) {
			//			renderer.material = defaultMaterial;
			//			render = false;
			//			if(paused == true) {
			//				paused = false;
			//				ResumePlanet();
			//			}
		}
		
		if (GUI.Button (new Rect (10, 800, 280, 120), "Yaw + 5", cameraStyle)) {
			//			rotateSpeed -= 5;
		}
		
		if (GUI.Button (new Rect (10, 930, 280, 120), "Yaw - 5", cameraStyle)) {
			//			rotateSpeed -= 5;
		}

		// row 2
		if (GUI.Button (new Rect (300, 20, 280, 120), "Camera Planet 1", cameraStyle)) {
			defaultCamera = false;
			followPlanet1 = true;
			followPlanet2 = false;
			followPlanet3 = false;
			followShip = false;
		}

		if (GUI.Button (new Rect (300, 150, 280, 120), "Camera Planet 2", cameraStyle)) {
			defaultCamera = false;
			followPlanet1 = false;
			followPlanet2 = true;
			followPlanet3 = false;
			followShip = false;
		}

		if (GUI.Button (new Rect (300, 280, 280, 120), "Camera Planet 3", cameraStyle)) {
			defaultCamera = false;
			followPlanet1 = false;
			followPlanet2 = false;
			followPlanet3 = true;
			followShip = false;
		}

		//row 3
		if (GUI.Button (new Rect (590, 20, 280, 120), "Default Camera", cameraStyle)) {
			defaultCamera = true;
			followPlanet1 = false;
			followPlanet2 = false;
			followPlanet3 = false;
			followShip = false;
//			transform.position = new Vector3(0, 90, 0);
//			transform.Rotate(new Vector3(90, 0, 0) * 0);
		}
		
		if (GUI.Button (new Rect (590, 150, 280, 120), "Ship Camera", cameraStyle)) {
			defaultCamera = false;
			followPlanet1 = false;
			followPlanet2 = false;
			followPlanet3 = false;
			followShip = true;
		}

	}

	void FollowPlanet(GameObject obj) {

		transform.position = obj.transform.position;
	}
}
