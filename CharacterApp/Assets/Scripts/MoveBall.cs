using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour {

	float speed = 4;
	public float thrust = 40;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		Vector3 v = new Vector3(-1,0, 0)*30;
		rb.AddForce( v , ForceMode.Impulse);
	}
	
	void FixedUpdate()
	{
		if (rb != null) {
			float x, y, z;
			x = 10 * thrust; 
			y = 0;
			z = 0;
			rb.AddForce (this.gameObject.transform.forward * -30, ForceMode.Force);
			rb.AddForce (x,y,z, ForceMode.Impulse);
		} else {
			Debug.LogFormat ("Ridgebody is null");
		}
	}
		
}
