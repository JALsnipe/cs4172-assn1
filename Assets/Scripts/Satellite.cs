using UnityEngine;
using System.Collections;

public class Satellite : MonoBehaviour {
	
	public static float degreeSpin;
	public static float orbitSpeed;
	public GameObject origin;

	Material defaultMaterial;

	bool paused;

	float satSpeed;
	float satOSpeed;

	// GUI
	private bool render = false;
	private Rect windowRect = new Rect (1300, 20, 340, 1000);
	private GUIStyle myStyle;


	// Use this for initialization
	void Start () {

		paused = false;

		defaultMaterial = new Material (renderer.material);

		degreeSpin = -40.0f;

		orbitSpeed = 10.0f;
//		Satellite.mat = renderer.material;
		//stored previous material
		//replace it with something else

	
	}
	
	// Update is called once per frame
	void Update () {

//		transform.RotateAround(Vector3.zero, Vector3.up, orbitSpeed * Time.deltaTime); //degrees/second

//		var degrees = 100;

		transform.RotateAround (origin.transform.position, Vector3.up, orbitSpeed * Time.deltaTime);
		transform.Rotate (0, degreeSpin * Time.deltaTime, 0);

		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit) && hit.collider.gameObject.name == "Moon") {
				
				if (render == false) {
					renderer.material.color = Color.green;
					render = true;
				}
				
				else {
					renderer.material = defaultMaterial;
					render = false;
				}
				
			}
			
		}
	
	}

	void PauseSat () {

		satSpeed = Satellite.degreeSpin;
		satOSpeed = Satellite.orbitSpeed;

		Satellite.degreeSpin = 0.0f;
		Satellite.orbitSpeed = 0.0f;
		
		
	}
	
	void ResumeSat() {
		

		degreeSpin = satSpeed;
		orbitSpeed = satOSpeed;
	}
	
	public void ShowWindow() {
		render = true;
	}
	
	public void HideWindow() {
		render = false;
	}
	
	public void OnGUI() {
		
		GUI.skin.label.fontSize = 30;
		myStyle = new GUIStyle(GUI.skin.button);
		myStyle.fontSize = 30;
		
		if (render) {
			windowRect = GUI.Window (0, windowRect, DoMyWindow, "Satellite Control");
		}
	}
	
	public void DoMyWindow(int windowID) {
		if (GUI.Button (new Rect (10, 20, 320, 150), "Orbit Speed + 5", myStyle)) {
			orbitSpeed += 5.0f;
		}
		
		if (GUI.Button (new Rect (10, 180, 320, 150), "Orbit Speed - 5", myStyle)) {
			orbitSpeed -= 5.0f;
			
		}
		
		if (GUI.Button (new Rect (10, 340, 320, 150), "Rotation Speed + 5", myStyle)) {
			degreeSpin += 5;
		}
		
		if (GUI.Button (new Rect (10, 500, 320, 150), "Rotation Speed - 5", myStyle)) {
			degreeSpin -= 5;
		}
		
		if (GUI.Button (new Rect (10, 660, 320, 150), "Start/Stop", myStyle)) {
			
			if (paused == false) {
				PauseSat();
				paused = true;
			}
			
			else {
				ResumeSat();
				paused = false;
			}
		}
		
		if (GUI.Button (new Rect (10, 820, 320, 150), "Deselect", myStyle)) {
			renderer.material = defaultMaterial;
			render = false;
			if(paused == true) {
				paused = false;
				ResumeSat();
			}
		}
	}
	
}
