using UnityEngine;
using System.Collections;

public class bee : MonoBehaviour {
	
	public float horizontalspeed;
	public float verticalspeed;
	public float amplitude;

	public Vector3 tempposition ;
	void Start(){
		//tempposition = transform.position;
		
	}

	void FixedUpdate() {


			tempposition.x += horizontalspeed;
			tempposition.y = Mathf.Sin (Time.realtimeSinceStartup * verticalspeed) * amplitude;
			transform.position = tempposition;

	}
}
