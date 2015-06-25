using UnityEngine;
using System.Collections;

public class spider : MonoBehaviour {

	bool timer=false;

	float timer1=0;
	Rigidbody2D rb;
	public float speed;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y >=-0.4) {
			
			timer = false;
			timer1=timer1+1;
		}
		if (transform.position.y <= 0.5) {
			
			timer = true;
			timer1=timer1+1;
		}

		if (timer==true ) {
			rb.AddForce (transform.up * speed);
			if(timer1==5)
			{
			rb.AddForce (transform.right*11);
			}
		} else {
			rb.AddForce(-transform.up* speed);

		}
		
	}

}

