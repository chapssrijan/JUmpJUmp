using UnityEngine;
using System.Collections;

public class beam : MonoBehaviour {
	public int damage=25;
	Rigidbody2D rb;
	public float speed =50;
	public string tag1;
	public float timer;

	public bool enemy =false;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 5);
		if (enemy) {
			
			GetComponent<SpriteRenderer >().color=Color.red;
			
		}
		
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		rb.AddForce (transform.up * speed);
	}
}
