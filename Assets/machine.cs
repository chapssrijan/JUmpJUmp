using UnityEngine;
using System.Collections;

public class machine : MonoBehaviour {
	bool timer=false;
	
	Rigidbody2D rb;
	public float speed=1;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y >-0.5) {
			
			timer = false;
		}
		if (transform.position.y < 2.1) {
			
			timer = true;
		}
		
		if (timer) {
			rb.AddForce (transform.up * speed);
		} else {
			rb.AddForce(-transform.up* speed);
		}
		
	}
}
