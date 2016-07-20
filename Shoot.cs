using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public int bulletspeed;
	//public Transform bulletSpawn;
	public  bool fired = false;
	public float time;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = transform.up * bulletspeed;


		if (fired){
			StartCoroutine(DestroyAfter());

		}
	}

	IEnumerator DestroyAfter()
	{
		yield return new WaitForSeconds (time);
		Destroy (gameObject);

	}
	

}
