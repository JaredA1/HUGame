using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public int speed;
	public GameObject bullet;
	public float rotateSpeed;
	//Used to track bullet spawnpoint
	public Transform bulletSpawn;
	//Used to reset shot timer
	public float timeConstant;
	private float shootTime;

	//Used for Targeting
	public GameObject crosshair;
	public Shoot shoot;
	public float MouseX;
	public float MouseY;
	//private Quaternion bulletSpawnRot;

	// Use this for initialization
	void Start () {
		//bulletSpawnRot.eulerAngles = new Vector3(0.0f, 0.0f, bulletSpawn.transform.rotation.z);
		shootTime = timeConstant;
	}
	
	// Update is called once per frame
	void Update () {
		// left and right movement
		/*if (Input.GetKey (KeyCode.D) && transform.position.x < 16f){
			transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
		}
		if(Input.GetKey (KeyCode.A) && transform.position.x > -16f){
			transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
		}
		*/
		MouseX = Input.mousePosition.x;
		MouseY = Input.mousePosition.y;
		shootTime -= Time.deltaTime;
		//Vector3.RotateTowards (transform.up, crosshair.transform.position, 360, 0.0f);
		//Rotats to look at mouse
		//Vector3 mouselocation = Camera.main.GetComponent<Camera> ().ScreenToWorldPoint (Input.mousePosition);
		                                                                           
		//transform.LookAt (mouselocation);

		//Mouse rotation code
		Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		diff.Normalize();
		float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

		//Shooting Mechanics
		if (Input.GetKey(KeyCode.Mouse0)) {

			shoot.fired = true;

			//tests to see if a set time has passed between shots
			if(shootTime <= 0)
			{
				//sets timer back to 1
				shootTime = timeConstant;
				Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
			}
		}


		//Rotational Movement
		if (Input.GetKey (KeyCode.RightArrow)) {

			RotateRight();
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
		
			RotateLeft();
		}
		if(Input.GetKey(KeyCode.F12)){
			timeConstant = 0;
		}
		if(Input.GetKey(KeyCode.F12)){
			timeConstant = 0;
		}
		if(Input.GetKey(KeyCode.F11)){
			timeConstant = 0.5f;
		}
	}

	void RotateRight() {
		//transform.Rotate((Vector3.forward * -90) * rotateSpeed);
		//Vector3.RotateTowards (transform.up, crosshair.transform.position, 360, 0.0f);

	}
	void RotateLeft() {
		transform.Rotate((Vector3.forward * 90) * rotateSpeed);
	}
 
}