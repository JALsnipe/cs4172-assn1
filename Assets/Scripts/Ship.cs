using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

	Material defaultMaterial;

	// GUI
	private bool render = false;
	private Rect windowRect = new Rect (1300, 20, 340, 1000);
	private GUIStyle myStyle;

	bool col = false;
	string hitObj;

	Rect textArea = new Rect(890,0,Screen.width, Screen.height);

	// Use this for initialization
	void Start () {

		defaultMaterial = new Material( renderer.material );
	
	}
	
	// Update is called once per frame
	void Update () {

		// rotate test
//		transform.RotateAround (Vector3.zero, Vector3.up, 10.0f * Time.deltaTime);

		if (Input.GetMouseButtonDown (0)) {

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit) && hit.collider.gameObject.name == "Ship") {
//				print ("hit!");
				
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

		if (col) {
//			GUI.Label(Rect(0,0,100,100), "Hit " + hitObj);
			GUI.Label(textArea, "Hit " + hitObj);
//			transform.position = origPos; // broken?
			rigidbody.MovePosition( new Vector3 (-20, 0, 0));
		}
		
		GUI.skin.label.fontSize = 30;
		myStyle = new GUIStyle(GUI.skin.button);
		myStyle.fontSize = 30;
		
		if (render) {
			windowRect = GUI.Window (0, windowRect, DoMyWindow, "Ship Control");
		}
	}
	
	public void DoMyWindow(int windowID) {
		if (GUI.Button (new Rect (10, 20, 320, 150), "X + 5", myStyle)) {
			transform.Rotate(5, 0, 0);
		}
		
		if (GUI.Button (new Rect (10, 180, 320, 150), "X - 5", myStyle)) {
			transform.Rotate(-5, 0, 0);
			
		}
		
		if (GUI.Button (new Rect (10, 340, 320, 150), "Z + 5", myStyle)) {
			transform.Rotate(0, 0, 5);
		}
		
		if (GUI.Button (new Rect (10, 500, 320, 150), "Z - 5", myStyle)) {
			transform.Rotate(0, 0, -5);
		}
		
		if (GUI.Button (new Rect (10, 660, 320, 150), "Throttle", myStyle)) {
			rigidbody.AddForce(Vector3.up * 10, ForceMode.Acceleration);
//			rigidbody.AddRelativeForce (Vector3.forward * 5.0f * Time.deltaTime); 
		}
		
		if (GUI.Button (new Rect (10, 820, 320, 150), "Deselect", myStyle)) {
			renderer.material = defaultMaterial;
			render = false;
//			if(paused == true) {
//				paused = false;
//				ResumePlanet();
//			}
		}
	}

//	void OnCollisionEnter(Collision collision) {
//		if (collision.gameObject.name == "P1") {
//			print ("hit planet1!");
//		}

	void OnCollisionEnter(Collision collision)	{
		col = true;
		Debug.Log("Collided with " + collision.gameObject.name);

//		GUI.Label(Rect(0,0,100,100), "Hit " + collision.gameObject.name);
		hitObj = collision.gameObject.name;
	}
	
}
