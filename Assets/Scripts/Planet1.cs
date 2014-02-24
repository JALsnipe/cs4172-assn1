using UnityEngine;
using System.Collections;

public class Planet1 : MonoBehaviour {

	public static float rotateSpeed;
//	public float orbitSpeed; //degrees

	public Material defaultMaterial;

	bool paused;

	float planet1Orbit;
	float planet1Rotate;
	float satSpeed;

	// GUI
	private bool render = false;
	private Rect windowRect = new Rect (1300, 20, 340, 1000);
	private GUIStyle myStyle;
	
	// Use this for initialization
	void Start () {

		rotateSpeed = 10.0f;

		paused = false;
		
		//		renderer.material = new Material( shaderText );
	
		defaultMaterial = new Material( renderer.material );
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (0, rotateSpeed * Time.deltaTime, 0);

		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit) && hit.collider.gameObject.name == "P1") {
				
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

		planet1Orbit = EmptyPlanet1.speed;
		planet1Rotate = rotateSpeed;
		satSpeed = Satellite.degreeSpin;

		EmptyPlanet1.speed = 0.0f;
		Planet1.rotateSpeed = 0.0f;
		Satellite.degreeSpin = 0.0f;


	}

	void ResumePlanet() {

		EmptyPlanet1.speed = planet1Orbit;
		rotateSpeed = planet1Rotate;
		Satellite.degreeSpin = satSpeed;
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

		GUI.skin.label.fontSize = 20;
		myStyle = new GUIStyle(GUI.skin.button);
		myStyle.fontSize = 20;
		
		if (render) {
			windowRect = GUI.Window (0, windowRect, DoMyWindow, "Planet 1 Control");
		}
	}
	
	public void DoMyWindow(int windowID) {
		if (GUI.Button (new Rect (10, 20, 320, 150), "Orbit Speed + 5", myStyle)) {
			print ("orbit + 5");
			EmptyPlanet1.speed += 5.0f;
		}

		if (GUI.Button (new Rect (10, 180, 320, 150), "Orbit Speed - 5", myStyle)) {
			print ("orbit - 5");
			EmptyPlanet1.speed -= 5.0f;

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
