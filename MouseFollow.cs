using UnityEngine;
using System.Collections;


public class MouseFollow : MonoBehaviour {
	public Vector3 UltimatePosition = new Vector3(0,0,0);
	public float XMouse;
	public float YMouse;

	
	
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		XMouse = Input.mousePosition.x;
		YMouse = Input.mousePosition.y;
		Vector3 mouselocation = Camera.main.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
		transform.position = mouselocation;

		//print("MouseX: " + X + " MouseY: " + Y);
		
		//print(transform.position.x + "," + transform.position.y + "," + transform.position.z);
		if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1)  == true) {
			//print("click");
		}
		
	}
}