using UnityEngine;
using System.Collections;

public class bee : MonoBehaviour {
	
	public float horizontalspeed;
	public float verticalspeed;
	public float amplitude;

	
	Rigidbody2D rb;
	public Vector2 tempposition ;
	void Start(){
		tempposition = new Vector2(transform.position.x,transform.position.y);
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update() {


			tempposition.x += horizontalspeed;
			tempposition.y = Mathf.Sin (Time.realtimeSinceStartup * verticalspeed) * amplitude;
			transform.position = tempposition;

	}
}
