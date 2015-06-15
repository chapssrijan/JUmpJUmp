using UnityEngine;
using System.Collections;

public class monster : MonoBehaviour {



	public float JumpSpeed = 100.0f;
	bool timers=false;
	
	Rigidbody2D rb;
	public float speed=1;
	void Start(){
		rb = GetComponent<Rigidbody2D> ();

	}
	void Jump()
	{ 
	rb.AddForce(Vector2.up *JumpSpeed);
		
	}
	float timer = 0;
	public float delay = 1;
	void Update() {
		if(timer<Time.time){
			Jump ();
			timer = Time.time + delay;
		}
		if (transform.position.x >=12) {
			
			timers = false;
		}
		if (transform.position.x <=5) {
			
			timers = true;
		}
		
		if (timers) {
			rb.AddForce (transform.right * speed);
		} else {
			rb.AddForce(-transform.right* speed);
		}
		

	}
}
