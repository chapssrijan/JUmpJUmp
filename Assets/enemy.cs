using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

	bool timer=false;

	Rigidbody2D rb;
	public float speed=5;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x >=-10.5) {

			timer = false;
		}
		if (transform.position.x <= -12.6) {

			timer = true;
		}

		if (timer) {
			rb.AddForce (transform.right * speed);
		} else {
			rb.AddForce(transform.right * -speed);
		}

	}
}