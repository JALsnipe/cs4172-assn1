using UnityEngine;
using System.Collections;

public class Planet3 : MonoBehaviour {

	public static float rotateSpeed;

	Material defaultMaterial;

	bool paused;
	
	float planet3Orbit;
	float planet3Rotate;

	// GUI
	private bool render = false;
	private Rect windowRect = new Rect (1300, 20, 340, 1000);
	private GUIStyle myStyle;

	// Use this for initialization
	void Start () {

		rotateSpeed = 10.0f;

		paused = false;

		defaultMaterial = new Material( renderer.material );
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);

		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit) && hit.collider.gameObject.name == "P3") {
				
				if (render == false) {
					//					paused = true;
					renderer.material.color = Color.green;
					render = true;
					//					PausePlanet ();
				}
				
				//				if (sunClicked == true) {
				else {
					//					render = false;
					renderer.material = defaultMaterial;
					render = false;
					//					ResumePlanet ();
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

	public void ShowWindow() {
		render = true;
	}
	
	public void HideWindow() {
		render = false;
	}
	
	public void OnGUI() {
		//		if (GUI.Button (new Rect (10,20,100,20), "Show Window"))
		//			ShowWindow();
		//		
		//		if (GUI.Button (new Rect (10,60,100,20), "Hide Window"))
		//			HideWindow();
		
		GUI.skin.label.fontSize = 30;
		myStyle = new GUIStyle(GUI.skin.button);
		myStyle.fontSize = 30;
		
		if (render) {
			windowRect = GUI.Window (0, windowRect, DoMyWindow, "Planet 3 Control");
		}
	}
	
	public void DoMyWindow(int windowID) {
		if (GUI.Button (new Rect (10, 20, 320, 150), "Orbit Speed + 5", myStyle)) {
			EmptyPlanet3.speed += 5.0f;
		}
		
		if (GUI.Button (new Rect (10, 180, 320, 150), "Orbit Speed - 5", myStyle)) {
			EmptyPlanet3.speed -= 5.0f;
			
		}
		
		if (GUI.Button (new Rect (10, 340, 320, 150), "Rotation Speed + 5", myStyle)) {
			rotateSpeed += 5;
		}
		
		if (GUI.Button (new Rect (10, 500, 320, 150), "Rotation Speed - 5", myStyle)) {
			rotateSpeed -= 5;
		}
		
		if (GUI.Button (new Rect (10, 660, 320, 150), "Start/Stop", myStyle)) {
			
			if (paused == false) {
				PausePlanet();
				paused = true;
			}
			
			else {
				ResumePlanet();
				paused = false;
			}
		}
		
		if (GUI.Button (new Rect (10, 820, 320, 150), "Deselect", myStyle)) {
			renderer.material = defaultMaterial;
			render = false;
			if(paused == true) {
				paused = false;
				ResumePlanet();
			}
		}
	}


}
