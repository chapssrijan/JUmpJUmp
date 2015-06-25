using UnityEngine;
using System.Collections;

public class machine : MonoBehaviour {
	bool timer=false;
	Transform point;
	Rigidbody2D rb;
	public float speed=1;
	// Use this for initialization
	void Start () {
		point = transform.Find ("spawnpoint");
		rb = GetComponent<Rigidbody2D> ();
	}
	float timerb = 0;
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
			if (timerb <= Time.time) {
				 Instantiate (Resources.Load ("explosions_0"),point.position,point.rotation);
				timerb = Time.time + 0.1f;
			}
		}
		
	}
}
