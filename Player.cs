using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D) && transform.position.x < 16f){
			transform.Translate(new Vector3(speed * 0.005f, 0, 0));
		}
		if(Input.GetKey (KeyCode.A) && transform.position.x > -16f){
			transform.Translate(new Vector3(-speed * 0.005f, 0, 0));
		}
	}
}
